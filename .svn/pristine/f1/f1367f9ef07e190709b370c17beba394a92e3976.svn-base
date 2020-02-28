using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtil;
using Comm;
using System.Data;
using Model;

namespace Bll
{
    public class CustomerBll : ICustomer, IBatchIn
    {
        private DBHelper mDB;
        public CustomerBll()
        {
            mDB = DBHelperShare.getInstance();
        }

        public bool  AddCustomerOfCheckNone(string mobile)
        {
            string sql = string.Format("select * from customer where mobile='{0}'",mobile);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                sql = string.Format("insert into customer(BH,mobile,CreateDate) values(dbo.GetCustomerBH('101'),'{0}',getdate())",mobile);
                mDB.ExecuteNonQuery(sql);
                return true;
            }
            return false;

        }

        public void DelCustomer(string id)
        {
            string sql = string.Format("delete from customer where id={0}", id);
            mDB.ExecuteNonQuery(sql);

        }

        public bool IsCustomerExists(string mobile)
        {
            string sql = string.Format("select * from customer where mobile='{0}'", mobile);
            bool b = mDB.IsExists(sql);

            return b;
        }

        public bool IsPlateNumExists(string platenum)
        {
            string sql = string.Format("select * from carofcustomer where PlateNum='{0}'", platenum);
            bool b = mDB.IsExists(sql);

            return b;
        }

        public bool IsPlateVinExists(string platenum)
        {
            string sql = string.Format("select * from carofcustomer where Vin='{0}'", platenum);
            bool b = mDB.IsExists(sql);

            return b;
        }

        public void DelVinOfCar(string vin)
        {
            string sql = string.Format("delete from carofcustomer where Vin='{0}'",vin);
            mDB.ExecuteNonQuery(sql);


        }
        public void UpdateBaseCustomerInfo(Customer o)
        { 
            List<SqlElement> lst = new List<SqlElement>();
            if (!string.IsNullOrEmpty(o.CustName))
               lst.Add(new SqlElement("CustName", o.CustName, true));
           
               lst.Add(new SqlElement("address", o.Address, true));
            if (!string.IsNullOrEmpty(o.Sex))
                lst.Add(new SqlElement("Sex", o.Sex, true ));
            if (!string.IsNullOrEmpty(o.Telephone))
                lst.Add(new SqlElement("Telephone", o.Telephone, true));
          
                lst.Add(new SqlElement("IdentityCard", o.IdentityCard, true));
           
                lst.Add(new SqlElement("Job", o.Job, true));
            if (!string.IsNullOrEmpty(o.IsMarryed))
                lst.Add(new SqlElement("isMarryed", o.IsMarryed, true));
            
                lst.Add(new SqlElement("AgeScope", o.AgeScope, true));
 
                lst.Add(new SqlElement("Education", o.Education, true));
       
              lst.Add(new SqlElement("QQ", o.QQ, true));
   
               lst.Add(new SqlElement("Wx", o.Wx, true));
            if (!string.IsNullOrEmpty(o.Email))
               lst.Add(new SqlElement("Email", o.Email, true));
            if (!string.IsNullOrEmpty(o.CustType))
              lst.Add(new SqlElement("CustType", o.CustType, true));

            string sql1 = "";
            string organid = Comm.LoginInfoShare.getInstance().OrganId;
            string sql = string.Format("select * from customer where mobile='{0}'", o.Mobile);
            bool b = mDB.IsExists(sql);
            if (!b)
            {
                //sql = string.Format("insert into customer(BH,mobile,CreateDate) values(dbo.GetCustomerBH('101'),'{0}',getdate())", mobile);
                //mDB.ExecuteNonQuery(sql);
                //return true;
                lst.Add(new SqlElement("BH", "dbo.GetCustomerBH('" + organid + "')", false));
                lst.Add(new SqlElement("Mobile", o.Mobile, true));
                sql1 = CreateSqlUtil.CreateInsertSql(lst, "customer");
                mDB.ExecuteNonQuery(sql1);
            }
            else
            {
                sql1 = CreateSqlUtil.CreateUpdateSql(lst, "customer");
                sql1 = sql1 + string.Format(" where mobile ='{0}'", o.Mobile);  
                mDB.ExecuteNonQuery(sql1);
            }
              
      
     
        }


