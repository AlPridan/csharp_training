using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string nickName;
        private string title;
        private string company;
        private string address;
        private string telHome;
        private string telMobile;
        private string telWork;
        private string telFax;
        private string email1;
        private string email2;
        private string email3;
        private string homePage;
        private string bDay;
        private string bMonth;
        private string bYear;
        private string aDay;
        private string aMonth;
        private string aYear;
        private string secAddress;
        private string secHome;
        private string secNotes;

        public ContactData(string firstName)
        {
            this.firstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
          
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string TelHome
        {
            get
            {
                return telHome;
            }
            set
            {
                telHome = value;
            }
        }
        public string TelMobile
        {
            get
            {
                return telMobile;
            }
            set
            {
                telMobile = value;
            }
        }
        public string TelWork
        {
            get
            {
                return telWork;
            }
            set
            {
                telWork = value;
            }
        }
        public string TelFax
        {
            get
            {
                return telFax;
            }
            set
            {
                telFax = value;
            }
        }
        public string Email1
        {
            get
            {
                return email1;
            }
            set
            {
                email1 = value;
            }
        }
        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }
        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }
        public string HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
            }
        }
        public string BDay
        {
            get
            {
                return bDay;
            }
            set
            {
                bDay = value;
            }
        }
        public string BMonth
        {
            get
            {
                return bMonth;
            }
            set
            {
                bMonth = value;
            }
        }
        public string BYear
        {
            get
            {
                return bYear;
            }
            set
            {
                bYear = value;
            }
        }
        public string ADay
        {
            get
            {
                return aDay;
            }
            set
            {
                aDay = value;
            }
        }
        public string AMonth
        {
            get
            {
                return aMonth;
            }
            set
            {
                aMonth = value;
            }
        }

        public string AYear
        {
            get
            {
                return aYear;
            }
            set
            {
                aYear = value;
            }
        }

        public string SecAddress
        {
            get
            {
                return secAddress;
            }
            set
            {
                secAddress = value;
            }
        }
        public string SecHome
        {
            get
            {
                return secHome;
            }
            set
            {
                secHome = value;
            }
        }

        public string SecNotes
        {
            get
            {
                return secNotes;
            }
            set
            {
                secNotes = value;
            }
        }
    }
}
