using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_e_MYSQL.Classes
{
    class Validador
    {
        

        public bool CampoNome(string txt, ref string msg)
        {
            if(txt.Length < 3)
            {
                msg = "O nome precisa conter mais que 3 letras.";
                return false;
            }
            if(txt.Length > 40)
            {
                msg = "O nome precisa conter menos que 40 letras.";
                return false;
            }
            else
            {
                msg = "";
                return true;
            }
        }

        public bool CampoCodigo(string txt, ref string msg)
        {
            if (txt.Length < 4)
            {
                msg = "O código precisa conter no minimo 4 digitos.";
                return false;
            }
            if (int.TryParse(txt, out int a))
            {
                if(a > 0)
                {
                    msg = "";
                    return true;
                }
                else
                {
                    msg = "O valor precisa ser positivo.";
                    return false;
                }
            }
            else
            {
                msg = "O valor precisa ser numérico.";
                return false;
            }
        }

        public bool CampoDecimal(string txt, ref string msg)
        {
            if(decimal.TryParse(txt, out decimal a))
            {
                if(a > 0)
                {
                    msg = "";
                    return true;
                }
                else
                {
                    msg = "Valor precisa ser positivo.";
                    return false;
                }
            }
            else
            {
                msg = "Valor precisa ser numérico.";
                return false;
            }
        }
    }
}
