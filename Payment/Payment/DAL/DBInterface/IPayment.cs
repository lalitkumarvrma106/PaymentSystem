using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.DAL.DBInterface
{
   internal interface IPayment
    {
     
        int? MakePayment(PaymentModel paymentModel);
        int? PaymentCreditCard(PaymentModel modelobj);
        int? NetBanking(PaymentModel modelobj);
        int? RegisterCustomerData(RegisterModel registerObj);
        int? LoginCustomer(LoginModel loginobj);
        List<PrePaidModel> Display(string MobileOperator);
        int? PostPaid(PostPaidModel postobj);
        int? CheckNumber(long MobileNumber, string Operator);
        int? ForgotPasswordRegister(RegisterModel modelobj);
        int? LoginVerify(long MobileNumber);
        int? DTHPayment(DthModel modelobj);
    }
}
