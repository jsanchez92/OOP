using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CEmpleados : ICrud<MEmpleados> 
    {
        public CEmpleados() { 
            
        }

        public string Add(MEmpleados Data)
        {
            throw new NotImplementedException();
        }

        public string Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string TextoBuscar)
        {
            throw new NotImplementedException();
        }

        public MEmpleados show(int Id)
        {
            throw new NotImplementedException();
        }

        public string Update(MEmpleados Data)
        {
            throw new NotImplementedException();
        }
    }

}
