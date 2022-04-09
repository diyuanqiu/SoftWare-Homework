using System;
using Order1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form2 : Form
    {
        OrderDetails detail = new OrderDetails();
        Order order = new Order();
        Client client = new Client();
        Good good = new Good();

        public Form2()
        {
            InitializeComponent();
            Orderno_textBox.DataBindings.Add("Text", order, "orderNo");
            Client_textBox.DataBindings.Add("Text", client, "clientName");
            Good_textBox.DataBindings.Add("Text", good, "goodName");
            Quantity_textBox.DataBindings.Add("Text", detail, "orderedNum");
            Price_textBox.DataBindings.Add("Text", good, "goodPrice");
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Client newClient = new Client(client.clientName);
            OrderDetails newDetail = new OrderDetails(good,detail.orderedNum);
            Order newOrder = new Order(newClient, order.orderNo, new List<OrderDetails> {newDetail});
            switch(form1.action_status){
                case 0:
                    form1.service.addOrder(newOrder);
                    break;
                case 1:
                    Order updateOrder = form1.service.getOrder(order.orderNo);
                    foreach (OrderDetails detail in updateOrder.orderDetails)
                    {
                        if (detail.orderedGood.goodName == good.goodName)
                        {
                            OrderDetails detail1 = updateOrder.getDetails(good.goodName);
                            updateOrder.orderDetails.Remove(detail1);
                            break;
                        }
                    }
                    updateOrder.orderDetails.Add(newDetail);
                    break;
            }
            form1.OrderbindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
