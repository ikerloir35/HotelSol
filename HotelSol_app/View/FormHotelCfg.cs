using HotelSol.Model;
using HotelSol.Controller.db;

namespace HotelSol
{
    public partial class FormHotelCfg : Form
    {
        HotelContext? hotelContext;
        Hotel? hotel;
        Hoteldb? hotdb;

        public FormHotelCfg()
        {
            InitializeComponent();
        }

        private void FormHotelCfg_Load(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";
                hotelContext = new();
                hotdb = new();
                hotel = hotdb.GetFirst();

                if (hotel != null)
                {
                    cifTxt.Text = hotel.CIF;
                    HotelIdTxt.Text = hotel.HotelId.ToString();
                    calleTxt.Text = hotel.Direccion.Calle1;
                    cpTxt.Text = hotel.Direccion.CP;
                    localidadTxt.Text = hotel.Direccion.Localidad;
                    paisTxt.Text = hotel.Direccion.pais;
                    descTxt.Text = hotel.Descripcion;
                    HotelIdTxt.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }

        }


        private void grabar_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            try
            {
                setHotelTxt();

                if (hotdb != null && hotel != null)
                {
                    if (!hotdb.Graba(hotel))
                    {
                        errorLabel.Text = hotdb.ObtenDescError();
                    }
                }

            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void setHotelTxt()
        {
            if (hotel == null)
            {
                hotel = new();
            }
            hotel.Descripcion = descTxt.Text;
            hotel.CIF = cifTxt.Text;
            hotel.Direccion.Calle1 = calleTxt.Text;
            hotel.Direccion.Calle2 = "-";
            hotel.Direccion.CP = cpTxt.Text;
            hotel.Direccion.Localidad = localidadTxt.Text;
            hotel.Direccion.pais = paisTxt.Text;
            hotel.Descripcion = descTxt.Text;
        }

        private void cargarFichero_Click(object sender, EventArgs e)
        {
            FormPurchaseOrder formPurchaseOrder = new FormPurchaseOrder();
            formPurchaseOrder.ShowDialog();
        }
    }
}
