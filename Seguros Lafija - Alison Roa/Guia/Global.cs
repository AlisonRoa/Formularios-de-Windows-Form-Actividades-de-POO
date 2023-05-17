using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guia.Global;

namespace Guia
{
    class Global
    {
        // Definimos las listas

        // Clientes
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente(1, "Maria", "Lopez", "0000-0000"),
            new Cliente (2, "Lorenzo", "Suarez", "0000-0000"),
            new Cliente (3, "Noel", "Mejia", "0000-0000")
         };

        // Polizas
        public static List<Poliza> Polizas = new List<Poliza>()
        {
            new Poliza (4, 1200, "6 meses", Clientes[0].Id ),
            new Poliza (5, 1000, "4 meses", Clientes[1].Id ),
            new Poliza (6, 800, "2 meses", Clientes[2].Id ),
        };

        // Autos
        public static List<Auto> Autos = new List<Auto>()
        {
            new Auto (7, "Corola", "123-456", "Toyota", "Negro", Polizas[0].NumPoliza),
            new Auto (8, "Corola", "123-456", "Toyota", "Negro", Polizas[1].NumPoliza),
            new Auto (9, "Corola", "123-456", "Toyota", "Negro", Polizas[2].NumPoliza),
        };

        // Accidentes
        public static List<Accidente> Accidentes = new List<Accidente>()
        {
            new Accidente (10, "Choque", "2005/04/25", "Vacia", Autos[0].Id),
            new Accidente (11, "Choque", "2015/08/06", "Vacia", Autos[1].Id),
            new Accidente (12, "Choque", "2022/04/18", "Vacia", Autos[2].Id),
        };

        // Usuarios
        public static List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario (13, "Juan", "123456"),
            new Usuario (14, "Jorge", "456"),
            new Usuario (15, "Alison", "29082004")
        };

        //Definimos clases
        public class Cliente
        {
            // campos
            int id;
            string nombre;
            string apellido;
            string numTelf;

            public Cliente(int id, string nombre, string apellido, string numTelf)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.Apellido = apellido; 
                this.numTelf = numTelf;

            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string NumTelf { get => numTelf; set => numTelf = value; }
        }

        // Poliza        
        public class Poliza
        {
            int numPoliza;
            double cantPaga;
            string cobertura;
            int idCliente;

            public Poliza(int numPoliza, double cantPaga, string cobertura, int idCliente)
            {
                this.NumPoliza = numPoliza;
                this.CantPaga = cantPaga;
                this.Cobertura = cobertura;
                IdCliente = idCliente;
            }

            public int NumPoliza { get => numPoliza; set => numPoliza = value; }
            public double CantPaga { get => cantPaga; set => cantPaga = value; }
            public string Cobertura { get => cobertura; set => cobertura = value; }
            public int IdCliente { get => idCliente; set => idCliente = value; }
        }

        // Auto
        public class Auto
        {
            int id;
            string modelo;
            string matricula;
            string marca;
            string color;
            int idPoliza;

            public Auto(int id, string modelo, string matricula, string marca, string color, int idPoliza)
            {
                this.Id = id;
                this.Modelo = modelo;
                this.Matricula = matricula;
                this.Marca = marca;
                this.Color = color;
                this.IdPoliza = idPoliza;
            }

            public int Id { get => id; set => id = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public string Matricula { get => matricula; set => matricula = value; }
            public string Marca { get => marca; set => marca = value; }
            public string Color { get => color; set => color = value; }
            public int IdPoliza { get => idPoliza; set => idPoliza = value; }
        }

        // Accidente
        public class Accidente
        {
            int id;
            string tipo;
            string fecha;
            string descripcion;
            int idAuto;

            public Accidente(int id, string tipo, string fecha, string descripcion, int idAuto)
            {
                this.Id = id;
                this.Tipo = tipo;
                this.Fecha = fecha;
                this.Descripcion = descripcion;
                this.IdAuto = idAuto;
            }

            public int Id { get => id; set => id = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public string Fecha { get => fecha; set => fecha = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public int IdAuto { get => idAuto; set => idAuto = value; }
        }

        // Usuario
        public class Usuario
        {
            int id;
            string user;
            string pass;

            public Usuario(int id, string user, string pass)
            {
                this.Id = id;
                this.User = user;
                this.Pass = pass;
            }

            public int Id { get => id; set => id = value; }
            public string User { get => user; set => user = value; }
            public string Pass { get => pass; set => pass = value; }
        }
    }
}
