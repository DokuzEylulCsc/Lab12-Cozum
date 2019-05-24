using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class View : IView
    {
        public void update(string input)
        {
            Console.WriteLine(input);
        }
    }
}
