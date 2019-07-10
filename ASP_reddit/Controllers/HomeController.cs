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
            Models.RedditList redditTitle= new Models.RedditList();            
            JObject json = JObject.Parse(new WebClient().DownloadString("https://www.reddit.com/r/programming/.json"));
            JToken selectData = json.SelectToken("$.data.children");

            foreach(JObject childrend  in selectData)
            {
                redditTitle.addTitle(childrend.SelectToken("data.title").ToString(),
                                    childrend.SelectToken("data.permalink").ToString(),    
                                    childrend.SelectToken("data.url").ToString()
                    );
            }
            return View(redditTitle);
        }
/*
JEnumerable<JToken> vv =  json.Children();
JToken data = vv.ElementAt(1);
vv = data.Children();

foreach(JToken aa in vv.Children())
{
    if(aa.Path == "data.children")
    {
        JEnumerable<JObject> vvvv = aa.Children().ElementAt(0).Children<JObject>();//


        foreach (JObject xx in vvvv)
        {

            JToken jt = xx.SelectToken("$.data[?(@.Name == 'title')]");
            JEnumerable<JObject> m = xx.Children().ElementAt(0).Children<JObject>();
            JObject title = m.Select(x => x.N);
            title
        }

        string s = vvvv.Values("title").ToString();
    }
}

*/

    }
}