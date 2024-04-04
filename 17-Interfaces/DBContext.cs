using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    internal interface IDBContext
    {
        void insert(Object entity);
        void update(Object entity);
        void select(int id);
        void delete(Object entity);

    }
    
    public class SQLDBContext : IDBContext
    {

        public void delete(object entity)
        {
            string query = "delete * from tabla where id =" + entity.GetType();
            Console.WriteLine("Esta eliminando el objeto en la base de datos sql server");

        }

        public void insert(object entity)
        {
            Console.WriteLine("Esta insertando el objeto en la base de datos sql server");
        }

        public void select(int id)
        {
            Console.WriteLine("Esta seleccionando el registro con el Id en sql server");

        }

        public void update(object entity)
        {
            Console.WriteLine("Esta actualizando el objeto en la base de datos sql server");

        }
    }
    
    public class OracleDBContext : IDBContext
    {

        public void delete(object entity)
        {
            string query = "DELETE * FROM tabla WHERE id:=" + entity.GetType();
            Console.WriteLine("Esta eliminando el objeto en la base de datos sql Oracle");

        }

        public void insert(object entity)
        {
            Console.WriteLine("Esta insertando el objeto en la base de datos sql oracle");
        }

        public void select(int id)
        {
            Console.WriteLine("Esta seleccionando el registro con el Id en sql oracle");

        }

        public void update(object entity)
        {
            Console.WriteLine("Esta actualizando el objeto en la base de datos sql oracle");

        }
    }
}
