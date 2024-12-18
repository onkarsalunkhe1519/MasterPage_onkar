using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_onkar
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Razorpay API credentials
            string keyId = "rzp_test_Kl7588Yie2yJTV";
            string keySecret = "6dN9Nqs7M6HPFMlL45AhaTgp";

            // Initialize Razorpay client
            RazorpayClient razorpayClient = new RazorpayClient(keyId, keySecret);

            // Get the order amount from session (Assuming the amount is in 'GrandTotal')
            double amount = double.Parse(Session["GrandTotal"].ToString());

            // Create an order
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("amount", amount * 100); // Convert to paisa (multiply by 100)
            options.Add("currency", "INR");
            options.Add("receipt", "order_receipt_123");
            options.Add("payment_capture", 1); // Auto capture payment

            // Create the order using Razorpay API
            Razorpay.Api.Order order = razorpayClient.Order.Create(options);

            // Get the Order ID
            string orderId = order["id"].ToString();

            // Generate Razorpay checkout script for the front-end
            string razorpayScript = $@"
    var options = {{
        'key': '{keyId}',
        'amount': {amount * 100}, // Amount in paisa
        'currency': 'INR',
        'name': 'Masstech Business Solutions Pvt.Ltd',
        'description': 'Checkout Payment',
        'order_id': '{orderId}',
        'handler': function(response) {{
            // Handle successful payment response
            alert('Payment successful. Payment ID: ' + response.razorpay_payment_id);
        }},
        'prefill': {{
            'name': 'Krish Kheloji',
            'email': 'khelojikrish@gmail.com',
            'contact': '7208921898'
        }},
        'theme': {{
            'color': '#F37254'
        }}
    }};
    
    var rzp1 = new Razorpay(options);
    rzp1.open();
";

            // Register the script in the page
            ClientScript.RegisterStartupScript(this.GetType(), "razorpayScript", razorpayScript, true);

        }
    }
}