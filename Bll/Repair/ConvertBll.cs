﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Comm;
using DBUtil;
using System.Data;
using Bll;

namespace Bll.Repair
{
    public class ConvertBll
    {
        private DBHelper mDesDB;
        private DBHelper mSourceDB;
        private DBHelper mPersonDB;

        public ConvertBll()
        {
            mDesDB = DBHelperShare.getInstance();
            mSourceDB = new DBHelper("168");
            mPersonDB = new DBHelper("000");
        }
        //导入配件库存
        public void  WareToDB()
        {
           string sql = "SELECT MAX(ItemCode) AS itemcode, MAX(InDZRQ) AS indzrq, SUM(Qty) AS qty,  MAX(InType) AS intype, MAX(ZD1) AS zd1, MAX(Price1) AS price1 FROM WareShop WHERE ZD1 in('配件库','辅料库') GROUP BY ItemCode HAVING (SUM(Qty) > 0) ";
        //    string sql = "SELECT MAX(ItemCode) AS itemcode, MAX(InDZRQ) AS indzrq, SUM(Qty) AS qty,  MAX(InType) AS intype, MAX(ZD1) AS zd1, MAX(Price1) AS price1 FROM WareShop WHERE providedept='上海和勤'  GROUP BY ItemCode HAVING (SUM(Qty) > 0) ";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);

            for (int i = 0; i < dt.Rows.Count;i++ )
            {


                sql = "INSERT INTO inwarerec ([AccessoryCode],[InDate],[DHFrom] ,[Amount] ,InReason,HouseName ,InPrice)";
                sql += string.Format("values ('{0}','{1}','old input',{2},'{3}','{4}',{5})", dt.Rows[i]["itemcode"].ToString(), dt.Rows[i]["InDzrq"].ToString(), dt.Rows[i]["qty"].ToString(), dt.Rows[i]["InType"].ToString(), dt.Rows[i]["zd1"].ToString(), dt.Rows[i]["price1"].ToString());

                mDesDB.ExecuteNonQuery(sql);

                sql = "INSERT INTO accware ([AccessoryCode],[InDate],[DHFrom] ,[Amount] ,Intype,HouseName ,InPrice)";
                sql += string.Format("values ('{0}','{1}','old input',{2},'{3}','{4}',{5})", dt.Rows[i]["itemcode"].ToString(), dt.Rows[i]["InDzrq"].ToString(), dt.Rows[i]["qty"].ToString(), dt.Rows[i]["InType"].ToString(), dt.Rows[i]["zd1"].ToString(), dt.Rows[i]["price1"].ToString());
                mDesDB.ExecuteNonQuery(sql);
         

            }
        }

        //导入配件资料
        public void AddAccInfo()
        {
            string sql = "select itemcode,spec2 from item  where len(spec2)>1  ";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sql = string.Format("update accessory  set SmallType='{0}' where accessorycode='{1}'", dt.Rows[i]["spec2"].ToString(), dt.Rows[i]["itemcode"].ToString());
                mDesDB.ExecuteNonQuery(sql);

            }

        }


