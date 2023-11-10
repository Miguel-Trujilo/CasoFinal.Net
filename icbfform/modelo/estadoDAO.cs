using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icbfform.modelo
{
    public class estadoDAO
    {
        ORMDataContext bd = new ORMDataContext();
        public List<estadoJardin> consultarTodos()
        {
            return bd.estadoJardin.ToList();
        } 
    }
}
