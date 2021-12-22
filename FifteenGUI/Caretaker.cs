using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Caretaker
    {
        public Stack<Memento> Mementos { get; private set; } //ЭТО СВОЙСТВО
       
        public Caretaker()
        {
            Mementos = new Stack<Memento>(); //создаем объект
        }

        public void Save(Memento mem)
        {
            Mementos.Push(mem);
        }

        public Memento Restore()
        {
            return Mementos.Pop();           
        }

        public bool Empty() 
        {
            if (Mementos.Count > 0)
            {
                return false;
            }
            else return true;
        }
    }
}