        public void AccessoryToDB()
        {

            string sql = "select itemcode,itemname,cartype,spec1,interchangeno,Otprice0,enginetype,unit,posi,spec2 from item  where spec1 not like '装%' or itemcode not like 'C0A%' ";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string itemcode;
            string itemname;
            string cartype;
            string spec1;
            string interchangeno;
            string Otprice0;
            string enginetype;
            string unit;
            string posi;
            string spec2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemcode = dt.Rows[i]["itemcode"].ToString();
                itemname = dt.Rows[i]["itemname"].ToString();
                cartype = dt.Rows[i]["cartype"].ToString();
                spec1 = dt.Rows[i]["spec1"].ToString();
                spec2 = dt.Rows[i]["spec2"].ToString();
                interchangeno = dt.Rows[i]["interchangeno"].ToString();
                Otprice0 = dt.Rows[i]["Otprice0"].ToString();
                enginetype = dt.Rows[i]["enginetype"].ToString();
                unit = dt.Rows[i]["unit"].ToString();
                posi = dt.Rows[i]["posi"].ToString();
                if (string.IsNullOrEmpty(Otprice0)) Otprice0 = "0";

                sql = "select accessorycode from accessory where  accessorycode='" + itemcode + "'";
                if (mDesDB.IsExists(sql))
                    continue;
                sql = "insert into accessory(accessorycode,accessoryname,brand,accessorytype,changecode,saleprice,applicationmodel,unit,StorePlace,SmallType)";
                sql = sql + string.Format(" values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}')", itemcode, itemname, cartype, spec1, interchangeno, Otprice0, enginetype, unit,posi,spec2);

                mDesDB.ExecuteNonQuery(sql);//spec1 
            }

        }


        //导入维修项目
        public void RepItemToDB()
        {

            string sql = "select repdm,repname,lbcode,pym from repairitem";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string repdm;
            string repname;
            string lbcode;
            string pym;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                repdm = dt.Rows[i]["repdm"].ToString();
                repname = dt.Rows[i]["repname"].ToString();
                lbcode = dt.Rows[i]["lbcode"].ToString();
                pym = dt.Rows[i]["pym"].ToString();

                sql = "insert into repairitem(itemcode,itemname,itemtype,spellcode)";
                sql = sql + string.Format(" values('{0}','{1}','{2}','{3}')", repdm, repname, lbcode, pym);

                mDesDB.ExecuteNonQuery(sql);
            }


        }

        //导入维修项目类别
        public void RepItemTypeToDB()
        {
            string sql = "select lbcode,lbname from reptype";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);

            string lbcode;
            string lbname;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lbcode = dt.Rows[i]["lbcode"].ToString();
                lbname = dt.Rows[i]["lbname"].ToString();
                sql = "insert into repairtype(typecode,typename)";
                sql = sql + string.Format(" values('{0}','{1}')", lbcode, lbname);
                mDesDB.ExecuteNonQuery(sql);
            }

        }
        //导入维修项目价格
        public void RepItemPriceToDB()
        {
            string sql = "select RepDM,carlbdm,worktime1,worktime ,Otprice0 from repairprice";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string repdm;
            string carlbdm;
            string worktime1;
            string worktime;
            string Otprice0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                repdm = dt.Rows[i]["repdm"].ToString();
                carlbdm = dt.Rows[i]["carlbdm"].ToString();
                worktime1 = dt.Rows[i]["worktime1"].ToString();
                worktime = dt.Rows[i]["worktime"].ToString();
                Otprice0 = dt.Rows[i]["Otprice0"].ToString();

                sql = "insert into repitemprice(itemcode,empworkh,actworkh,workhprice,carlevel)";
                sql = sql + string.Format(" values('{0}',{1},{2},{3},{4})", repdm, worktime1,worktime,Otprice0,carlbdm);
                mDesDB.ExecuteNonQuery(sql);
            }

        }
           //导入车系
        public void CarSerToDB()
        {

            string sql = "select Max(carser) as carser from car_model group by carser";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string carser;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                carser = dt.Rows[i]["carser"].ToString();
                if (carser == "") continue;
                sql = "insert into carser(carser,carbrand)";
                sql += string.Format(" values('{0}',5)",carser);
                mDesDB.ExecuteNonQuery(sql);
            }

        }
        //导入车型
        public void CarModelToDB()
        {
            string sql = "select Max(carser) as carser, Max(carmodel) as carmodel from car_model group by carser,carmodel";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string carser;
            string carmodel;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                carser = dt.Rows[i]["carser"].ToString();
                carmodel = dt.Rows[i]["carmodel"].ToString();
                if (carser == "") continue;
                sql = "insert into carmodel(carmodel,carsername,carser)";
                sql += string.Format(" values('{0}','{1}',0)", carmodel,carser);
                mDesDB.ExecuteNonQuery(sql);
            }
            //UPDATE   carmodel  SET       CarSer =
            //            (SELECT     ID
            //                FROM          carser
            //                WHERE      (CarSer = carmodel.CarSerName))
        }

        //导入车辆资料
        public void CarDeitailToDB()
        {
            string sql = "select carmodel,carser,zbh,enginetype,ccolor,bsq,yearmonth,cns,inprice,SalesPrice from car_model";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);

            string zbh;
            string enginetype;
            string ccolor;
            string bsq;
            string yearmonth;
            string cns;
            string carmodel;
            string inprice;
            string carser;
            string SalesPrice;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                zbh = dt.Rows[i]["zbh"].ToString();
                enginetype = dt.Rows[i]["enginetype"].ToString();
                ccolor = dt.Rows[i]["ccolor"].ToString();
                bsq = dt.Rows[i]["bsq"].ToString();
                yearmonth = dt.Rows[i]["yearmonth"].ToString();
                if (string.IsNullOrEmpty(yearmonth))
                    yearmonth = "00";
                cns = dt.Rows[i]["cns"].ToString();
               
                inprice = dt.Rows[i]["inprice"].ToString();
                carmodel = dt.Rows[i]["carmodel"].ToString();//另行添加
                carser = dt.Rows[i]["carser"].ToString();// 另行添加
                SalesPrice = dt.Rows[i]["SalesPrice"].ToString();
                sql = "insert into cardetail(autonumber,color,displacement,transmission,innerstyle,carofyear,costprice,carmodelname,carsername,DirectPrice)";
                sql = sql + string.Format(" values('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}',{9})", zbh,ccolor,enginetype,bsq,cns,yearmonth,inprice,carmodel,carser,SalesPrice );
                mDesDB.ExecuteNonQuery(sql);
            }

            //UPDATE   cardetail  SET       carmodel =
            //            (SELECT     ID
            //                FROM          carmodel
            //                WHERE      (   cardetail.carmodelname = carmodel.carmodel and carmodel.carsername=cardetail.carsername))
        }

        public void CarStockToDB()
        {
            string sql = "select underpan,zbh,posi ,price,dzrq from car_inshopD as a  inner join  car_inshopH as b on a.dh=b.dh where a.kczt=1";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string underpan;
            string zbh;
            string posi;
            string price;
            string dzrq;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                underpan = dt.Rows[i]["underpan"].ToString();
                zbh = dt.Rows[i]["zbh"].ToString();
                posi = dt.Rows[i]["posi"].ToString();
                price = dt.Rows[i]["price"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();

                sql = "insert into  carstock(autonumber,vin,storeplace,inprice,status,carindate)";
                sql += string.Format(" values('{0}','{1}','{2}',{3},0,'{4}')", zbh,underpan ,posi,price,dzrq);
                mDesDB.ExecuteNonQuery(sql);
            }

        }

        public void OldRepToDB()
        {

            IFinance mIFinance = BllFactory.GetFinanceBll();

           string sql = "select   * from outshopH where dzrq>'2015-1-1'and dzrq<'2016-1-1' and clzt<5 and clzt!=-1  and outtype='维修' ";
            //string sql = "select * from outshopH where dh='202RE15090347'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string mobile;
            string outtype;
            string billtype;
            string saler;
            string plate;
            string dzrq;
            string clzt;
            string hjje;
            string custname;
            string underpan;
            string carmodel;
            string dh;
            string cardnum;
         
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                mobile = dt.Rows[i]["mobile"].ToString();
                outtype = dt.Rows[i]["outtype"].ToString();
                billtype = dt.Rows[i]["billtype"].ToString();
                saler = dt.Rows[i]["saler"].ToString();
                plate = dt.Rows[i]["plate"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();
                clzt = dt.Rows[i]["clzt"].ToString();
                hjje = dt.Rows[i]["Hjje"].ToString();
                custname = dt.Rows[i]["custname"].ToString();
                underpan = dt.Rows[i]["underpan"].ToString();
                carmodel = dt.Rows[i]["carmodel"].ToString();
                dh = dt.Rows[i]["dh"].ToString();
                cardnum = dt.Rows[i]["cardnum"].ToString();


              


                if (clzt == "1")
                {
                    clzt = "0";
                }
              
                else
                {
                    clzt = "1";
                }



                AddCustomer(mobile, custname, plate, carmodel, cardnum);

                sql = "insert into repair(mobile,reptype,repchildtype,receptman,platenum,recepttime,status,gamount,custname,vin,carmodel,dh)";
                sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}','{10}',{11})", mobile, outtype, billtype, saler, plate, dzrq, clzt, hjje, custname, underpan, carmodel, "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')");
                sql += " SELECT @@IDENTITY AS Id";
                DataTable Dtd = mDesDB.ExecuteDataTable(sql);
                string newdh;
                newdh = GetDH(Dtd.Rows[0][0].ToString());
                sql = "select * from outshopG where dh='" + dh + "'";
                DataTable dtItem;
                dtItem = mSourceDB.ExecuteDataTable(sql);

                string repdm;
                string worktime1;
                string worktime;
                string price;
                string pricename;//  价格类型
                string empname;// 操作人员
                string tiagio;//打折
                //  string priceid;
                string posi;
                
                decimal tmpdiscount;
                decimal finalprice;
                


            


                for (int j = 0; j < dtItem.Rows.Count; j++)
                {
                    repdm = dtItem.Rows[j]["repdm"].ToString();
                    if (string.IsNullOrEmpty(repdm)) continue;
                    worktime1 = dtItem.Rows[j]["worktime1"].ToString();
                    worktime = dtItem.Rows[j]["worktime"].ToString();
                    price = dtItem.Rows[j]["price"].ToString();
                    pricename = dtItem.Rows[j]["pricename"].ToString();
                    empname = dtItem.Rows[j]["empname"].ToString();
                    tiagio = dtItem.Rows[j]["tiagio"].ToString();
                    posi = dtItem.Rows[j]["posi"].ToString();
                    tmpdiscount = decimal.Parse(tiagio);
                    tmpdiscount = tmpdiscount / 100;

                    finalprice = decimal.Parse(price) * (1 - tmpdiscount);
                    sql = "insert into repair_i(itemcode,empworkH,actworkH,itemtotalprice,pricetype,workman,discount,dh,finalprice,typeofwork,xh)";
                    sql += string.Format(" values('{0}',{1},{2},{3},'{4}','{5}',{6},'{7}',{8},'{9}',{10})", repdm, worktime1, worktime, price, pricename, empname, tmpdiscount, newdh, finalprice, posi, "dbo.GetRepairIXH('" + newdh + "')");

                    mDesDB.ExecuteNonQuery(sql);
                }

                DataTable dtAcc;
                sql = "select * from outshopd where dh='" + dh + "' and zd6 in ('领料','部分退料')";
                dtAcc = mSourceDB.ExecuteDataTable(sql);
                string itemcode;
                string qty;
                string accprice;
                string zd8;
                string zd1;//housename
                string itemname;
                // string status = "1";
                string outrq;
                string price1;//成本价
                string accpricename;//价格类型
                string maagio;//打折

                string zd6;
                //string xth;
                for (int k = 0; k < dtAcc.Rows.Count; k++)
                {
                    itemcode = dtAcc.Rows[k]["itemcode"].ToString();
                    qty = dtAcc.Rows[k]["qty"].ToString();
                    accprice = dtAcc.Rows[k]["price"].ToString();
                    zd8 = dtAcc.Rows[k]["zd8"].ToString();
                    zd1 = dtAcc.Rows[k]["zd1"].ToString();
                    itemname = dtAcc.Rows[k]["repname"].ToString();
                    outrq = dtAcc.Rows[k]["outrq"].ToString();
                    price1 = dtAcc.Rows[k]["price1"].ToString();
                    accpricename = dtAcc.Rows[k]["pricename"].ToString();
                    maagio = dtAcc.Rows[k]["maagio"].ToString();
                    tmpdiscount = decimal.Parse(maagio);
                    tmpdiscount = tmpdiscount / 100;
                    finalprice = decimal.Parse(accprice) * (1 - tmpdiscount);


                    zd6 = dtAcc.Rows[k]["zd6"].ToString();

                    if (zd6 == "部分退料")
                    {

                        qty = GetQtyOfAcc(itemcode, dh);

                    }
                    sql = "insert repair_a(AccessoryCode,amount,saleprice,takeman,housename,itemname,takedate,inprice,pricetype,discount,finalprice,dh,xh,acctype,status)";
                    sql += string.Format(" values('{0}',{1},{2},'{3}','{4}','{5}','{6}',{7},'{8}',{9},{10},'{11}',{12},1,0)", itemcode, qty, accprice, zd8, zd1, itemname, outrq, price1, accpricename, maagio, finalprice, newdh, "dbo.GetRepairAXH('" + newdh + "')");
                    mDesDB.ExecuteNonQuery(sql);

                }
            }

        }


        public void OldZHRepToDB()
        {

            IFinance mIFinance = BllFactory.GetFinanceBll();

            //string sql = "select  * from outshopH where   dzrq>'2016-6-13' and  clzt in(4,5)  and billtype = '销售装潢'";
            string sql = "select * from outshopH where dh='159ZH16050020'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string mobile;
            string outtype;
            string billtype;
            string saler;
            string plate;
            string dzrq;
            string clzt;
            string hjje;
            string custname;
            string underpan;
            string carmodel;
            string dh;
            string cardnum;
            string jsrq;
            string BalJE1;
            string BalJE2;
            string BalJE5;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                mobile = dt.Rows[i]["mobile"].ToString();
                outtype = dt.Rows[i]["outtype"].ToString();
                billtype = dt.Rows[i]["billtype"].ToString();
                saler = dt.Rows[i]["saler"].ToString();
                plate = dt.Rows[i]["plate"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();
                clzt = dt.Rows[i]["clzt"].ToString();
                hjje = dt.Rows[i]["Hjje"].ToString();
                custname = dt.Rows[i]["custname"].ToString();
                underpan = dt.Rows[i]["underpan"].ToString();
                carmodel = dt.Rows[i]["carmodel"].ToString();
                dh = dt.Rows[i]["dh"].ToString();
                cardnum = dt.Rows[i]["cardnum"].ToString();


                //已结算
                jsrq = dt.Rows[i]["todate"].ToString();
                BalJE1 = dt.Rows[i]["BalJE1"].ToString();
                BalJE2 = dt.Rows[i]["BalJE2"].ToString();
                BalJE5 = dt.Rows[i]["BalJE5"].ToString();


                if (clzt == "1")
                {
                    clzt = "0";
                }
                else if (clzt == "5")
                    clzt = "3";
                else
                {
                    clzt = "1";
                }



                AddCustomer(mobile, custname, plate, carmodel, cardnum);

                sql = "insert into repair(mobile,reptype,repchildtype,receptman,platenum,recepttime,status,gamount,custname,vin,carmodel,dh,accounttime)";
                sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}','{10}',{11},'{12}')", mobile, outtype, billtype, saler, plate, dzrq, clzt, hjje, custname, underpan, carmodel, "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", jsrq);
                sql += " SELECT @@IDENTITY AS Id";
                DataTable Dtd=mDesDB.ExecuteDataTable(sql);
                //continue;
                //sql = "select * from outshopG where dh='" + dh + "'";
                //DataTable dtItem;
                //dtItem = mSourceDB.ExecuteDataTable(sql);

                //string repdm;
                //string worktime1;
                //string worktime;
                //string price;
                //string pricename;//  价格类型
                //string empname;// 操作人员
                //string tiagio;//打折
                ////  string priceid;
                //string posi;
                string newdh;
                //decimal tmpdiscount;
                decimal finalprice;
                newdh = GetDH(Dtd.Rows[0][0].ToString());


                //if (clzt == "3")
                //{
                //    Account obj = new Account();
                //    obj.Mobile = mobile;
                //    obj.Amount = double.Parse(hjje);
                //    obj.RecAmount = obj.Amount;
                //    obj.DHFrom = "old input";
                //    obj.Describes = "售后";
                //    obj.CustName = custname;
                //    obj.ReceiveMan = Comm.LoginInfoShare.getInstance().UserName;
                //    obj.AcceptDate = jsrq;
                //    obj.Cash = double.Parse(BalJE1);
                //    obj.Bank = double.Parse(BalJE2);
                //    obj.Vip = double.Parse(BalJE5);
                //    mIFinance.AddAccountOfRec(obj);

                //}


              

                DataTable dtAcc;
                sql = "select * from outshopd where dh='" + dh + "' and zd6 in ('需求')";
                dtAcc = mSourceDB.ExecuteDataTable(sql);
                string itemcode;
                string qty;
                string accprice;
                string zd8;
                string zd1;//housename
                string itemname;
                // string status = "1";
                string outrq;
                string price1;//成本价
                string accpricename;//价格类型
                //string maagio;//打折

                string zd6;
                //string xth;
                for (int k = 0; k < dtAcc.Rows.Count; k++)
                {
                    itemcode = dtAcc.Rows[k]["itemcode"].ToString();
                    qty = dtAcc.Rows[k]["qty"].ToString();
                    accprice = dtAcc.Rows[k]["price"].ToString();
                    zd8 = dtAcc.Rows[k]["zd8"].ToString();
                    zd1 = dtAcc.Rows[k]["zd1"].ToString();
                    itemname = dtAcc.Rows[k]["repname"].ToString();
                    outrq = dtAcc.Rows[k]["outrq"].ToString();
                    price1 = dtAcc.Rows[k]["price1"].ToString();
                    accpricename = dtAcc.Rows[k]["pricename"].ToString();
                    //maagio = dtAcc.Rows[k]["maagio"].ToString();
                    //tmpdiscount = decimal.Parse(maagio);
                    //tmpdiscount = tmpdiscount / 100;
                    finalprice = 0;


                    zd6 = dtAcc.Rows[k]["zd6"].ToString();

                    //if (zd6 == "部分退料")
                    //{

                    //    qty = GetQtyOfAcc(itemcode, dh);

                    //}
                    sql = "insert repair_a(AccessoryCode,amount,saleprice,takeman,housename,itemname,takedate,inprice,pricetype,discount,finalprice,dh,xh,acctype,status)";
                    sql += string.Format(" values('{0}',{1},{2},'{3}','{4}','{5}','{6}',{7},'{8}',{9},{10},'{11}',{12},0,0)", itemcode, qty, accprice, zd8, zd1, itemname, outrq, price1, accpricename, "0", finalprice, newdh, "dbo.GetRepairAXH('" + newdh + "')");
                    mDesDB.ExecuteNonQuery(sql);

                }
            }

        }
        //导入维修单据（已结算）
        public void AddRepInfo()
        {
            string sql = "select Mileage,dzrq,plate from outshoph where dzrq>'2016-1-1' and dzrq<'2017-1-1'  and clzt=5  and outtype = '维修'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sql = string.Format("update repair set Inmil='{0}' where recepttime='{1}' and platenum='{2}'", dt.Rows[i]["Mileage"].ToString(), dt.Rows[i]["dzrq"].ToString(), dt.Rows[i]["plate"].ToString());
                mDesDB.ExecuteNonQuery(sql);


            }

        }

        public void OldJSRepToDB()
        {

            IFinance mIFinance = BllFactory.GetFinanceBll();

            string sql = "select  * from outshopH where  todate>'2016-8-1' and  clzt=5  and outtype = '维修'";
           // string sql = "select * from outshopH where dh='152RE14120235'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string mobile;
            string outtype;
            string billtype;
            string saler;
            string plate;
            string dzrq;
            string clzt ;
            string hjje;
            string custname;
            string underpan ;
            string carmodel;
            string dh;
            string cardnum;
            string jsrq;
            string BalJE1;
            string BalJE2;
            string BalJE5;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              

                mobile = dt.Rows[i]["mobile"].ToString();
                outtype = dt.Rows[i]["outtype"].ToString();
                billtype = dt.Rows[i]["billtype"].ToString();
                saler = dt.Rows[i]["saler"].ToString();
                plate = dt.Rows[i]["plate"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();
                clzt = dt.Rows[i]["clzt"].ToString();
                hjje = dt.Rows[i]["Hjje"].ToString();
                custname=dt.Rows[i]["custname"].ToString();
                underpan = dt.Rows[i]["underpan"].ToString();
                carmodel = dt.Rows[i]["carmodel"].ToString();
                dh = dt.Rows[i]["dh"].ToString();
                cardnum = dt.Rows[i]["cardnum"].ToString();
                

                //已结算
                jsrq = dt.Rows[i]["todate"].ToString();
                BalJE1 = dt.Rows[i]["BalJE1"].ToString();
                BalJE2 = dt.Rows[i]["BalJE2"].ToString();
                BalJE5 = dt.Rows[i]["BalJE5"].ToString();


                if(clzt=="1")
                {
                    clzt = "0";
                }
                else if (clzt == "5")
                    clzt = "3";
                else 
                {
                    clzt = "1";
                }
           
               
               
                AddCustomer(mobile, custname, plate, carmodel,cardnum);
                
                sql = "insert into repair(mobile,reptype,repchildtype,receptman,platenum,recepttime,status,gamount,custname,vin,carmodel,dh,accounttime)";
                sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}','{10}',{11},'{12}')", mobile, outtype, billtype, saler, plate, dzrq, clzt, hjje, custname, underpan, carmodel, "dbo.GetRepairDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')",jsrq);
                sql += " SELECT @@IDENTITY AS Id";
                DataTable Dtd = mDesDB.ExecuteDataTable(sql);
                string newdh;
                newdh = GetDH(Dtd.Rows[0][0].ToString());


                sql = "select * from outshopG where dh='" + dh + "'";
                DataTable dtItem;
                dtItem = mSourceDB.ExecuteDataTable(sql);

                string repdm;
                string worktime1;
                string worktime;
                string price;
                string pricename;//  价格类型
                string empname;// 操作人员
                string tiagio;//打折
              //  string priceid;
                string posi;
               // string newdh;
                decimal tmpdiscount;
                decimal finalprice;
               // newdh = GetDH();


                //if (clzt == "3")
                //{
                //    Account obj = new Account();
                //    obj.Mobile = mobile;
                //    obj.Amount = double.Parse(hjje);
                //    obj.RecAmount = obj.Amount;
                //    obj.DHFrom = "old input";
                //    obj.Describes = "售后";
                //    obj.CustName = custname;
                //    obj.ReceiveMan = Comm.LoginInfoShare.getInstance().UserName;
                //    obj.AcceptDate = jsrq;
                //    obj.Cash = double.Parse(BalJE1);
                //    obj.Bank = double.Parse(BalJE2);
                //    obj.Vip = double.Parse(BalJE5);
                //    mIFinance.AddAccountOfRec(obj);

                //}

               
                for (int j = 0; j < dtItem.Rows.Count;j++)
                {
                    repdm = dtItem.Rows[j]["repdm"].ToString();
                    if (string.IsNullOrEmpty(repdm)) continue;
                    worktime1 = dtItem.Rows[j]["worktime1"].ToString();
                    worktime = dtItem.Rows[j]["worktime"].ToString();
                    price = dtItem.Rows[j]["price"].ToString();
                    pricename = dtItem.Rows[j]["pricename"].ToString();
                    empname = dtItem.Rows[j]["empname"].ToString();
                    tiagio = dtItem.Rows[j]["tiagio"].ToString();
                    posi = dtItem.Rows[j]["posi"].ToString();
                    tmpdiscount = decimal.Parse(tiagio);
                    tmpdiscount = tmpdiscount / 100;
                   
                    finalprice=decimal.Parse(price) * (1-tmpdiscount);
                    sql = "insert into repair_i(itemcode,empworkH,actworkH,itemtotalprice,pricetype,workman,discount,dh,finalprice,typeofwork,xh)";
                    sql += string.Format(" values('{0}',{1},{2},{3},'{4}','{5}',{6},'{7}',{8},'{9}',{10})", repdm, worktime1, worktime, price, pricename, empname, tmpdiscount, newdh, finalprice, posi, "dbo.GetRepairIXH('" +newdh+ "')");

                    mDesDB.ExecuteNonQuery(sql);
                }

                DataTable dtAcc;
                sql = "select * from outshopd where dh='" + dh+ "' and zd6 in ('领料','部分退料')";
                dtAcc = mSourceDB.ExecuteDataTable(sql);
                string itemcode;
                string qty;
                string accprice;
                string zd8;
                string zd1;//housename
                string itemname;
               // string status = "1";
                string outrq;
                string price1;//成本价
                string accpricename;//价格类型
                string maagio;//打折

                string zd6;
                //string xth;
                for (int k = 0; k < dtAcc.Rows.Count; k++)
                {
                    itemcode = dtAcc.Rows[k]["itemcode"].ToString();
                    qty = dtAcc.Rows[k]["qty"].ToString();
                    accprice = dtAcc.Rows[k]["price"].ToString();
                    zd8 = dtAcc.Rows[k]["zd8"].ToString();
                    zd1 = dtAcc.Rows[k]["zd1"].ToString();
                    itemname = dtAcc.Rows[k]["repname"].ToString();
                    outrq = dtAcc.Rows[k]["outrq"].ToString();
                    price1 = dtAcc.Rows[k]["price1"].ToString();
                    accpricename = dtAcc.Rows[k]["pricename"].ToString();
                    maagio = dtAcc.Rows[k]["maagio"].ToString();
                    tmpdiscount = decimal.Parse(maagio);
                    tmpdiscount = tmpdiscount / 100;
                    finalprice=decimal.Parse(accprice) * (1-tmpdiscount);


                    zd6 = dtAcc.Rows[k]["zd6"].ToString();

                    if (zd6 == "部分退料")
                    {

                        qty = GetQtyOfAcc(itemcode,dh);

                    }
                    sql = "insert repair_a(AccessoryCode,amount,saleprice,takeman,housename,itemname,takedate,inprice,pricetype,discount,finalprice,dh,xh,acctype,status)";
                    sql += string.Format(" values('{0}',{1},{2},'{3}','{4}','{5}','{6}',{7},'{8}',{9},{10},'{11}',{12},1,0)", itemcode, qty, accprice, zd8, zd1, "", outrq, price1, accpricename, maagio, finalprice, newdh, "dbo.GetRepairAXH('" + newdh+ "')");
                    mDesDB.ExecuteNonQuery(sql);
                
                }
            }

        }

        public void CarOrderToDB()
        {
            IFinance mIFinance = BllFactory.GetFinanceBll();
        
            string sql = "select DH,Dzrq,CustName,Mobile,Saler,orderje,ZBH from car_OutshopH where clzt=1 and dzrq>='2016-1-1'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string orderje;//OrderReceive      
            string mobile;
            string saler;//saleman
            string dzrq;//CreateDate;
           string custname;
            string zbh;
          //  string dh;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

             
                mobile = dt.Rows[i]["mobile"].ToString();
                saler = dt.Rows[i]["saler"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();            
                zbh = dt.Rows[i]["zbh"].ToString();
                custname = dt.Rows[i]["custname"].ToString();
                orderje = dt.Rows[i]["orderje"].ToString();

                AddCustomer(mobile, custname, "", "", "");

                sql = "insert into  CarOrder(mobile,operatorman,orderdate,autonumber,amountsum,amountreceive,dh)";
              //  string tmp = "dbo.GetCarOrderDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')";

             //   sql = sql + string.Format(" values('{0}','{1}','{2}','{3}',{4},{5},{6})", mobile, saler, "2132", zbh, orderje, orderje, tmp);
                sql = sql + string.Format(" values('{0}','{1}','{2}','{3}',{4},{5},{6})", mobile, saler, dzrq , zbh, orderje, orderje, "dbo.GetCarOrderDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')");
           
            //    sql += string.Format(" values({0},{1},{2},{3},{4},{5},'{6}','{7}','{8}','{9}','{10}',{11},3,'{12}')", price, price, orderje, YSKJE, hjje, hjje, mobile, saler, dzrq, underpan, zbh, "dbo.GetCarSaleDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", jsrq);

                mDesDB.ExecuteNonQuery(sql);



            }



        }


        public void CarSaleToDB()
        {
            IFinance mIFinance = BllFactory.GetFinanceBll();
            string sql = "select DH,Dzrq,CustName,Mobile,Saler,Price,Hjje,orderje,DKJE,underpan,ZBH,jsrq from car_OutshopH where clzt>=3 and jsrq>='2016-1-1' and jsrq<'2016-6-1'";
           // string sql = "select DH,Dzrq,CustName,Mobile,Saler,Price,Hjje,orderje,DKJE,underpan,ZBH,jsrq from car_OutshopH where dh='2022016020002'";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);

            string price;//TotalPrice,CarPrice
            string orderje;//OrderReceive
            string YSKJE;//LoanAmount
            string hjje;//ReceivableAmount,AmountReceive
            string mobile;
            string saler;//saleman
            string dzrq;//CreateDate;
            string underpan;
         
            string jsrq;
            string custname;
            string zbh;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                price = dt.Rows[i]["price"].ToString();
                orderje = dt.Rows[i]["orderje"].ToString();
                YSKJE = dt.Rows[i]["DKJE"].ToString();
                hjje = dt.Rows[i]["hjje"].ToString();
                mobile = dt.Rows[i]["mobile"].ToString();
                saler = dt.Rows[i]["saler"].ToString();
                dzrq = dt.Rows[i]["dzrq"].ToString();
                underpan = dt.Rows[i]["underpan"].ToString();
                zbh = dt.Rows[i]["zbh"].ToString();
                jsrq = dt.Rows[i]["jsrq"].ToString();
                custname = dt.Rows[i]["custname"].ToString();
            
                AddCustomer(mobile ,custname ,"","","");
                sql = "insert into  CarSale(TotalPrice,CarPrice,orderreceive,LoanAmount,ReceivableAmount,AmountReceive,mobile,saleman,CreateDate,Vin,AutoNumber,dh,status,accountdate)";
                sql += string.Format(" values({0},{1},{2},{3},{4},{5},'{6}','{7}','{8}','{9}','{10}',{11},3,'{12}')", price, price, orderje, YSKJE, hjje, hjje, mobile, saler, dzrq, underpan, zbh, "dbo.GetCarSaleDH('" + Comm.LoginInfoShare.getInstance().OrganId + "')",jsrq);
                        
                mDesDB.ExecuteNonQuery(sql);


                Account obj = new Account();
                obj.Mobile = mobile;
                obj.Amount = double.Parse(hjje);
                obj.RecAmount = obj.Amount;
                obj.DHFrom = "old input";
                obj.Describes = "销售收款";
                obj.CustName = custname;
                obj.ReceiveMan = Comm.LoginInfoShare.getInstance().UserName;
                obj.AcceptDate =jsrq;
                obj.Cash = double.Parse(hjje);

                mIFinance.AddAccountOfRec(obj);
                
            }



        }
        public void AddCustomerInfo()
        {

            string sql = "SELECT   CustType.CustType, Customer.mobile FROM       Customer INNER JOIN   CustType ON Customer.CustType = CustType.CustType   where    CustType.CustTypeName like '合同%' ";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sql = string.Format("update customer set viptypeid={0} where mobile='{1}'", dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
                mDesDB.ExecuteNonQuery(sql);


            }



        }
        //导入客户资料
        public void CustomerToDB()
        {
            string sql = "SELECT     MAX(CustCode) AS CustCode, MAX(CustName) AS CustName, Mobile, MAX(Sex) AS Sex, MAX(Address) AS Address, MAX(Phone) AS Phone, MAX(CardID) AS CardID, MAX(CardNum) AS CardNum, MAX(QT15) AS QT15 FROM  Customer WHERE (LEN(Mobile) = 11) AND (Mobile LIKE '1%') AND (Mobile NOT LIKE '12%') GROUP BY Mobile ";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);


            string custname;
            string mobile;
            string sex;
            string address;
            string cardid;
            string cardnum;
            string custcode;

            string QT15;
            //车辆资料

            string plate;
            string cartype;
            string carser;
            string carmodel;
            string ccolor;
            string underpan;

            for (int i = (dt.Rows.Count-1); i > 0; i--)
            {

               mobile = dt.Rows[i]["mobile"].ToString();
               sql = string.Format("select * from customer where mobile='{0}'", mobile);
               bool b = mDesDB.IsExists(sql);
               if (b)
               {
                   continue;
               }

                custname = dt.Rows[i]["custname"].ToString();
               
                sex = dt.Rows[i]["sex"].ToString();
                address = dt.Rows[i]["address"].ToString();
                cardid = dt.Rows[i]["cardid"].ToString();
                cardnum = dt.Rows[i]["cardnum"].ToString();
                custcode = dt.Rows[i]["custcode"].ToString();
                QT15 = dt.Rows[i]["QT15"].ToString();
                sql = "insert into customer(custname,mobile,sex,address,identitycard,cardno,BH,p2pmobile)";
                sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}')", custname, mobile, sex, address, cardid, cardnum, "dbo.GetCustomerBH('" + Comm.LoginInfoShare.getInstance().OrganId + "')", QT15);
                try
                {
                    mDesDB.ExecuteNonQuery(sql);
                }
                catch (Exception ex)
                {
                    continue;

                }

                sql = "select plate,cartype,carser,carmodel,ccolor,underpan from  carfile  where custcode='" +custcode  + "'";
                DataTable dtCarFile;
                dtCarFile = mSourceDB.ExecuteDataTable(sql);
                for (int j = 0; j < dtCarFile.Rows.Count; j++)
                {
                    plate = dtCarFile.Rows[j]["plate"].ToString();
                    cartype = dtCarFile.Rows[j]["cartype"].ToString();
                    carser = dtCarFile.Rows[j]["carser"].ToString();
                    carmodel = dtCarFile.Rows[j]["carmodel"].ToString();
                    ccolor = dtCarFile.Rows[j]["ccolor"].ToString();
                    underpan = dtCarFile.Rows[j]["underpan"].ToString();
                    sql = "insert into carofcustomer(mobile,platenum,vin,carbrand,carser,carmodel,carcolor)";
                    sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", mobile, plate, underpan, cartype, carser, carmodel, ccolor);
                    try
                    {
                        mDesDB.ExecuteNonQuery(sql);
                    }
                    catch(Exception ex)
                    {
                        continue;

                    }
                }
                
            }
        }



        public void AddCarInfo()
        {

            string sql = "select plate,insuname from carfile";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string palte;
            string insuname;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                palte = dt.Rows[i][0].ToString();
                insuname = dt.Rows[i][1].ToString();
                sql = string.Format("update carofcustomer set InsuranceCompany='{0}' where platenum='{1}'",insuname,palte);
                mDesDB.ExecuteNonQuery(sql);
            }

        }


        //导入人员信息
        public void StaffToDB()
        {
            string sql = "select * from employee where QuitDate Is Null and qx14=0";
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string empcode;
            string empname;
            string sex;
            string birthday;
            string zd3;//籍贯
            string zd4;//民族
            string zd5;//婚否
            string zd6;//学历
            string zd7;//毕业院校
            string zd8;//专业
            string IDCard;//身份证
            string HAddress;//户口地址
            string CAddress;//现居地址
            string phone;
            string mobil;
            string joinDate;//入职日期
            string cbegin;//合同开始日期
            string cend;//合同结束日期
            string waredm;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                empcode = dt.Rows[i]["empcode"].ToString();
                empname = dt.Rows[i]["empname"].ToString();
                sex = dt.Rows[i]["sex"].ToString();
                birthday = dt.Rows[i]["birthday"].ToString();
                zd3 = dt.Rows[i]["zd3"].ToString();
                zd4 = dt.Rows[i]["zd4"].ToString();
                zd5 = dt.Rows[i]["zd5"].ToString();
                zd6 = dt.Rows[i]["zd6"].ToString();
                zd7 = dt.Rows[i]["zd7"].ToString();
                zd8 = dt.Rows[i]["zd8"].ToString();
                IDCard = dt.Rows[i]["IDCard"].ToString();

                CAddress = dt.Rows[i]["CAddress"].ToString();
                phone = dt.Rows[i]["phone"].ToString();
                mobil = dt.Rows[i]["mobil"].ToString();
                HAddress = dt.Rows[i]["HAddress"].ToString();
                joinDate = dt.Rows[i]["joinDate"].ToString();
                cbegin = dt.Rows[i]["cbegin"].ToString();
                cend = dt.Rows[i]["cend"].ToString();
                waredm = dt.Rows[i]["waredm"].ToString();

                sql = "select staffname from staff where staffid='" +empcode +  "'";
                if (mPersonDB.IsExists(sql))
                    continue;
                if (string.IsNullOrEmpty(birthday))
                    birthday = "1900-1-1";
                if (string.IsNullOrEmpty(joinDate))
                    joinDate = "1900-1-1";
                if (string.IsNullOrEmpty(cbegin))
                    cbegin = "1900-1-1";
                if (string.IsNullOrEmpty(cend))
                    cend = "1900-1-1";

                sql = "insert into staff(staffid,staffname,sex,birthdate,nativeplace,nation,ismarryed,education,graduateschool,specialty,IdentityNumber,RegisteredAddress,NowAddress,phone,mobile,EntryDate,ContractStartDate,ContractEndDate,organid)";
                sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')", empcode,empname,sex,birthday,zd3,zd4,zd5,zd6,zd7,zd8,IDCard,HAddress,CAddress,phone,mobil,joinDate,cbegin,cend,waredm);
                mPersonDB.ExecuteNonQuery(sql);
                
            }
        }

        private string GetQtyOfAcc(string itemcode,string dh)
        {

            string sql = string.Format("select sum(qty) as qty from outshopD where  itemcode='{0}' and dh='{1}' and zd6 in('部分退料','领料退回')", itemcode, dh);
            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            return dt.Rows[0][0].ToString();
        }

        private string GetDH(string id)
        {
            string sql;
           // sql =  " SELECT @@IDENTITY AS Id ";
          //  DataTable dt = mDesDB.ExecuteDataTable(sql);
            // = dt.Rows[0][0].ToString();
            sql = "select dh from repair where id =" + id;
            DataTable dt = mDesDB.ExecuteDataTable(sql);
            string dh = dt.Rows[0][0].ToString();
            return dh;

        }
        //private string GetPriceID(string repdm,string worktime1,string worktime)
        //{
        //    string sql = string.Format("select id from repitemprice where itemcode ='{0}' and empworkh={1} and actworkh ={2}",repdm,worktime1,worktime);
        //    DataTable dt = mDesDB.ExecuteDataTable(sql);
        //    string result = "0";
        //    if (dt.Rows.Count > 0)
        //    {
        //        result=dt.Rows[0][0].ToString();
                
        //    }
        //    return result;

        //}


        private string GetCustomer(string mobile)
        {
            string result="";
            string sql = string.Format("select * from customer where mobile='{0}' and len(custname)>1", mobile);

            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            if(dt.Rows.Count >0)
                result = dt.Rows[0]["CustName"].ToString();
            return result;

        }


        public void DelData()
        {

           
            string sql = "delete from carsale";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from carorder";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from accessoryind";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from accessoryinh";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from accware";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from carind";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from carinH";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from claimH";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from claimbillH";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from claimbillD";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from custvist";
            mDesDB.ExecuteNonQuery(sql);

            sql = "delete from elseaccout";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from financeaccounts";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from inwarerec";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from operateman";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from outwarerec";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from p2precv";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from prerecv";
            mDesDB.ExecuteNonQuery(sql);

            sql = "delete from accessory";
            mDesDB.ExecuteNonQuery(sql);

            sql = "delete from repair";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from repair_a";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from repair_i";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from spofstaff";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from stafffunction";
            //mDesDB.ExecuteNonQuery(sql);
            //sql = "delete from carbrand";
            //mDesDB.ExecuteNonQuery(sql);
            //sql = "delete from carser";
            //mDesDB.ExecuteNonQuery(sql);
            //sql = "delete from carmodel";
            //mDesDB.ExecuteNonQuery(sql);
            //sql = "delete from cardetail";
            //mDesDB.ExecuteNonQuery(sql);

            //sql = "delete from repairitem";
            //mDesDB.ExecuteNonQuery(sql);

            //sql = "delete from repairtype";
            //mDesDB.ExecuteNonQuery(sql);
            sql = "delete from repitemprice";
            mDesDB.ExecuteNonQuery(sql);


            //客户
            sql = "delete from customer";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from custvist";
            mDesDB.ExecuteNonQuery(sql);
            sql = "delete from carofcustomer";
            mDesDB.ExecuteNonQuery(sql);
        }

        private void AddCustomer(string mobile,string custname,string plate,string carmodel,string cardnum)
        {
            string sql = string.Format("select * from customer where mobile='{0}'", mobile);
            bool b = mDesDB.IsExists(sql);
            if (!b)
            {
                sql = string.Format("insert into customer(BH,mobile,CreateDate,CustName,cardno) values(dbo.GetCustomerBH('{2}'),'{0}',getdate(),'{1}','{3}')", mobile, custname, Comm.LoginInfoShare.getInstance().OrganId,cardnum);
                mDesDB.ExecuteNonQuery(sql);
                if (!string.IsNullOrEmpty(plate))
                {
                    sql = string.Format("insert into carofcustomer (mobile,platenum,carmodel) values('{0}','{1}','{2}')", mobile, plate, carmodel);
                    mDesDB.ExecuteNonQuery(sql);
                }
            }

        }




        public void hf_customer()
        {

            string sql = "SELECT     customer.客户编号 , customer.地区编号, customer.单位编号, customer.客户姓名, customer.客户照片, customer.客户性别, customer.出生年月, customer.身份证号, customer.邮政编码, "
                     + " customer.联系地址, customer.客户单位, customer.单位代码, customer.单位地址, customer.来源序号, customer.行业序号, customer.职务序号, customer.客户学历, customer.开户行, customer.税号, "
                     + " customer.账号, customer.备注, customer.客户手机, customer.第二手机, customer.家庭电话, customer.单位电话, customer.QQ, customer.微信, customer.人人账号, customer.Email, "
                     + " customer.手机标志, customer.登陆密码, customer.二维码, customer.手机图片, customer.会员图片, customer.客户余额, customer.客户类型, customer.系统客户, customer.生日回访, "
                      +" vip_member.会员卡号"
                     +  " FROM         customer left JOIN"
                      +" vip_member ON customer.客户编号 = vip_member.客户编号";

            DataTable dt = mSourceDB.ExecuteDataTable(sql);
            string mobile="";//  客户手机
            string bh="";// 客户编号
            string custname;//客户姓名
            string address;//联系地址
            string sex;//客户性别
            string telephone;//家庭电话
            string IdentityCard;//身份证号
           // string job="";
           // string IsMarryed;
           // string AgeScope;
            string Education;//客户学历
            string QQ;//QQ
            string wx;//微信
            string email;//Email
            //int vipt
            string CardNo;//会员卡号
            string custype;//客户类型
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                 mobile = dt.Rows[i]["客户手机"].ToString();
                 bh = dt.Rows[i]["客户编号"].ToString();
                 custname = dt.Rows[i]["客户姓名"].ToString();
                 address = dt.Rows[i]["联系地址"].ToString();
                 sex = dt.Rows[i]["客户性别"].ToString();
                 if (sex == "true")
                     sex = "女";
                 else
                     sex = "男";
                 telephone = dt.Rows[i]["家庭电话"].ToString();
                 IdentityCard = dt.Rows[i]["身份证号"].ToString();
                 Education = dt.Rows[i]["客户学历"].ToString();
                 QQ = dt.Rows[i]["QQ"].ToString();
                 wx = dt.Rows[i]["微信"].ToString();
                 email = dt.Rows[i]["email"].ToString();
                 CardNo = dt.Rows[i]["会员卡号"].ToString();
                 custype = dt.Rows[i]["客户类型"].ToString();
                 sql = "insert into customer(custname,mobile,sex,address,identitycard,cardno,BH,Education,QQ,wx,email,custtype,telephone)";
                 sql += string.Format(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", custname, mobile, sex, address, IdentityCard, CardNo, bh, Education, QQ, wx, email, custype,telephone);
                 mDesDB.ExecuteNonQuery(sql);
            }
          
        }
    }
}
