using HotelSol.Controller.db;
using HotelSol.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol
{
    public partial class FormConsultaFactura : Form
    {
        HotelContext db = new HotelContext();
        Facturadb factdb;
        Factura factura;
        List<Factura> listaFacturas;

        public FormConsultaFactura()
        {
            InitializeComponent();
            factdb = new Facturadb(db);
            cargaFacturas();
        }

        public void cargaFacturas()
        {
            int i;
            listaFacturas = factdb.GetAll();
            foreach (var fact in listaFacturas) 
            {
                int n = dataFacturas.Rows.Add();

                dataFacturas.Rows[n].Cells[0].Value = fact.FacturaId.ToString();
                dataFacturas.Rows[n].Cells[1].Value = fact.Concepto;
                dataFacturas.Rows[n].Cells[2].Value = fact.FechaFactura.ToString("dd/MM/yyyy");
                dataFacturas.Rows[n].Cells[3].Value = fact.ReservaId.ToString();
                dataFacturas.Rows[n].Cells[4].Value = fact.Reserva.Cliente.DocumentId;
                dataFacturas.Rows[n].Cells[5].Value = fact.Total.ToString();
            }
        }
    }
}
