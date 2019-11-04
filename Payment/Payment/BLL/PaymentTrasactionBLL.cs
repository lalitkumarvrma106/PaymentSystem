using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Payment.DAL;
using Payment.Models;
using Payment.DAL.DBInterface;
namespace Payment.BLL
{
    public class PaymentTrasactionBLL
    {
        private PaymentDAL _PaymentAdapter = null;
        protected PaymentDAL PaymentAdapter
        {
            get
            {
                if (_PaymentAdapter == null)
                    _PaymentAdapter = new PaymentDAL();

                return _PaymentAdapter;
            }
        }

        public List<PaymentTrasaction> GetTrasactionDetails(PaymentTrasaction objPaytrasac)
        {
            return _PaymentAdapter.GetStatemnent(objPaytrasac);
        }
        public int? CheckCustomerIdentity(int? CustomerId, string IFSCCode, string BankName,int accountnumber )
        {
            return _PaymentAdapter.CheckCustomerIdentity(CustomerId, IFSCCode, BankName, accountnumber);
        }

    }
}