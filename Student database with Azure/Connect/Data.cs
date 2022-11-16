using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_database_with_Azure
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patrynomic { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }

        public Data()
        {

        }

        public Data (int id, string Name, string Surname, string Patrynomic, string Birthdate, string Address, string Email, string Gender, string Status)
        {
            this.Id = id;
            this.Name = Name;
            this.Surname = Surname;
            this.Patrynomic = Patrynomic;
            this.Birthdate = Birthdate;
            this.Address = Address;
            this.Email = Email;
            this.Gender = Gender;
            this.Status = Status;
        }

    }
}
