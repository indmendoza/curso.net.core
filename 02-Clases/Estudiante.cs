using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Estudiante
    {   //Campo
        private int id;

        //Propiedad
        public int EstudianteId
        {
            set { id = value;
                if (value > 0)
                    id = value;                        
            }
            get { return id; }

        }
        //Propiedades
        public string Nombre { set; get; }
        public string ApellidoPaterno {  set; get; }
        public string ApellidoMaterno {  set; get; }

        //Metodos
        public string obtenerNombreCompleto()
        { 
            string nombrecompleto = this.Nombre + " "+ApellidoPaterno+" "+ApellidoMaterno;
            return nombrecompleto; 
        }
        //constructor
        public Estudiante()
        {
            Console.WriteLine("Se creo un objeto estudiante");
            this.Nombre = "";
            this.ApellidoPaterno = "";
            this.ApellidoMaterno = "";
        }

        //contructor
        public Estudiante(int id, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            Console.WriteLine("Se creo un objeto estudiante");
            this.id = id;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
        }

    }
}
