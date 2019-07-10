using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_reddit.Models
{
    public class RedditSubject
    {
        private string m_name;
        private string m_url_reddit;
        private string m_url_optional;

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public string Url
        {
            get
            {
                return @"https://www.reddit.com" + m_url_reddit;
            }

            set
            {
                m_url_reddit = value;
            }
        }

        public string Url_optional
        {
            get
            {
                return m_url_optional;
            }

            set
            {
                m_url_optional = value;
            }
        }
    }
}