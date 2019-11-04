using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Payment.DAL;
using Payment.Models;
using Payment.DAL.DBInterface;

namespace Payment.BLL
{
    public class PaymentBLL 
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

        public int? MakePayment(PaymentModel paymentModel)
        {
            return _PaymentAdapter.MakePayment(paymentModel);
        }
        public int? CreditCardPayment(PaymentModel paymentModel)
        {
            return _PaymentAdapter.PaymentCreditCard(paymentModel);
        }
        public int? DebitCardPayment(PaymentModel paymentModel)
        {
            return _PaymentAdapter.PaymentCreditCard(paymentModel);
        }

        public int? RegisterCustomerData(RegisterModel Registerobj)
        {
            return _PaymentAdapter.RegisterCustomerData(Registerobj); 
        }
        public int? LoginCustomer(LoginModel loginobj)
        {
            return _PaymentAdapter.LoginCustomer(loginobj); ;
        }

        public List<PrePaidModel> Display(string MobileOperator)
        {
            return _PaymentAdapter.Display(MobileOperator);
        }

        public int? PostPaid(PostPaidModel postobj)
        {
            return _PaymentAdapter.PostPaid(postobj);
        }
        public int? DTHPay(DthModel dthobj)
        {
            return _PaymentAdapter.DTHPayment(dthobj);
        }
        public int? CheckNumber(long MobileNumber,string Operator)
        {
            return _PaymentAdapter.CheckNumber(MobileNumber, Operator);
        }

        public int? ForgotPasswordRegister(RegisterModel modelObj)
        {
            return _PaymentAdapter.ForgotPasswordRegister(modelObj);
        }
        public int? LoginVerify(long MobileNumber)
        {
            return _PaymentAdapter.LoginVerify(MobileNumber);
        }

        public string GetPaymenttype()
        {
            throw new NotImplementedException();
        }
    }
}