using System;

namespace WebAddressbookTests
{
    public class ContactData:IEquatable<ContactData>,IComparable<ContactData>
    {

        public string Name;

        public ContactData(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            Name = FirstName + LastName;
            return Name == other.FirstName + other.LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }

        public override string ToString()
        {
            return "name=" + Name;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            Name = FirstName + LastName;
            return Name.CompareTo(other.FirstName + other.LastName);
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string TelHome { get; set; }
        public string TelMobile { get; set; }
        public string TelWork { get; set; }
        public string TelFax { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string HomePage { get; set; }
        public string BDay { get; set; }
        public string BMonth { get; set; }
        public string BYear { get; set; }
        public string ADay { get; set; }
        public string AMonth { get; set; }
        public string AYear { get; set; }
        public string SecAddress { get; set; }
        public string SecHome { get; set; }
        public string SecNotes { get; set; }
    }
}
