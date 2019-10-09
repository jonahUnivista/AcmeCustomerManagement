using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                button.Text = "Processing ...";
            }


            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            //populate the customer instance

            var order = new Order();
            // populate the order instance

            var allowSplitOrders = true;

            var emailReciepts = true;


            try
            {
                var payment = new Payment();
                var orderController = new OrderController();
                orderController.PlaceOrder(customer, order, payment, allowSplitOrders, emailReciepts);
            }
            catch (ArgumentNullException ex)
            {
                // Log
            }
        }
    }
}
