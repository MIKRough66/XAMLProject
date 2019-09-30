using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class StorageInformationCode
    {
        public int _entryId;
        public int EntryID
        {
            get => this._entryId;
            set
            {
                this._entryId = value;
            }
        }

        public int _donorID;
        public int DonorID
        {
            get => this._donorID;
            set
            {
                this._donorID = value;
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

        public int _quantity;
        public int Quantity
        {
            get => this._quantity;
            set
            {
                this._quantity = value;
            }
        }

        public string _storeDate;
        public string StoreDate
        {
            get => this._storeDate;
            set
            {
                this._storeDate = value;
            }
        }

        public string _expireDate;
        public string ExpireDate
        {
            get => this._expireDate;
            set
            {
                this._expireDate = value;
            }
        }

        public string _remarks;
        public string Remarks
        {
            get => this._remarks;
            set
            {
                this._remarks = value;
            }
        }
    }
}