        public Customer GetCustomerByID(string id)
        {
            string sql = string.Format("select * from customer where ID='{0}'", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            Customer o = new Customer();
            int index = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tmp = dt.Rows[i]["CardNo"].ToString();
                if (tmp.Length > 2)
                {
                    index = i;
                    break;
                }
                else
                    index = 0;

            }

            if (dt != null && dt.Rows.Count > 0)
            {
                o.Mobile = dt.Rows[index]["mobile"].ToString();
                o.CustName = dt.Rows[index]["CustName"].ToString();
                o.Address = dt.Rows[index]["Address"].ToString();
                o.Sex = dt.Rows[index]["Sex"].ToString();
                o.Telephone = dt.Rows[index]["Telephone"].ToString();
                o.AgeScope = dt.Rows[index]["AgeScope"].ToString();
                o.Email = dt.Rows[index]["Email"].ToString();
                o.IdentityCard = dt.Rows[index]["IdentityCard"].ToString();
                o.IsMarryed = dt.Rows[index]["IsMarryed"].ToString();
                o.Job = dt.Rows[index]["Job"].ToString();
                o.Mobile = dt.Rows[index]["Mobile"].ToString();
                o.QQ = dt.Rows[index]["QQ"].ToString();
                o.Wx = dt.Rows[index]["Wx"].ToString();
                o.Education = dt.Rows[index]["Education"].ToString();
                if (dt.Rows[index]["VipTypeID"].ToString() != "")
                    o.VipTypeID = int.Parse(dt.Rows[index]["VipTypeID"].ToString());
                else
                    o.VipTypeID = 0;
                o.CardNo = dt.Rows[index]["CardNo"].ToString();

                return o;
            }
            else
                return null;


        }


