using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MClientes : MPersonas
    {
        public int IngresosMensuales { get; set; }     

        public int OtrosIngresos { get;  set; }
         
        



        public MClientes() { }
        public MClientes( int Ingreso) {

            Ingreso = this.IngresosMensuales;
        
        }

        public void AumentarOtrosIngresos(int valor)
        {
            this.OtrosIngresos = valor;
        }

        // sobreescritura de metodos
        public override string ToString() {
            return $"Hola {IngresosMensuales.ToString()} {OtrosIngresos.ToString()}";
        }

    }
}
