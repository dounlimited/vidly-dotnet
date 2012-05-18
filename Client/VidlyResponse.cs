using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoUnlimited
{
    public abstract class VidlyResponse
    {
        private string _message;
        private decimal _messageCode;
        private List<object> _success;
        private List<object> _errors;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                this._message = value;
            }
        }

        public decimal MessageCode
        {
            get
            {
                return this._messageCode;
            }
            set
            {
                this._messageCode = value;
            }
        }

        public List<object> Success
        {
            get
            {
                return this._success;
            }
            set
            {
                this._success = value;
            }
        }

        public List<object> Errors
        {
            get
            {
                return this._errors;
            }
            set
            {
                this._errors = value;
            }
        }
    }
}
