using System;

namespace Hundeklub
{
    class Dog
    {

        enum Race
        {
            Terrier,
            Pitbull,
            Bulldog,
            Corgi,
        }

      
        private Race race;
       




        public int ID { get; set; }
        public string Name { get; set; }

        public int YearOfBirth { get; set; }
 

        public Dog(int ID, string Name, int YearOfBirth, Enum Race)
        {
            ID = ID;
            Name = Name;
            YearOfBirth = YearOfBirth;
            Race = Race;
        }

      

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {YearOfBirth}, , ID: {ID}");


        }
      
        public override string ToString()
        {
            return $"ID = {ID}, Name = {Name}, YearOfBirth{YearOfBirth}";
        
     }
    }
}

