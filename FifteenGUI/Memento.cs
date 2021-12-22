using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Memento
    {
        public int Place { get; private set; }
        public Memento(int place)
        {
            this.Place = place;
        }
    }
}
