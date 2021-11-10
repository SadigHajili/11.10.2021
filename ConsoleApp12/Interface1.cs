using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    interface IMarket
    {
        Notebook addNotebook(Notebook newNotebook);

        Notebook[] GetNotebooks();

    }
}

