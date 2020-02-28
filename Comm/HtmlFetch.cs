using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Comm
{
    public class HtmlFetch
    {
        // private bool isProxy = false;

        private int mIndex = 0;
        private int mproxyIndex = 0;
        private Random rand;
        public HtmlFetch()
        {
            mproxyIndex = getRandomIndex();
            rand = new Random();

        }


        private int getRandomIndex()
        {


            int RandKey = rand.Next(0, proxySet.Count() - 1);
            return RandKey;
        }

        public bool IsProxy
        {
            get;
            set;

        }
        private string[] proxySet = { "124.152.84.65:53281",
                                        "124.152.84.65:53281"
                                      
                                    };



        public string getCurrentProxy()
        {

            return proxySet[mproxyIndex];

        }
        //int seed = Guid.NewGuid().GetHashCode();
       // int waitTime = new Random(seed).Next(10, 100);

        public static string doQuickFetch(string url)
        {
            WebRequest req = WebRequest.Create(url);
            HttpWebResponse res = ((HttpWebResponse)req.GetResponse());

            Stream st = res.GetResponseStream();
            HttpStatusCode code = res.StatusCode;
            
            StreamReader rdr = new StreamReader(st);
            string result = rdr.ReadToEnd();

            return result;
        }

        public string doFetch(string url)
        {
            WebRequest req = WebRequest.Create(url);
            //req.Timeout = 10000;
            if (IsProxy)
            {


                //if (mIndex > 3)
                //{
                mproxyIndex = getRandomIndex();
                mIndex = 0;

                // }
                req.Proxy = new WebProxy("http://" + proxySet[mproxyIndex], true);
            }
            mIndex++;
            HttpWebResponse res = ((HttpWebResponse)req.GetResponse());

            Stream st = res.GetResponseStream();
            StreamReader rdr = new StreamReader(st);
            string result = rdr.ReadToEnd();

            return result;

        }


        public string doFetchOfGet(string url, string data)
        {
            if (data.Length > 1)
                url = url + "?" + data;


            WebRequest req = WebRequest.Create(url);
            req.Method = "GET";

            HttpWebResponse res = ((HttpWebResponse)req.GetResponse());

            Stream st = res.GetResponseStream();
            StreamReader rdr = new StreamReader(st);
            string result = rdr.ReadToEnd();
            return result;

        }
    }
}
