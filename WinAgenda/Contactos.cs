using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace WinAgenda
{
    public class Contactos
    {
        // Declaracion del objeto DataTable de forma global
        DataTable tablaContactos = new DataTable();


        // Constructor de la Clase "Contactos"
        public Contactos()
        {
            // Creamos las columnas de la "tablaContactos"
            tablaContactos.Columns.Add(new DataColumn("NOMBRES"));
            tablaContactos.Columns.Add(new DataColumn("DIRECCION"));
            tablaContactos.Columns.Add(new DataColumn("TELEFONO"));
            tablaContactos.Columns.Add(new DataColumn("E-MAIL"));

            // Cargamos los datos del fichero a la tabla
            // Siempre y cuando exista el archivo
            if (File.Exists(@"datosAgenda.dat"))
            {
                cargarArchivo();
            }
            
        }

        public void nuevoContacto(string nombre, string direccion, string telefono, string email)
        {
            // metodo que utilizamos para poder ingresar un nuevo contacto
            registrarContacto(nombre, direccion, telefono, email);
            guardarArchivo();
        }

        public void eliminarContacto(int index)
        {
            tablaContactos.Rows[index].Delete();
            guardarArchivo();
        }

        public DataTable mostrarContacto()
        {
            return tablaContactos;
        }

        private void registrarContacto(string nombre, string direccion, string telefono, string email)
        {
            // Creamos una fila y le ingresamos los datos
            DataRow fila = tablaContactos.NewRow();
            fila["NOMBRES"] = nombre;
            fila["DIRECCION"] = direccion;
            fila["TELEFONO"] = telefono;
            fila["E-MAIL"] = email;
            // Ingresamos la fila a la tabla
            tablaContactos.Rows.Add(fila);
        }

        public void guardarEnFichero()
        {
            guardarArchivo();
        }

        private void guardarArchivo()
        {
            StreamWriter escribir = new StreamWriter(@"datosAgenda.dat", false);
            for (int x = 0; x < tablaContactos.Rows.Count; x++)
            {
                string tmp = tablaContactos.Rows[x]["NOMBRES"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["DIRECCION"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["TELEFONO"].ToString();
                tmp += "|" + tablaContactos.Rows[x]["E-MAIL"].ToString();
                escribir.WriteLine(tmp);
            }
            escribir.Close();
        }

        private void cargarArchivo()
        {
            StreamReader leer = new StreamReader(@"datosAgenda.dat");
            while ( !leer.EndOfStream )
            {
                string texto = leer.ReadLine();
                char[] separador = { '|' };
                string[] arregloDatos = texto.Split(separador);
                registrarContacto(arregloDatos[0], arregloDatos[1], arregloDatos[2], arregloDatos[3]);
            }
            leer.Close();
        }

    }
}
