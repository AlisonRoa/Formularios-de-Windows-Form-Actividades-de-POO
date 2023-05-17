using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    //Realizamos la Herencia
    class Alumno : Persona
    {
        // campos
        string exp;
        string tiulacion;
        // Composición: un estudiante solo puede estar en un centro
        Centro centro;

        // Agregamos el constructor vacío
        public Alumno(Centro centro)
        {
            this.centro = centro;
        }

        // Constructor con parámetros
        public Alumno(string exp, string tiulacion)
        {
            this.exp = exp;
            this.tiulacion = tiulacion;
        }

        // Propiedades
        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public string Tiulacion
        {
            get { return tiulacion; }
            set { tiulacion = value; }
        }

        // Propiedad para el centro
        public Centro Centro
        {
            get { return centro; }
            set { centro = value; }
        }
    }
}