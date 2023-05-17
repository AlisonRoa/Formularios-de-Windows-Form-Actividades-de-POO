using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    //Implementamos la herenciA
    class Profesor:Persona
    {
        //campo
        string iNSS;
        double salario;
        //Composición,
        //Un profesr imparte clases en varios centros
        public List<Centro> Centros = new List<Centro>();
        //Constructor
        public Profesor()
        {
            Centros = new List<Centro>();
        }
        public Profesor(string iNSS, double salario)
        {
            this.iNSS = iNSS;
            this.salario = salario;
                       
        }
        //Propiedades
        public string INSS
        {
            get
            {
                return iNSS;
            }

            set
            {
                iNSS = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
    }
}
