using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent.Model
{
    public class ModelStudent
    {
        private string code;
        public string Code { get; set; }

        private string lastName;
        public string LastName { get; set; }

        private string firstName;
        public string FirstName { get; set; }

        private DateTime birthDay;
        public DateTime BirthDay { get; set; }
        private String placeBirth;
        public String PlaceBirth { get; set; }

        private Boolean sex;
        public Boolean Sex { get; set; }
        private String phoneNumber;
        public string PhoneNumber { get; set; }


    }
}
