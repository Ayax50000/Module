using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busqueda_RFC
{
    class Fuente_Datos
    {

       // LEE LA INFORMACION DE CONEXION A LAS FUENTES DE DATOS DEL ARCHIVO bd_name.txt

      static public string[] leer_info() 
        {
          string[] bdData = new string[20];
          try
          {
              StreamReader objReader = new StreamReader(@"C:\Program Files\Soporte\bd_name.txt");
              int selector = 0, x = 0;
              string valor;
              while ((valor = objReader.ReadLine()) != null) 
              {
                switch (selector) 
                {
                  case 0: 
                  { 
                    selector = 2; 
                    break; 
                  }
                  case 2:
                  { 
                    bdData[x] = valor;
                    selector = 0;
                    x++;
                    break;
                  }
                }
              }

              objReader.ReadLine();
              objReader.Close();
          } catch (Exception ex) {MessageBox.Show(ex.Message); }
          return bdData;
        }

    }
}
