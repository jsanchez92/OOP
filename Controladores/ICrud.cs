using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public interface ICrud <T> where T : class
    {

        /*
            Es un contrato que obliga a las clases que la 
            implementas a cumplir con todos sus métodos y reglas
         */

        public string Add(T Data);
        public string Update(T Data);
        public string Delete(int Id);
        public T show(int Id);
        public DataTable Search(string TextoBuscar);
        

    }
}
