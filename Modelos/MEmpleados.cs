using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MEmpleados : MPersonas
    {

        // Atributos de la clase
        public string Cargo { get; set; }        
        public string INSS { get; set; }
        public DateTime FechaContratacion { get; set; }


       //Sobrecarga de Constructores.
       //Sobrecarga de Metodos.
        public  MEmpleados() { } // constructor por defecto
        public  MEmpleados( string cargo) 
        {
        
        }
        public MEmpleados(string cargo, string Sexo)
        {

        }

    }
}

// Metodos Set y Get
// MVC
// Herencia
// Polimorfismo
// Costructores
// Sopbrecarga de Metos
