using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace busqueda_RFC
{
    static class Validador
    {
        private static char[] param_invalid = {'\'','%','*','_'};

        // VERIFICA QUE EL STRING DE ENTRADA NO CONTENGA UN PARAM_INVALID

        public static bool check_busqueda(string parametro) 
        {
            bool flag = true;
            foreach(char identificador in param_invalid)
            {
             foreach(char caracter in parametro)
             {
                 if (caracter == identificador) { flag = false; }
             }
            }
            return flag;
        }

    }
}
