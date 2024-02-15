using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUserManagement.ModelLayer
{
    public class UserDetail
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string MiddleName { get; set; }
        public int? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AlternateEmailAddress { get; set; }
        public int? Country { get; set; }
        public int? State { get; set; }
        public int? TenthMarks { get; set; }
        public string TenthBoard { get; set; }
        public int? TwelethMarks { get; set; }
        public string TwelethBoard { get; set; }

        // Navigation property to AddressDetail
        public virtual ICollection<AddressDetail> AddressDetails { get; set; }
    }
    public class AddressDetail
    {
        public int AddressID { get; set; }
        public int? UserID { get; set; }
        public int? AddressType { get; set; }

        // Navigation property to UserDetail
        public virtual UserDetail UserDetail { get; set; }
    }
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        // Navigation property to States
        public virtual ICollection<State> States { get; set; }
    }
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }

        // Foreign key to Country
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
    //public class State
    //{
    //    public int StateID { get; set; }
    //    public Nullable<int> CountryID { get; set; }
    //    public string StateName { get; set; }

    //    public virtual Country Country { get; set; }
    //}
}
