using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoUnlimited;

namespace Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private Vidly _vidly;

        public UnitTest1()
        {
            this._vidly = new Vidly();
            this._vidly.UserId = "MyUserId";
            this._vidly.UserKey = "MyUserKey";
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_Valid_AddMedia()
        {
            List<MediaSource> media = new List<MediaSource>();
            media.Add(new MediaSource("http://google.com/logo.gif"));
            //media.Add(new MediaSource("http://yahoo.com/video.wmv", "cdn.yahoo.com"));
            //media.Add(new MediaSource("http://bing.com/funny.mov", "cdn.bing.com", "formatObject"));            
            this._vidly.AddMedia(media);
            Console.WriteLine("REQUEST >> " + this._vidly.DebugRequest);
            Console.WriteLine("RESPONSE << " + this._vidly.DebugResponse);

        }
        
        //TODO test error handling of AddMedia response

        [TestMethod]
        public void Test_Valid_AddMediaLite()
        {
            List<MediaSource> media = new List<MediaSource>();
            media.Add(new MediaSource("http://google.com/logo.gif"));
            media.Add(new MediaSource("http://yahoo.com/video.wmv", "cdn.yahoo.com"));
            media.Add(new MediaSource("http://bing.com/funny.mov", "cdn.bing.com", "formatObject"));
            this._vidly.AddMediaLite(media);
        }

        //TODO test error handling of AddMediaLite response

        [TestMethod]
        public void Test_Valid_UpdateMedia()
        {
            List<UpdateMediaSource> media = new List<UpdateMediaSource>();
            UpdateMediaSource video1 = new UpdateMediaSource();
            video1.MediaShortLink = "http://vid.ly/abc123";
            video1.SourceFile = "http://cdn.mysite.com/replacement.wmv";
            //video1.Protect = new MediaProtect();
            //video1.Protect.StartDate = DateTime.Now;
            //video1.Protect.ExpirationDate = DateTime.Now.AddMonths(2);
            //video1.Protect.IpAddress = "192.168.50.*";
            media.Add(video1);

            this._vidly.UpdateMedia(media);
        }

        //TODO test error handling of UpdateMedia response

        [TestMethod]
        public void Test_Valid_DeleteMedia()
        {
            DeleteMediaRequest request = new DeleteMediaRequest();
            request.MediaShortLinks.Add("http://vid.ly/abc123");
            request.MediaShortLinks.Add("http://vid.ly/def456");
            request.BatchID = 330;
            this._vidly.DeleteMedia(request);
        }

        //TODO test error handling of DeleteMedia response

        [TestMethod]
        public void Test_Valid_GetStatus()
        {
            StatusMediaRequest request = new StatusMediaRequest();
            request.MediaShortLinks.Add("http://vid.ly/abc123");
            request.MediaShortLinks.Add("http://vid.ly/def456");
            this._vidly.GetStatus(request);
        }

        //TODO test error handling of GetStatus response

        [Ignore]
        [TestMethod]
        public void Test_Can_Deserialize_Error_Response()
        {
            string xml = @"<?xml version=""1.0""?>
 <Response>
  <Message>Action failed: wrong query info.</Message>
  <MessageCode>1.1</MessageCode>
  <Errors>
   <Error>
    <ErrorCode>1.2</ErrorCode>
    <ErrorName>Wrong UserID given.</ErrorName>
    <Description>Your UserID is either empty or not present in the database.</Description>
    <Suggestion>Check your UserID.</Suggestion>
   </Error>
   <Error>
    <ErrorCode>1.3</ErrorCode>
    <ErrorName>Wrong UserKey given.</ErrorName>
    <Description>Your UserKey either is empty or does not fit given UserID.</Description>
    <Suggestion>Check that your UserKey is valid and fits your UserID.</Suggestion>
   </Error>
   <Error>
    <ErrorCode>1.6</ErrorCode>
    <ErrorName>Wrong action name.</ErrorName>
    <Description>The action name you provided is either empty or not valid.</Description>
    <Suggestion>Check the correctness of the given action name and make sure that such action exists.</Suggestion>
   </Error>
  </Errors>
 </Response>";

            VidlyResponse response = VidlyResponse.Create(xml);
            Assert.AreEqual("Action failed: wrong query info.", response.Message);
            Assert.AreEqual((decimal)1.1, response.MessageCode);
            Assert.AreEqual(3, response.Errors.Count);
        }
    }
}
