using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
 class Program
    {
        public static DogCatalog DogCatalog { get; private set; }

        static void Main(string[] args)
        {
            DogCatalog = new DogCatalog();

            DogCatalog.AddDog(new Dog(1, "Jens", 2020, Terrier));


            DogCatalog.WriteDog();
            }
           
        }

    }  
