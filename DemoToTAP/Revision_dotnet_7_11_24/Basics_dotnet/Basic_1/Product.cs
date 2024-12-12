using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    public  class Product:IDisposable
    {
        public string Title {  get; set; }  
        public double UnitPrice { get; set; }
        public Product() { }

        public void Dispose()
        {
            //Release resource which are occupied during 
            //life time of Object till now
            //Deterministic Finalization
            Console.WriteLine("Dispose is invoked....");
            GC.SuppressFinalize(this);
        }
        
        ~Product() {

            //indeterministic finalization
            Console.WriteLine("Finalize(destructor) is invoked....");
        }
    }
}
