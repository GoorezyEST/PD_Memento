using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_PD
{
    // The 'Caretaker' class
    internal class Caretaker
    {
        private List<Memento> _mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            _mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return _mementoList[index];
        }
    }
}
