using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }

        public enum PaymentTypeOption
        {
            CreditCard = 1,
            PayPal = 2
        }

        public void ProcessPayment(Payment payment)
        {
            PaymentType paymentTypeOption;
            if (!Enum.TryParse(this.PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }

            //if (!Enum.TryParse("creditcard", true, out paymentTypeOption))
            //{
            //    throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            //}

            switch (paymentTypeOption)
            {
                case BL.PaymentType.CreditCard:
                    // Process credit card
                    break;
                case BL.PaymentType.PayPal:
                    // Process PayPal
                    break;
                default:
                    throw new ArgumentException();
            }
            // -- Process the payment -- 

        }
    }
}
