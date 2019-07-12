using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace ASP_reddit.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewReddit()
        {
            Models.RedditList redditTitle = new Models.RedditList();
            JObject json = JObject.Parse(new WebClient().DownloadString("https://www.reddit.com/r/programming/.json"));
            JToken selectData = json.SelectToken("$.data.children");

            foreach (JObject childrend in selectData)
            {
                redditTitle.addTitle(childrend.SelectToken("data.title").ToString(),
                                    childrend.SelectToken("data.permalink").ToString(),
                                    childrend.SelectToken("data.url").ToString()
                    );
            }
            return View(redditTitle);
        }
    }
}