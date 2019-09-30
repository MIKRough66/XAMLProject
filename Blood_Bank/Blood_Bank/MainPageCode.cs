using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class MainPageCode
    {
        public int _staffID;
        public int StaffID
        {
            get => this._staffID;
            set
            {
                this._staffID = value;
            }
        }

        public string _title;
        public string Title
        {
            get => this._title;
            set
            {
                this._title = value;
            }
        }

        public string _firstName;
        public string FirstName
        {
            get => this._firstName;
            set
            {
                this._firstName = value;
            }
        }

        public string _lastName;
        public string LastName
        {
            get => this._lastName;
            set
            {
                this._lastName = value;
            }
        }

        public string _gender;
        public string Gender
        {
            get => this._gender;
            set
            {
                this._gender = value;
            }
        }

        public string _phone;
        public string Phone
        {
            get => this._phone;
            set
            {
                this._phone = value;
            }
        }

        public string _address;
        public string Address
        {
            get => this._address;
            set
            {
                this._address = value;
            }
        }

        public string _designation;
        public string Designation
        {
            get => this._designation;
            set
            {
                this._designation = value;
            }
        }

        public string _bloodGroup;
        public string BloodGroup
        {
            get => this._bloodGroup;
            set
            {
                this._bloodGroup = value;
            }
        }
    }
}
