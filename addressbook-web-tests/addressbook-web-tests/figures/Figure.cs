using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures_tests
{
    class Figure
    {
        private bool colored = false;

        private bool Colored
        {
            get
            {
                return colored;
            }
            set
            {
                colored = value;
            }
        }
    }
}
