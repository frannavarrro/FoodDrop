using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDrop
{
    class Jugador
    {

        public Jugador()
        {
            direccion = 'N'; //Direccion nula

            x = 348;
        }

        public void Moverse()
        {
            if (direccion == 'L' && x>=-10) x -= 10;

            else if (direccion == 'R' && x<=690) x += 10;

            direccion= 'N';
        }
        public int X
        {
            get { return this.x; }

            set { this.x = value; }
        }

        public char Direccion
        {
            get { return this.direccion; }

            set { this.direccion= value; }
        }

        private int x;

        private char direccion;
    }
}
