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
    public partial class Form1 : Form
    {

        #region "Variables y Objetos globales"

        Contactos contactos = new Contactos();
        
        #endregion

        public Form1()
        {
            InitializeComponent();
            // Inicializamos los paneles
            panel_ingresar.Visible = false;
            panel_mostrar.Visible = false;
            // Inicializamos los valores del timer "tiempo"
            tiempo.Interval = 1000;
            tiempo.Enabled = true;
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            // Obtengo el tiempo de la PC y lo guardo en un string temporalmente
            // para despues separar la fecha de la hora.

            string tmp = DateTime.Now.ToString();
            char[] separador = { ' ' };
            string[] arreglo = tmp.Split(separador);
            lb_hora.Text = arreglo[1];

            // Para presentar la fecha

            string diaSemana = DateTime.Now.DayOfWeek.ToString();
            string diaNumero = DateTime.Now.Day.ToString();
            string mesNumero = DateTime.Now.Month.ToString();

            string diaSemanaEs = "";
            string mesNombre = "";

            switch (diaSemana)
            {
                case "Monday": diaSemanaEs = "LUNES"; break;
                case "Tuesday": diaSemanaEs = "MARTES"; break;
                case "Wednesday": diaSemanaEs = "MIERCOLES"; break;
                case "Thursday": diaSemanaEs = "JUEVES"; break;
                case "Friday": diaSemanaEs = "VIERNES"; break;
                case "Saturday": diaSemanaEs = "SABADO"; break;
                case "Sunday": diaSemanaEs = "DOMINGO"; break;
                default: diaSemanaEs = diaSemana; break;
            };

            switch (mesNumero)
            {
                case "1": mesNombre = "ENERO"; break;
                case "2": mesNombre = "FEBRERO"; break;
                case "3": mesNombre = "MARZO"; break;
                case "4": mesNombre = "ABRIL"; break;
                case "5": mesNombre = "MAYO"; break;
                case "6": mesNombre = "JUNIO"; break;
                case "7": mesNombre = "JULIO"; break;
                case "8": mesNombre = "AGOSTO"; break;
                case "9": mesNombre = "SEPTIEMBRE"; break;
                case "10": mesNombre = "OCTUBRE"; break;
                case "11": mesNombre = "NOVIEMBRE"; break;
                case "12": mesNombre = "DICIEMBRE"; break;
                default: mesNombre = mesNumero; break;
            };

            lb_fecha.Text = diaSemanaEs + ", " + diaNumero + " de " + mesNombre;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel_ingresar.Visible = true;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = true;
            pict_modificar.Visible = false;
            pict_eliminar.Visible = false;

            grid_mostrar.DataSource = contactos.mostrarContacto();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta la próxima...", "Esta cerrando la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pict_regresar_Click(object sender, EventArgs e)
        {
            panel_ingresar.Visible = false;
            limpiar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            contactos.nuevoContacto(txt_nombres.Text, txt_direccion.Text, txt_telefono.Text, txt_correo.Text);
            limpiar();
            MessageBox.Show("Nuevo contacto fue ingresado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar()
        {
            txt_nombres.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
        }

        private void pict_regresar2_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = false;
        }

        private void pict_modificar_Click(object sender, EventArgs e)
        {            
            Point punto = grid_mostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            Modificar md = new Modificar(contactos, n_fila);
            md.Show();
        }

        private void pict_eliminar_Click(object sender, EventArgs e)
        {
            Point punto = grid_mostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            DialogResult result = MessageBox.Show("Deseas eliminar el contacto: " + contactos.mostrarContacto().Rows[n_fila]["NOMBRES"] + "?","Eliminar un contacto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                contactos.eliminarContacto(n_fila);
            }
        }

        private void grid_mostrar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // este metodo se ejecuta cuando el usuario
            // selecciona una celda del datagrid "grid_mostrar"

            pict_modificar.Visible = true;
            pict_eliminar.Visible = true;
        }
    }
}
