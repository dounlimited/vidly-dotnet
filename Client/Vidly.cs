using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoUnlimited
{
    /// <summary>
    /// Imeplements the methods available via the Vid.ly API http://api.vid.ly/
    /// </summary>
    public class Vidly
    {
        private string _userId;
        private string _userKey;
        private string _notifyUrl;

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

        public string NotifyUrl
        {
            get
            {
                return this._notifyUrl;
            }
            set
            {
                this._notifyUrl = value;
            }
        }

        public void AddMedia()
        {
            throw new NotImplementedException();
        }

        public void AddMediaLite()
        {
            throw new NotImplementedException();
        }

        public void UpdateMedia()
        {
            throw new NotImplementedException();
        }

        public void DeleteMedia()
        {
            throw new NotImplementedException();
        }

        public void GetStatus()
        {
            throw new NotImplementedException();
        }

        public void GetStatistics()
        {
            throw new NotImplementedException();
        }

        private void RequestAction()
        {
            throw new NotImplementedException();
        }
    }
}
