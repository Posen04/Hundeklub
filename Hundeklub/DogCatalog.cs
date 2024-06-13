using System;
using System.Collections.Generic;

namespace Hundeklub
{
    public class DogCatalog 
    {
        private List<Dog> DogList;

        public DogCatalog()
        {
            DogList = new List<Dog>();
        }
        public void AddDog(Dog Dog)
        {
            DogList.Add(Dog);
        }
       
        public void RemoveDog(string DogName, List<Dog> Dogs)
        {
            var DogToRemove = Dogs.Find(Dog => Dog.Name == DogName);
            if (DogToRemove != null)
            {
                Dogs.Remove(DogToRemove);
                Console.WriteLine($"Dog '{DogName}'Removed from Registration");
            }
            else
            {
                Console.WriteLine($"Dog '{DogName}' Not found in registration");
            }
        }
        public void WriteDogs()
        {
            Console.WriteLine("List Of Dogs");
            foreach (var Dog in DogList)
            {
                Console.WriteLine($"Navn:{Dog.Name}, Year Of Birth:{Dog.YearOfBirth}");
            }
        }






       
        }
    }

