using HotelSol.Controller.db;
using HotelSol.Controller.lib;
using HotelSol.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol.View
{
    public partial class FormVenta : Form
    {
        Producto? prod;
        Productodb db = new Productodb();
        Double TotalPedido;
        public FormVenta()
        {
            InitializeComponent();
            importar();
            inicializar();
        }

        private void inicializar()
        {
            ProdNameTxt.Text = "";
            DescLabel.Text = "";
            CantidadTxt.Text = "";
            CantidadTxt.Enabled = false;
            PrecioLbl.Text = "";
            TotalLbl.Text = "0";
            DataPedido.Rows.Clear();
            TotalPedido = 0;
            List<Producto> prodList = db.toList();
            foreach (Producto p in prodList)
            {
                ProdNameTxt.Items.Add(p.name);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                prod = db.FindByName(ProdNameTxt.Text);
                if (prod == null)
                {
                    MessageBox.Show("NO SE HA ENCONTRADO EL PRODUCTO");
                }
                else
                {
                    ProdNameTxt.Text = prod.name;
                    DescLabel.Text = prod.description.Replace("<p>", "").Replace("</p>", "");
                    PrecioLbl.Text = prod.list_price.ToString();
                    if (prod.qty_available <= 0)
                    {
                        CantidadTxt.Enabled = false;
                        MessageBox.Show("NO HAY DISPONIBILIDAD");
                    }
                    else
                    {
                        CantidadTxt.Enabled = true;
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod == null)
                {
                    MessageBox.Show("Introduzca un producto");
                }
                else if (CantidadTxt.Text == "")
                {
                    MessageBox.Show("Introduzca una cantidad");
                }
                else
                {
                    var cantidad = Double.Parse(CantidadTxt.Text);
                    Double totalProd = cantidad * prod.list_price;                    
                    DataPedido.Rows.Add(prod.idOdoo.ToString(), prod.name, prod.description.Replace("<p>", "").Replace("</p>", ""), prod.list_price.ToString(), cantidad, totalProd.ToString());
                    TotalPedido += totalProd;
                    TotalLbl.Text = TotalPedido.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importar()
        {
            PyUtils py = new PyUtils();
            String msg = "Productos importados: ";
            if (!py.EjecutarScriptPython())
            {
                msg = " NO SE HAN IMPORTADO PRODUCTOS ";
            }
            else
            {
                Productodb productodb = new Productodb();
                var n = productodb.LoadProductFile();
                msg = msg + n.ToString();
            }

            MessageBox.Show(msg);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            importar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int id;
            int qty;
            String idText;
            String qtyText;
            PyUtils py = new PyUtils();
            try
            {
                if (DataPedido.Rows.Count > 1)
                {
                    foreach (DataGridViewRow row in DataPedido.Rows)
                    {
                        if (row != null && row.Cells["ProdId"].Value != null)
                        {
                            idText = row.Cells["ProdId"].Value.ToString();
                            qtyText = row.Cells["Cantidad"].Value.ToString();
                            id = Int32.Parse(idText);
                            qty = Int32.Parse(qtyText);
                            prod = db.FindByOdooId(id);
                            if (prod != null)
                            {
                                prod.qty_available -= qty;
                                db.Update(prod);
                                py.ActualizaQtyOdoo(idText, qtyText); //actualizamos la cantidad en Odoo
                            }
                        }
                    }
                }
                MessageBox.Show("VENTA FINALIZADA");
                inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }
    }
}
