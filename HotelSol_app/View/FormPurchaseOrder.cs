using HotelSol.Controller.files;
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
    public partial class FormPurchaseOrder : Form
    {
        public FormPurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            PurchaseOrderParser purchaseOrderParser = new PurchaseOrderParser();

            List<string>? pn = purchaseOrderParser.GetPartNumber();

            if (!purchaseOrderParser.errorEnLectura())
            {
                if (pn != null)
                {
                    foreach (string part in pn)
                    {
                        listPartNumber.Items.Add(part);
                    }
                }
            }
            else
            {
                textError.Text = purchaseOrderParser.getDescripcionError();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
