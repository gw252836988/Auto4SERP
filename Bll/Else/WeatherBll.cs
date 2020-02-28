using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll.cn.com.webxml.www;
namespace Bll.Else
{
    public delegate void getWeatheInfoHandler(string[] info);
    public class WeatherBll
    {
        private WeatherWebService mWS;
        public event getWeatheInfoHandler WeatheInfoHandler;
         
        public WeatherBll()
        {
            mWS = new WeatherWebService();
        }

        public void getWeatherbyCityName()
        {
            mWS.getWeatherbyCityNameAsync("南通");
            mWS.getWeatherbyCityNameCompleted+=new getWeatherbyCityNameCompletedEventHandler(this.WeatherByCityName);

        }
      

        private void WeatherByCityName(object sender, getWeatherbyCityNameCompletedEventArgs e)
        {
            string[] result = e.Result;
            if (WeatheInfoHandler != null)
                WeatheInfoHandler(result);
        }

    }
}
