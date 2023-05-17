using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    class Persona
    {
        //campos
        int id;
        string nombre;
        string direccion;
        string telf;
        string email;

        //Constructor vacio y se puede omitir
        public Persona(int id, string nombre, string direccion, string telf, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telf = telf;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telf { get => telf; set => telf = value; }
        public string Email { get => email; set => email = value; }
        public int UltimoId { get => ultimoId; set => ultimoId = value; }

        private static int ultimoId = 0;

        public Persona()
        {
            Id = ++ultimoId;
        }
    }

}
