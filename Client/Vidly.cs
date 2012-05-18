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
            //POST requests to http://m.vid.ly/api/
            throw new NotImplementedException();
        }
    }
}
