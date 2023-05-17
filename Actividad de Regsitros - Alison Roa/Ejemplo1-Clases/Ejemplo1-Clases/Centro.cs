using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    class Centro
    {
        string nombre;
        string dir;
        string telf;
        string email;

        public Centro()
        { }
        public Centro(string nombre, string dir, string telf, string email)
        {
            this.nombre = nombre;
            this.dir = dir;
            this.telf = telf;
            this.email = email;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Dir
        {
            get
            {
                return dir;
            }

            set
            {
                dir = value;
            }
        }

        public string Telf
        {
            get
            {
                return telf;
            }

            set
            {
                telf = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
