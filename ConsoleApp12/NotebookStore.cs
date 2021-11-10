using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class NotebookStore : IMarket
    {
        Notebook[] notebooks = new Notebook[0];
        int limit=20;

        public Notebook addNotebook(Notebook newNotebook)
        {       
            if (notebooks.Length < limit) 
            {
                Array.Resize(ref notebooks, notebooks.Length + 1);
                notebooks[notebooks.Length - 1] = newNotebook;

                return newNotebook;
            }
            else
            {
                Console.WriteLine("Limit kecibsiniz !");
                return newNotebook;
            }
            
        }
        public Notebook[] GetNotebooks()
        {
            return notebooks;
        }
    }
}
