using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace DoUnlimited.Vidly
{
    /// <summary>
    /// Imeplements the methods available via the Vid.ly API http://api.vid.ly/
    /// </summary>
    public class Vidly
    {
        private string _userId;
        private string _userKey;
        private string _notify;
        private string _debugRequest;
        private string _debugResponse;

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

        public string DebugRequest
        {
            get
            {
                return this._debugRequest;
            }
        }

        public string DebugResponse
        {
            get
            {
                return this._debugResponse;
            }
        }

        public VidlyResponse AddMedia(List<MediaSource> media)
        {
            AddMediaRequest request = new AddMediaRequest();
            request.Sources.AddRange(media);
            XmlDocument xml = this.RequestAction(request);
            VidlyResponse response = VidlyResponse.Create(xml);
            return response;
        }

        public VidlyResponse AddMediaLite(List<MediaSource> media)
        {
            AddMediaRequest request = new AddMediaRequest("AddMediaLite");
            request.Sources.AddRange(media);
            XmlDocument xml = this.RequestAction(request);
            VidlyResponse response = VidlyResponse.Create(xml);
            return response;
        }

        public VidlyResponse UpdateMedia(List<UpdateMediaSource> media)
        {
            UpdateMediaRequest request = new UpdateMediaRequest();
            request.Sources.AddRange(media);
            XmlDocument xml = this.RequestAction(request);
            VidlyResponse response = VidlyResponse.Create(xml);
            return response;
        }

        public DeleteMediaResponse DeleteMedia(DeleteMediaRequest request)
        {
            this.RequestAction(request);
            XmlDocument xml = this.RequestAction(request);
            DeleteMediaResponse response = DeleteMediaResponse.Create(xml);
            return response;
        }

        public StatusMediaResponse GetStatus(StatusMediaRequest request)
        {
            XmlDocument xml = this.RequestAction(request);
            StatusMediaResponse response = StatusMediaResponse.Create(xml);
            return response;
        }

        public void GetStatistics()
        {
            //TODO implement GetStatistics
            //TODO create a GetStatistics Request and Response class.
            throw new NotImplementedException();
        }

        private XmlDocument RequestAction(VidlyRequest request)
        {
            request.UserId = this.UserId;
            request.UserKey = this.UserKey;
            request.Notify = this.Notify;

            string xmlRequest = string.Format("xml={0}", request.ToXml(request.GetType()));
            this._debugRequest = xmlRequest;
            byte[] formData = Encoding.UTF8.GetBytes(xmlRequest);

            WebRequest wr = WebRequest.Create("http://m.vid.ly/api/");
            ((HttpWebRequest)wr).UserAgent = "Vidly.NET; http://github.com/dounlimited/vidly-dotnet";
            wr.Method = "POST";
            wr.ContentType = "application/x-www-form-urlencoded";
            wr.ContentLength = formData.Length;

            Stream dataStream = wr.GetRequestStream();
            dataStream.Write(formData, 0, formData.Length);
            dataStream.Close();

            WebResponse response = wr.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream);

            string xmlResponse = sr.ReadToEnd();
            this._debugResponse = xmlResponse;

            sr.Close();
            dataStream.Close();
            response.Close();

            XmlDocument r = new XmlDocument();
            r.LoadXml(xmlResponse);
            return r;
        }
    }
}
