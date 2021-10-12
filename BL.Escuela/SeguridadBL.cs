using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasenia)//Método / Función.
        {
            if (usuario == "master" && contrasenia == "123")
            {
                return true;
            }
            else
            {
                if (usuario == "estuden" && contrasenia == "456")
                {
                    return false;
                }

            }
            return false;
        }
    }
}
