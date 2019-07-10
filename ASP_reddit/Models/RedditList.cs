using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_reddit.Models
{
    public class RedditList
    {
        private List<RedditSubject> listTitle;
        public List<RedditSubject> ListTitle
        {
            get
            {
                return listTitle;
            }           
        }
        public RedditList ()
        {
            listTitle = new List<RedditSubject>();
        }
        public void addTitle(RedditSubject r)
        {
            listTitle.Add(r);
        }
        public void addTitle(string name, string url,string url_optional)
        {
            listTitle.Add(new RedditSubject() { Name = name,Url = url,Url_optional= url_optional });
        }
    }
}