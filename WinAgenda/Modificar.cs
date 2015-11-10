using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAgenda
{
    public partial class Modificar : Form
    {
        Contactos contacto_tmp;
        int index;

        public Modificar(Contactos pcontactos, int index)
        {
            InitializeComponent();
            contacto_tmp = pcontactos;
            this.index = index;

            // llenar los campos del contacto que se va a modificar
            txt_nombres.Text = contacto_tmp.mostrarContacto().Rows[index]["NOMBRES"].ToString();
            txt_direccion.Text = contacto_tmp.mostrarContacto().Rows[index]["DIRECCION"].ToString();
            txt_telefono.Text = contacto_tmp.mostrarContacto().Rows[index]["TELEFONO"].ToString();
            txt_correo.Text = contacto_tmp.mostrarContacto().Rows[index]["E-MAIL"].ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // despues de que el usuario ha cambiado alguna informacion procedemos a guardar
            contacto_tmp.mostrarContacto().Rows[index]["NOMBRES"] = txt_nombres.Text;
            contacto_tmp.mostrarContacto().Rows[index]["DIRECCION"] = txt_direccion.Text;
            contacto_tmp.mostrarContacto().Rows[index]["TELEFONO"] = txt_telefono.Text;
            contacto_tmp.mostrarContacto().Rows[index]["E-MAIL"] = txt_correo.Text;

            // avisamos al usuario que los datos han sido modificados
            DialogResult result = MessageBox.Show("Los datos han sido modificados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // despues de que el usuario presione OK
            // se guarda los datos en el archivo y se cierra la ventana
            if (result == DialogResult.OK)
            {
                contacto_tmp.guardarEnFichero();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
