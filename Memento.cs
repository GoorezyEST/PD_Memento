using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_PD
{
    // The 'Memento' class
    internal class Memento
    {
        private string _state;

        // Constructor
        public Memento(string state)
        {
            this._state = state;
        }

        // Property
        public string State
        {
            get { return _state; }
        }
    }
}
