using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoUnlimited
{
    public abstract class VidlyRequest
    {
        private string _userId;
        private string _userKey;
        private string _notify;

        public string UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }

        public string UserKey
        {
            get
            {
                return this._userKey;
            }
            set
            {
                this._userKey = value;
            }
        }

        public string Notify
        {
            get
            {
                return this._notify;
            }
            set
            {
                this._notify = value;
            }
        }
    }
}
