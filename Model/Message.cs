using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class Msg
    {


       public Msg(string sender,string content)
       {
           Sender = sender;
           Content = content;
           SendTime = DateTime.Now;

       }


       public string Sender
       {
           get;
           set;

       }

       public DateTime SendTime
       {
           get;
           set;

       }

       public string Content
       {
           get;
           set;
       }

    }
}
