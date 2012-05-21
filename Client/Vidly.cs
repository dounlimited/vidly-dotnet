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

        public VidlyResponse AddMedia(List<MediaSource> media)
        {
            AddMediaRequest request = new AddMediaRequest();
            request.Sources.AddRange(media);
            VidlyResponse response = this.RequestAction(request);
            return response;
        }

        public VidlyResponse AddMediaLite(List<MediaSource> media)
        {
            AddMediaRequest request = new AddMediaRequest();
            request.Action = "AddMediaLite";
            request.Sources.AddRange(media);
            VidlyResponse response = this.RequestAction(request);
            return response;
        }

        public VidlyResponse UpdateMedia(List<UpdateMediaSource> media)
        {
            UpdateMediaRequest request = new UpdateMediaRequest();
            request.Sources.AddRange(media);
            VidlyResponse response = this.RequestAction(request);
            return response;
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

        private VidlyResponse RequestAction(VidlyRequest request)
        {
            request.UserId = this.UserId;
            request.UserKey = this.UserKey;
            request.Notify = this.Notify;

            string xmlRequest = request.ToXml(request.GetType());
            Console.WriteLine(xmlRequest);

            //TODO POST requests to http://m.vid.ly/api/

            //TODO deserialize the response into a new VidlyResponse object.
            throw new NotImplementedException();
        }
    }
}
