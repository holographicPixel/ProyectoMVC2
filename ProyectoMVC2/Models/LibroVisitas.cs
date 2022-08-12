using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProyectoMVC2.Models
{
    public class LibroVisitas
    {
        // Codificamos la clase para permitir almacenar los datos en el archivo de texto:
        public void Grabar(String nombre, String comentarios)
        {
            StreamWriter file = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            file.WriteLine("Nombre: " + nombre + "<br>Comentarios: " + comentarios + "<hr>");
            file.Close();
        }

        public string Leer()
        {
            StreamReader file = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            String text = file.ReadToEnd();
            file.Close();
            return text;
        }
    }
}