﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Personnel;
using Bll.Sale;
using Bll.Repair;
using Bll.P2P;

namespace Bll
{
    public class BllFactory
    {
        public static ICustomer GetCustomerBll()
        {
            ICustomer i=new CustomerBll();
            return i;

        }

        public static ICarDoc GetCarDocBll()
        {
            ICarDoc i = new CarDocBll();
            return i;

        }

        public static IDiction GetDictionaryBll()
        {
            IDiction i = new DictionaryBll();
            return i;

        }

        public static IExtend GetExtendBll()
        {
            IExtend i = new ExtendBll();
            return i;

        }

        public static ICarStock GetCarStockBll()
        {
            ICarStock i = new CarStockBll();
            return i;

        }

        public static IStaff GetStaffBll()
        {
            IStaff i = new StaffBllWS();
            return i;

        }
        public static IFucntion GetFunctionBll()
        {
            IFucntion i = new FunctionBllWS();
            return i;

        }
        public static ICustVist GetCustVistBll()
        {
            ICustVist i = new CustVistBll();
            return i;

        }
        public static ICarSale GetCarSaleBll  ()
        {
            ICarSale i = new CarSaleBll();
            return i;

        }

        public static IFinance GetFinanceBll()
        {
            IFinance i = new FinanceBll();
            return i;

        }

        public static IDepartment GetDepartmentBll()
        {
            IDepartment i = new DepartmentBllWS();
            return i;


        }


        public static IOperateMan GetOperateManBll()
        {
            IOperateMan i = new OperateManBll();
            return i;


        }


   

        public static IRepairItem GetRepairItemBll()
        {
            IRepairItem i = new RepairItemBll();
            return i;


        }

        public static IAccessory GetAccessoryBll()
        {
            IAccessory i = new AccessoryBll();
            return i;


        }

        public static IRepair GetRepariBll()
        {
            IRepair i = new RepairBll();
            return i;

        }

        public static IPosition GetPositionBll()
        {
            IPosition i = new PositionBllWS();
            return i;

        }

        public static IRepairAccessory GetRepairAccessoryBll()
        {
            IRepairAccessory i = new RepairAccessoryBll();
            return i;


        }

        public static IRepItemPrice GetRepItemPriceBll()
        {

            IRepItemPrice i = new RepItemPriceBll();
            return i;

        }

        public static IAccessoryIn GetAccessoryInBll()
        {

            IAccessoryIn i = new AccessoryInBll();
            return i;

        }


        public static IOrgan GetOrganBll()
        {

            IOrgan i = new OrganBllWS();
            return i;

        }

        public static IVip GetVipBll()
        {
            IVip i = new VipBll();
            return i;

        }

        public static IAccElseOut GetAccElseOutBll()
        {
            IAccElseOut i = new AccElseOutBll();
            return i;

        }

        public static ISenstive GetSenstiveBll()
        {
            ISenstive i = new SenstiveBll();
            return i;

        }

        public static ICarOfCust GetCarOfCustBll()
        {
            ICarOfCust i = new CarOfCustBll();
            return i;

        }

        public static IClaim GetClaimBll()
        {
            IClaim i = new ClaimBll();
            return i;

        }


        public static IP2P GetP2PBll()
        {
            IP2P i = new P2PBll();
            return i;


        }


        public static IBatchIn GetCarSerBll()
        {
            IBatchIn i = new CarSerBll();
            return i;
        }

        public static IBatchIn GetCarModelBll()
        {
            IBatchIn i = new CarModelBll();
            return i;
        }

        public static IAward GetAwardBll()
        {
            IAward i = new AwardBll();
            return i;


        }

        public static IVisit GetVisitBll()
        {
            IVisit i = new VisitBll();
            return i;
        }


        public static IAccessoryMatchBll GetAccessoryMatchBll()
        {
            IAccessoryMatchBll i = new AccessoryMatchBll();
            return i;
        }
    }
}
