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
            media.Add(new MediaSource("http://yahoo.com/video.wmv", "cdn.yahoo.com"));
            media.Add(new MediaSource("http://bing.com/funny.mov", "cdn.bing.com", "formatObject"));
            this._vidly.AddMedia(media);
            this._vidly.AddMediaLite(media);
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
    }
}
