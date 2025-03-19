using HabitacionSol.Controller.db;
using HotelSol.Controller.db;
using HotelSol.Model;
using ReservaSol.Controller.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemporadaSol.Controller.db;
using TipoAlojamientoSol.Controller.db;

namespace HotelSol
{
    public partial class FormCheckIn : Form
    {
        HotelContext db = new HotelContext();
        Clientedb? clientedb;
        Cliente? cliente;
        Habitaciondb? habitaciondb;
        Habitacion? habitacion;
        Reservadb Reservadb;
        Reserva? reserva;
        TipoAlojamientodb tadb;
        TipoAlojamiento ta;
        Temporadadb Temporadadb;
        Temporada Temporada;
        int numPers;
        int idCliente;


        public FormCheckIn()
        {
            InitializeComponent();
            clientedb = new Clientedb(db);
            habitaciondb = new Habitaciondb(db);
            Reservadb = new Reservadb(db);
            tadb = new TipoAlojamientodb(db);
            Temporadadb = new Temporadadb(db);
            inicializar();
        }

        private void inicializar()
        {
            numPersTxt.Text = "";
            tipoHabTxt.Text = "";
            habAsigTxt.Text = "";
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            numPersTxt.Enabled = false;
            reserva = null;

            comboTAloja.Items.Clear();
            
            List<TipoAlojamiento> taList = tadb.GetAllTiposAlojamientos();
            foreach (var ta in taList){
                comboTAloja.Items.Add(ta.NombreAlojamiento);
            }

        }

        private void datosReserva()
        {
            reserva.Cliente = cliente;
            reserva.ClienteId = cliente.ClienteId;
            reserva.HabitacionId = habitacion.HabitacionId;
            reserva.Habitacion = habitacion;
            reserva.TipoAlojamientoId = ta.TipoAlojamientoId;
            reserva.TipoAlojamiento = ta;
            reserva.Estado = 1;
            reserva.numPers = numPers;
            DateTime dtR = Convert.ToDateTime(fecReserva.Text, CultureInfo.CurrentCulture);
            DateTime dtI = Convert.ToDateTime(fecSalidaTxt.Text, CultureInfo.CurrentCulture);
            DateTime dtF = Convert.ToDateTime(fecSalidaTxt.Text, CultureInfo.CurrentCulture);
            reserva.FechaReserva = dtR;
            reserva.FechaEntrada = dtI;
            reserva.FechaSalida = dtF;

            habAsigTxt.Text = reserva.Habitacion.numHab.ToString();
            tipoHabTxt.Text = reserva.Habitacion.tipoHabitacion;
        }

        private void buscaReserva()
        {
            Boolean checkinRealizado = false;
            //Buscamos la reserva, si no la encuentra se asignará una automáticamente si hay habitación
            if (reserva == null)
            {
                reserva = Reservadb.GetByReservaPendienteCliente(cliente.ClienteId);
                if (reserva == null)   //busca si ya se ha realizado el chekin
                {
                    reserva = Reservadb.GetByReservaEnCursoCliente(cliente.ClienteId);
                    checkinRealizado = true;
                }
            }

            // Si ha encontrado una reserva pasa los datos
            if (reserva != null)
            {
                btnAsignRoom.Enabled = !checkinRealizado;
                habAsigTxt.Text = reserva.Habitacion.numHab.ToString();
                tipoHabTxt.Text = reserva.Habitacion.tipoHabitacion;
                comboTAloja.Text = reserva.TipoAlojamiento.NombreAlojamiento;
                comboTAloja.Enabled = false;
                numPersTxt.Text = reserva.numPers.ToString();
                numPersTxt.Enabled = true;
                fecSalidaTxt.Text = reserva.FechaSalida.ToString("dd/MM/yyyy");
                fecEntradaTxt.Text = reserva.FechaEntrada.ToString("dd/MM/yyyy");
                fecReserva.Text = reserva.FechaReserva.ToString("dd/MM/yyyy");
            }
            else
            {
                fecReserva.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fecSalidaTxt.Text = DateTime.Now.ToString("dd/MM/yyyy");
                fecEntradaTxt.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void btnBuscar_click(object sender, EventArgs e)
        {
            inicializar();
            try
            {
                cliente = clientedb.GetByDocumentId(DocIdTxt.Text);

                if (cliente == null)
                {
                    MsgTxt.Text = "No existe el cliente, por favor registrélo";
                    MsgTxt.Visible = true;
                }
                else
                {
                    idCliente = cliente.ClienteId;
                    nomTxt.Text = cliente.Nombre;
                    paisTxt.Text = cliente.Direccion.pais;
                    localidadTxt.Text = cliente.Direccion.Localidad;
                    cpTxt.Text = cliente.Direccion.CP;
                    calleTxt.Text = cliente.Direccion.Calle1;
                    ap1Txt.Text = cliente.Apellido1;
                    ap2Txt.Text = cliente.Apellido2;
                    tipoCliTxt.Text = cliente.TipoCliente;
                    numTarjetaTxt.Text = cliente.numTarjeta;
                    numPersTxt.Enabled = true;

                    buscaReserva();
                 }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }

        }

        /*
         * Busca la reserva libre y si no existe la crea
         */
        private Boolean createReserva()
        {
            if (habitacion != null)
            {
                if (reserva == null)
                {
                    reserva = new Reserva();
                    if (setTemporada()) //prova de trobar una temporada a aplicar
                    {
                        reserva.Temporada = Temporada;
                        reserva.TemporadaId = Temporada.TemporadaId;
                    } else
                    {
                        reserva.Temporada = null;
                        reserva.TemporadaId = null;
                    }
                    habitaciondb.Update(habitacion);

                }
                datosReserva();
            }
            return true;
        }

        private Boolean setTemporada()
        {
            try
            {
                if (Temporada == null)
                {
                    Temporada = Temporadadb.GetCurrent();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return (Temporada != null);
        }

        private Boolean setHabitacion()
        {
            if (cliente != null && habitacion == null)
            {
                habitacion = habitaciondb.GetFirstFree(numPers);
                if (habitacion != null)
                        habitacion.Estado = "OCUPADO";
            }
            return habitacion != null;
        }

        private Boolean setTipoAlojamiento()
        {
            var taText = comboTAloja.Text;
            ta = tadb.GetByNombreAlojamiento(taText);
            return (ta != null);    
        }

        private void btnAsignRoom_Click(object sender, EventArgs e)
        {
            try
            {
                MsgTxt.Text = "";
                numPers = Int32.Parse(numPersTxt.Text);
                if (numPers == 0) MsgTxt.Text = "Por favor indique cuantas personas";
                else if (setHabitacion()) {
                    if (setTipoAlojamiento())
                    {
                        if (createReserva())
                        {
                                                        
                            if (Reservadb.Graba(reserva))
                            {
                                MsgTxt.Text = "ChekIn Realizado";
                                btnAsignRoom.Enabled = false;
                            }
                            else
                            {
                                MsgTxt.Text = "NO SE HA PODIDO REALIZAR EL CHECK-IN";
                            }
                        }
                    }
                    else MsgTxt.Text = "Selecciona Tipo De Alojamiento";
                }
                else { MsgTxt.Text = "No hay habitaciones libres, no se puede hacer check-in"; }

                if (MsgTxt.Text != "") MsgTxt.Visible = true;
            }

            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
            }
            
        }
    }
}
