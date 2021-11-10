using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            NotebookStore kontakt = new NotebookStore();
            
            


            Notebook hp = new Notebook();
            hp.name = "Hp";
            hp.price = 500;
            hp.InStock = true;
            hp.Ram = 16;
            hp.Storage = 500;
            hp.Brand = "Pavilion";
            hp.Model = "HP Pavilion 15inc";

            Notebook dell = new Notebook();
            dell.name = "dell";
            dell.price = 800;
            dell.InStock = true;
            dell.Ram = 32;
            dell.Storage = 500;
            dell.Brand = "Latitude";
            dell.Model = "Dell Latitude 24inch";

            kontakt.addNotebook(hp);
            Notebook notebook = kontakt.addNotebook(dell);



            foreach(var i in kontakt.GetNotebooks())
            {
                Console.WriteLine(i.name);
                Console.WriteLine(i.price);
                Console.WriteLine(i.Brand);
                Console.WriteLine(i.Storage);
                Console.WriteLine(i.Model);
                Console.WriteLine(i.InStock); 
                Console.WriteLine("============================================");


            }



        }
    }
    abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public bool InStock { get; set; }
        public abstract void Showinfo();
    }


    class Notebook : Product
    {
        public int Ram ;
        public int Storage ;
        public string Brand ;
        public string Model ;

        public override void Showinfo()
        {
            throw new NotImplementedException();
        }
    }
}
