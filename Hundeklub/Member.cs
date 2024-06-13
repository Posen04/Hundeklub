using System;

namespace Hundeklub
{
    class Member
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Adress { get; set; }

        public String Email { get; set; }

        public String Birthdate { get; set; }
        public int Phone { get; set; }



        public Member(int ID, String Name, String Adress, String Email, int Phone, String Birthdate)
        {
            ID = ID;
            Name = Name;
            Adress = Adress;
            Email = Email;
            Phone = Phone;
            Birthdate = Birthdate;
        }

        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}, Adress:{Adress},Email:{Email}, Phone{Phone}, Birthdate {Birthdate}";
        }

      
        public int CalculateBirthdate()
        {
            return DateTime.Now.Year - Birtdate;
        }
        
           

        }
    }
