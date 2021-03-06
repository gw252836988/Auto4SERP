﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Bll
{
   public interface ICarDoc
    {
       bool AddCarBrand(string brandname);
       bool UpdateCarBrand(string brandname,int id);
       bool DelCarBrand(int id);
       DataTable GetCarBrands();
       DataTable GetCarBrand(int id);

       bool AddCarSer(string carser,int carbrand_id);
       bool UpdateCarSer(string carser, int carbrand_id, int id);
       bool DelCarSer(int id);
       DataTable GetCarSers();
       DataTable GetCarSer(int id);
       DataTable GetCarSerByCarbrand(int carbrand_id);

       bool AddCarModel(string carmodel, int carser_id);
       bool UpdateCarModel(string carmodel, int carser_id, int id);
       bool DelCarModel(int id);
       DataTable GetCarModels();
       DataTable GetCarModel(int id);
       DataTable GetCarModelByCarser(int carser_id);


       bool AddCarDetail(CarDetail obj, int carmodel_id);
       bool UpdateCarDetail(CarDetail obj, int carmodel_id, int id);
       bool DelCarDetail(int id);
       DataTable GetCarDetails();
       DataTable GetCarDetails(int id);
       DataTable GetCarDetailByCarmodel(int carmodel_id);


       DataSet GetCarDocAll();
    }
}
