using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пятнашки
{
    class Pyatnaska
    {
        int size;
        int[,] map;
        int spacex, spacey;
        static Random Org = new Random();
        
        public  Pyatnaska(int size)
        {
            if (size < 2) size= 2;
            if (size > 5) size = 5;
            this.size = size;
            map = new int[size, size];

            

        }
        public void RandometoLife()
        {
            int a = Org.Next(0, 4);
            int x = spacex;
            int y = spacey;
            switch(a)
            {
                case 0:x--;break;
                case 1:x++;break;
                case 2:y--;break;
                case 3:y++;break;

            }
            Peremeshenie(koordinat(x, y));

        }
        public bool check_numbers()
        {
            if (!(spacex == size - 1 &&
                spacey == size - 1))
                return false;
            for(int x=0;x<size;x++)
               for (int y = 0; y < size; y++) 
            if (x == size - 1 && y == size - 1)
                return true;
            else
            {
                if (map[x, y] == koordinat(x, y) + 1) ;
                return false;
            }
            return true;
        }
        public void start()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map[x, y] = koordinat(x, y) + 1;
            spacex = size - 1;
            spacey = size - 1;
            map[spacex, spacey] = 0;
        }
        public void Peremeshenie(int Position)
        {
            int x, y;
            Nomer(Position, out x, out y);
            if (Math.Abs(spacex - x) + Math.Abs(spacey - y) != 1)
            {
                return;
            }
           
            map[spacex, spacey] = map[x,y];
            map[x, y] = 0;
            spacex = x;
            spacey = y;
            

        }
        public int getnumber(int Position)
        {
            int x, y;
            Nomer(Position, out x, out y);
            if (x < 0 || x >= size) return 0;
            if (x < 0||x>=size) return 0;
           
            return map[x, y];
        }
        private int koordinat(int x,int y)
        {
            if (x < 0 ) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0 )y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }
        private void Nomer(int Position,out int x,out int y)
        {
            if (Position < 0) Position = 0;
            if (Position > size * size - 1) Position = size * size-1;
            x = Position % size;
            y = Position / size;
        }
    }
}
