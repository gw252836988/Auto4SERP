using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class SaleAward
   {
       private decimal award;

       public decimal Award
       {
           get { return award; }
           set { award = value; }
       }
       private string carser;

       public string Carser
       {
           get { return carser; }
           set { carser = value; }
       }

       public string CarModel
       {
           get;
           set;

       }


   }
}
