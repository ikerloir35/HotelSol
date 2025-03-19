using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Controller.lib
{
    public class FormsActions
    {
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void AbrirFormulario<MiForm>(Panel p) where MiForm : Form, new()
        {
            Form? formulario;
            formulario = p.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.BackColor = Color.FromArgb(241, 249, 227);
                formulario.Dock = DockStyle.Fill;
                p.Controls.Add(formulario);
                p.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //METODO CERRAR FORMULARIO
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void CerrarFormulario<MiForm>(Panel p) where MiForm : Form, new()
        {
            Form? formulario;
            formulario = p.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia existe
            if (formulario != null)
                formulario.Close();

        }
    }
}
