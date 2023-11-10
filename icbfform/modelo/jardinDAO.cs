using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icbfform.modelo
{
    public class jardinDAO
    {
        ORMDataContext bd = new ORMDataContext();

        public void registrar(Jardines jardin)
        {
            bd.Jardines.InsertOnSubmit(jardin);
            bd.SubmitChanges(); 
        }

        public void editar(Jardines jardin)
        {
            Jardines jardinEditar = (from j in bd.Jardines 
                                     where j.id_jardin == jardin.id_jardin
                                     select j).FirstOrDefault();
            jardinEditar.nombre = jardin.nombre;
            jardinEditar.direccion = jardin.direccion;
            jardinEditar.id_estado = jardin.id_estado;
            bd.SubmitChanges();
        }

        public void eliminar(int idJardin)
        {
            Jardines jardinEliminar = (from j in bd.Jardines
                                       where j.id_jardin == idJardin
                                       select j).FirstOrDefault();
            bd.Jardines.DeleteOnSubmit(jardinEliminar);
            bd.SubmitChanges();
        }

        /*public List<Jardines> consultarTodos()
        {
            return bd.Jardines.ToList();
        }
        Otra alternativa*/
        public Object consultarTodos()
        {
            return (from j in bd.Jardines select j).ToList();
        }

    }
}