        public Customer GetCustomerByMobile(string mobile)
        {
            string sql = string.Format("select * from customer where mobile = '{0}'", mobile);
            DataTable dt = mDB.ExecuteDataTable(sql);
            Customer o = new Customer();
            int index = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tmp = dt.Rows[i]["CardNo"].ToString();
                if (tmp.Length > 2)
                {
                    index = i;
                    break;
                }
                else
                    index = 0;

            }
              if (dt != null && dt.Rows.Count > 0)
                {
                    o.Mobile = dt.Rows[index]["mobile"].ToString();
                    o.CustName = dt.Rows[index]["CustName"].ToString();
                    o.Address = dt.Rows[index]["Address"].ToString();
                    o.Sex = dt.Rows[index]["Sex"].ToString();
                    o.Telephone = dt.Rows[index]["Telephone"].ToString();
                    o.AgeScope = dt.Rows[index]["AgeScope"].ToString();
                    o.Email = dt.Rows[index]["Email"].ToString();
                    o.IdentityCard = dt.Rows[index]["IdentityCard"].ToString();
                    o.IsMarryed = dt.Rows[index]["IsMarryed"].ToString();
                    o.Job = dt.Rows[index]["Job"].ToString();
                    o.Mobile = dt.Rows[index]["Mobile"].ToString();
                    o.QQ = dt.Rows[index]["QQ"].ToString();
                    o.Wx = dt.Rows[index]["Wx"].ToString();
                    o.Education = dt.Rows[index]["Education"].ToString();
                    if (dt.Rows[index]["VipTypeID"].ToString() != "")
                        o.VipTypeID = int.Parse(dt.Rows[index]["VipTypeID"].ToString());
                    else
                        o.VipTypeID = 0;
                    o.CardNo = dt.Rows[index]["CardNo"].ToString();
                    o.P2PMobile = dt.Rows[index]["P2PMobile"].ToString();
                    o.CustType = dt.Rows[index]["CustType"].ToString();
                    return o;
                }
                else
                    return null;

        }

        public Customer GetCustomerByCardNo(string cardNo)
        {
            string sql = string.Format("select * from customer where cardno='{0}'", cardNo);
            DataTable dt = mDB.ExecuteDataTable(sql);
            Customer o = new Customer();
            if (dt != null && dt.Rows.Count > 0)
            {
                o.Mobile = dt.Rows[0]["mobile"].ToString();
                o.CustName = dt.Rows[0]["CustName"].ToString();
                o.Address = dt.Rows[0]["Address"].ToString();
                o.Sex = dt.Rows[0]["Sex"].ToString() ;
                o.Telephone = dt.Rows[0]["Telephone"].ToString();
                o.AgeScope = dt.Rows[0]["AgeScope"].ToString();
                o.Email = dt.Rows[0]["Email"].ToString();
                o.IdentityCard = dt.Rows[0]["IdentityCard"].ToString();
                o.IsMarryed = dt.Rows[0]["IsMarryed"].ToString() ;
                o.Job = dt.Rows[0]["Job"].ToString();
                o.Mobile = dt.Rows[0]["Mobile"].ToString();
                o.QQ = dt.Rows[0]["QQ"].ToString();
                o.Wx = dt.Rows[0]["Wx"].ToString();
                o.Education = dt.Rows[0]["Education"].ToString();
                if (dt.Rows[0]["VipTypeID"].ToString() != "")
                    o.VipTypeID = int.Parse(dt.Rows[0]["VipTypeID"].ToString());
                else
                    o.VipTypeID = 0;
                o.CardNo = dt.Rows[0]["CardNo"].ToString();

                return o;
            }
            else
                return null;

        }

        public DataTable  GetCarByPalteNum(string platenum)
        {
            string sql = string.Format("select a.*,b.custname,b.P2PMobile,b.CustType,b.Address  from carofcustomer as a left join customer as b on a.mobile =b.mobile    where a.platenum='{0}'", platenum);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                //Car o = new Car();
                //o.PlateNum = dt.Rows[0]["PlateNum"].ToString();
                //o.Vin = dt.Rows[0]["Vin"].ToString();
                //o.CarBrand = dt.Rows[0]["CarBrand"].ToString();
                //o.CarModel = dt.Rows[0]["CarModel"].ToString();
                //o.CarSer = dt.Rows[0]["CarSer"].ToString();
                //o.CarColor = dt.Rows[0]["CarColor"].ToString();
                //o.Mobile = dt.Rows[0]["Mobile"].ToString();
                //o.InsuranceCompany = dt.Rows[0]["InsuranceCompany"].ToString();
                //if (dt.Rows[0]["InBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InBegin"].ToString()))
                //    o.InBegin = DateTime.Parse(dt.Rows[0]["InBegin"].ToString());
                //if (dt.Rows[0]["InEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InEnd"].ToString()))
                //    o.InEnd = DateTime.Parse(dt.Rows[0]["InEnd"].ToString());
                //return o;
                return dt;
            }
            else
                return null;


        }

        public Car GetCarByID(string id)
        {
            string sql = string.Format("select * from carofcustomer where id='{0}'", id);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Car o = new Car();
                o.PlateNum = dt.Rows[0]["PlateNum"].ToString();
                o.Vin = dt.Rows[0]["Vin"].ToString();
                o.CarBrand = dt.Rows[0]["CarBrand"].ToString();
                o.CarModel = dt.Rows[0]["CarModel"].ToString();
                o.CarSer = dt.Rows[0]["CarSer"].ToString();
                o.CarColor = dt.Rows[0]["CarColor"].ToString();
                o.Mobile = dt.Rows[0]["Mobile"].ToString();
                o.InsuranceCompany = dt.Rows[0]["InsuranceCompany"].ToString();
                if (dt.Rows[0]["InBegin"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InBegin"].ToString()))
                o.InBegin = DateTime.Parse(dt.Rows[0]["InBegin"].ToString());
                if (dt.Rows[0]["InEnd"] != null && !string.IsNullOrEmpty(dt.Rows[0]["InEnd"].ToString()))
                    o.InEnd = DateTime.Parse(dt.Rows[0]["InEnd"].ToString());
             
                return o;
            }
            else
                return null;



        }



        public bool IsCarByPlateAndMobile(string plate,string mobile)
        {
            string sql = string.Format("select * from carofcustomer where mobile='{0}' and platenum='{1}'",mobile,plate);
            if (mDB.IsExists(sql))
                return true;
            else
                return false;


        }

        public Car GetCarByPlate(string plate)
        {
            string sql = string.Format("select * from carofcustomer where platenum like '%{0}%'", plate);
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                Car o = new Car();
                o.PlateNum = dt.Rows[0]["PlateNum"].ToString();
                o.Vin = dt.Rows[0]["Vin"].ToString();
                o.CarBrand = dt.Rows[0]["CarBrand"].ToString();
                o.CarModel = dt.Rows[0]["CarModel"].ToString();
                o.CarSer = dt.Rows[0]["CarSer"].ToString();
                o.CarColor = dt.Rows[0]["CarColor"].ToString();
                o.Mobile = dt.Rows[0]["Mobile"].ToString();
             

                return o;
            }
            else
                return null;


        }

        public DataTable GetCustomersByQuery(List<SqlElement> lst,bool isVip,int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            //string condition = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
            //string sql = "select distinct BH,Mobile,CustName,VipTypeName,CardNo,Telephone,Address, case when sex=0 then '男' else '女' end as Sex,IdentityCard,Job, case when ismarryed=0 then '是' else '否' end as Ismarryed,Agescope,Education,QQ,Wx,Email,CreateDate  from  where " + condition;
            //DataTable dt = mDB.ExecuteDataTable(sql);
            //return dt;

            string IndexField = "ID";
            string AllFields = " BH,Mobile,ID,CustName,VipTypeName,CardNo,P2PMobile as P2P,Telephone,Address,  Sex,IdentityCard,Job, Ismarryed,Agescope,Education,QQ,Wx,Email,CreateDate";
            string OrderFields = "order by CreateDate desc";
            string Condition = "v_customer where ";

            if (lst != null && lst.Count != 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
            else
                Condition = Condition + "1=1";

            if (isVip)
                Condition = Condition + " and len(cardno)>0";
            DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, OrderFields, PageIndex, PageSize, out RecordCount, out PageCount);
            return dt;
        }


        //public DataTable GetCustomersOfCarByQuery(List<SqlElement> lst, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        //{
        //    //string condition = CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
        //    //string sql = "select distinct BH,Mobile,CustName,VipTypeName,CardNo,Telephone,Address, case when sex=0 then '男' else '女' end as Sex,IdentityCard,Job, case when ismarryed=0 then '是' else '否' end as Ismarryed,Agescope,Education,QQ,Wx,Email,CreateDate  from  where " + condition;
        //    //DataTable dt = mDB.ExecuteDataTable(sql);
        //    //return dt;

        //    string IndexField = "ID";
        //    string AllFields = " BH,Mobile,CustName,CardNo,Telephone,Address,  Sex,IdentityCard,Job, Ismarryed,Agescope,Education,QQ,Wx,Email,CreateDate";
        //    // string OrderFields="";
        //    string Condition = "v_customer1 where ";

        //    if (lst != null && lst.Count != 0)
        //        Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
        //    else
        //        Condition = Condition + "1=1";

        //    DataTable dt = mDB.ExecuteDataTableByPage(AllFields, Condition, IndexField, "", PageIndex, PageSize, out RecordCount, out PageCount);
        //    return dt;
        //}




        public DataTable GetCarsOfCustomerByQuery(List<SqlElement> lst)
        {
            string sql = "select top 10  * from carofcustomer where ";
            string Condition="";
            if (lst != null && lst.Count != 0)
                Condition = Condition + CreateSqlUtil.CreateQuerySqlOfCondition(lst, true);
            else
                Condition = Condition + "1!=1";

            sql = sql + Condition;

            return mDB.ExecuteDataTable(sql);

        }
        //public DataTable GetCustomersDefault()
        //{
        //    string sql = "select top 50 BH,Mobile,CustName,VipTypeName,CardNo,Telephone,Address, case when sex=0 then '男' else '女' end as Sex,IdentityCard,Job, case when ismarryed=0 then '是' else '否' end as Ismarryed,Agescope,Education,QQ,Wx,Email,CreateDate  from v_customer order by Id desc";
        //    DataTable dt = mDB.ExecuteDataTable(sql);
        //    return dt;

        //}
        public void AddCarOfCustomer(Car o)
        {
            string sql = "";
            List<SqlElement> lst = new List<SqlElement>();
            lst.Add(new SqlElement("mobile", o.Mobile, true));
            lst.Add(new SqlElement("PlateNum", o.PlateNum, true));
            lst.Add(new SqlElement("CarSer", o.CarSer, true));
            lst.Add(new SqlElement("CarBrand", o.CarBrand, true));
            lst.Add(new SqlElement("CarModel", o.CarModel, true));
            lst.Add(new SqlElement("CarColor", o.CarColor, true));
            lst.Add(new SqlElement("Vin", o.Vin, true));
            lst.Add(new SqlElement("InsuranceCompany", o.InsuranceCompany, true));
            lst.Add(new SqlElement("InBegin", o.InBegin.ToShortDateString(), true));
            lst.Add(new SqlElement("InEnd", o.InEnd.ToShortDateString(), true));
            lst.Add(new SqlElement("KeepBegin", o.KeepBegin.ToShortDateString(), true));
            lst.Add(new SqlElement("KeepEnd", o.KeepEnd.ToShortDateString(), true));
            lst.Add(new SqlElement("BuyHere", o.BuyHere, true));
            lst.Add(new SqlElement("EngineID", o.EngineID, true));
            sql = CreateSqlUtil.CreateInsertSql(lst,"carofcustomer");
            mDB.ExecuteNonQuery(sql);
        }

        public void UpdateCarOfCustomer(Car o)
        {
            string sql = "";
            List<SqlElement> lst = new List<SqlElement>();
        
            lst.Add(new SqlElement("PlateNum", o.PlateNum, true));
            lst.Add(new SqlElement("CarSer", o.CarSer, true));
            lst.Add(new SqlElement("CarBrand", o.CarBrand, true));
            lst.Add(new SqlElement("CarModel", o.CarModel, true));
            lst.Add(new SqlElement("CarColor", o.CarColor, true));
            lst.Add(new SqlElement("Vin", o.Vin, true));
            lst.Add(new SqlElement("InsuranceCompany", o.InsuranceCompany, true));
            lst.Add(new SqlElement("InBegin", o.InBegin.ToShortDateString(), true));
            lst.Add(new SqlElement("InEnd", o.InEnd.ToShortDateString(), true));
            lst.Add(new SqlElement("BuyHere", o.BuyHere, true));
            lst.Add(new SqlElement("KeepBegin", o.KeepBegin.ToShortDateString(), true));
            lst.Add(new SqlElement("KeepEnd", o.KeepEnd.ToShortDateString(), true));
            lst.Add(new SqlElement("EngineID", o.EngineID, true));
            sql = CreateSqlUtil.CreateUpdateSql(lst, "carofcustomer") + " where platenum='" +o.PlateNum +  "'";
            mDB.ExecuteNonQuery(sql);

        }
     
   

        public DataTable GetCarOfCustomer(string mobile)
        {
            string sql = string.Format("select * from carofcustomer where mobile='{0}'",mobile);
            return mDB.ExecuteDataTable(sql);
        }

        public DataTable GetVipTypes()
        {
            string sql = "select VipTypeID,viptypename from viptype";
            return mDB.ExecuteDataTable(sql);


        }


        public void DelCarOfCustomer(string id)
        {
            string sql = "delete from carofcustomer where id=" + id;
            mDB.ExecuteNonQuery(sql);
        }

        public void UpdateVipType(string typeid ,string cardno,string id)
        {
            string sql = string.Format("update customer set VipTypeID={0}, cardno='{1}' where id ='{2}'",typeid,cardno,id);
            mDB.ExecuteNonQuery(sql);
        }



        public void UpdateP2PMobile(string p2pmobile,string id)
        {
            string sql = string.Format("update customer set p2pmobile='{0}' where id ='{1}'", p2pmobile, id);
            mDB.ExecuteNonQuery(sql);

        }


        public string BatchInDB(DataTable dt, string append)
        {
            try
            {
                string sql = "";
                DelTempRecord();
                //foreach (DataRow dr in dt.Rows)
                //{
                //    Accessory obj = new Accessory();
                //    obj.AccessoryCode = dr[0].ToString();
                //    obj.AccessoryName = dr[1].ToString();
                //    obj.Brand = dr[2].ToString();
                //    obj.StorePlace = dr[3].ToString();
                //    obj.AccessoryType = dr[4].ToString();
                //    obj.IncreaseRate = float.Parse(dr[5].ToString());
                //    obj.ChangeCode = dr[6].ToString();
                //    obj.SalePrice = float.Parse(dr[7].ToString());
                //    obj.ApplicationModel = dr[7].ToString();
                //    obj.Unit = dr[8].ToString();
                //    AddAccessoryToTemp(obj);

                //}

                mDB.BatchInsert("tmp_customer", dt);
               
                //sql = FindRepeatRecord();
                //if (sql != "")
                //{
                //    DelTempRecord();
                //    return sql + "记录重复";

                //}
                sql = string.Format("insert into customer([BH],[Mobile],[CustName] ,[Address] ,[Sex]  ,[Telephone] ,[Status]  ,[IdentityCard] ,[Job],[IsMarryed] ,[AgeScope] ,[Education] ,[QQ] ,[Wx] ,[Email] ,[VipTypeID],[CardNo]) "
                    + " select dbo.GetCustomerBH('{0}'),[Mobile],[CustName] ,[Address] ,[Sex],[Telephone] ,0  ,[IdentityCard] ,[Job],[IsMarryed] ,[AgeScope] ,[Education] ,[QQ] ,[Wx] ,[Email] ,[VipTypeID],[CardNo] from tmp_customer",LoginInfoShare.getInstance().OrganId);
                mDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {

                DelTempRecord();

                return e.Message.ToString();
            }

            return "";
        }


        private void DelTempRecord()
        {

            mDB.ExecuteNonQuery("delete from tmp_customer");

        }

        public DataTable GetVipInfoOfLevel(string viplevel)
        {
            string sql = "select * from viptype where viptypename='" + viplevel + "'";
            return mDB.ExecuteDataTable(sql);

        }
        public DataTable GetVipInfoOfLevelByID(string viplevel)
        {
            string sql = "select * from viptype where viptypeid=" + viplevel ;
            return mDB.ExecuteDataTable(sql);

        }

        public DataTable GetAllVipTypes()
        {

            string sql = "select * from viptype";
            return mDB.ExecuteDataTable(sql);

        }

        public string GetVinOfCustomer(string mobile)
        {
            string sql = "select vin from carsale where mobile='" + mobile +"'";
            DataTable dt = mDB.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();

            }
            return "";
        }

        public void ModifyPlateNumOfCar(string id,string platenum)
        {
            string sql =string.Format( "update carofcustomer set platenum='{0}' where id={1}",platenum ,id);
            mDB.ExecuteNonQuery(sql);

        }
       
    }
}
