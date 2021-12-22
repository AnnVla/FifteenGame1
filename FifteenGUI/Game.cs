using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Game
    {
        int[,] field;
        int x, y; // x - координата по горизонтали, y - по вертикали
        int x0, y0; // нуль - пустое поле
        Random rand;
        Caretaker history;
        public Game()
        {
            field = new int[4, 4];
            rand = new Random();
            history = new Caretaker();
        }

        private int CoordinatesToPosition(int x, int y) // координаты в номер кнопки
        {
            return x + 4 * y;
        }

        private void PositionToCoordinates(int position, out int x, out int y) // номер кнопки в координаты
        {
            x = position % 4;
            y = position / 4;
        }

        public void Start() // начальная расстановка игры
        {
            for (x = 0; x < 4; x++)
            {
                for (y = 0; y < 4; y++)
                {
                    field[x, y] = CoordinatesToPosition(x, y) + 1;
                    if (field[x, y] == 16)
                    {
                        field[x, y] = 0;
                        x0 = x;
                        y0 = y;
                    }
                }
            }

        }

        public int GetNumber(int position) // по позиции кнопки  возвращает значение в соотв. ячейке
        {
            PositionToCoordinates(position, out x, out y);
            if (x < 0 || y < 0) return 0;
            return field[x, y];
        }

        public void Shift(int position) //обмен с нулевой ячейкой
        {
            int x, y;         
            PositionToCoordinates(position, out x, out y);
            if ((Math.Abs(x0 - x) == 1 && Math.Abs(y0 - y) == 0) || (Math.Abs(x0 - x) == 0 && Math.Abs(y0 - y) == 1))
            {                
                field[x0, y0] = field[x, y];
                field[x, y] = 0;
                x0 = x;
                y0 = y;
            }
        }
        
        public void SaveHistory(int position)
        {
            history.Save(new Memento(CoordinatesToPosition(x0, y0)));
        }

        public void ShiftRandom() // перемешивание
        {            
            
            int a = rand.Next(4);
            int x = x0, y = y0;
            if (a == 0 && x < 3)
            {
                x++;
            }
            else if (a == 1 && x > 0)
            {
                x--;
            }
            else if (a == 2 && y < 3)
            {
                y++;
            }
            else if (a == 3 && y > 0)
            {
                y--;
            }

            Shift(CoordinatesToPosition(x, y));
        }

        public bool Check() // проверка выйгрыша
        {
            if (field[3, 3] != 0) return false;
            else
            {
                int i;
                for (i = 0; i < 16; i++)
                {
                    if (GetNumber(i) != (i + 1)) break;
                }
                if (i == 15) return true;
                else return false;

            }
        }
  

        public void RestoreMoves()
        {
            if (!history.Empty())
            {

                Memento mem = history.Restore();
                Shift(mem.Place);
            }
        }

    }
}
