using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structuras
{
    struct Coordinate
    {
        //Propiedades
        public int x { get; set; }
        public int y { get; set; }

        //Constructor
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Metodo
        public void setSetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }

        //el metodo estatico se implementa en la clase Program

        //MEtodo statico Propio de la clase y no de un objeto
        public static Coordinate GetOrigin()
        {

            return new Coordinate();
        }
    }
}
