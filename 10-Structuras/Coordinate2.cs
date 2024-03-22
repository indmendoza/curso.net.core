using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Structuras
{
    class Coordinate2
    {
        //Campo
        private int _x, _y;

        //Evento
        public event Action<int>  CoordinateChange;

        //Propiedad
        public int x
        {
            get 
            { 
                return _x;
            }
            set
            {
                this._x = value;    
                CoordinateChange(this._x);
            }
        }
        
        //Propiedad
        public int y
        { 
            get
            {
                return _y;
            }
            set { 
                this.y = value;
                CoordinateChange(this._y);
           
            }
        }


    }
}
