using System;
using System.Collections.Generic;
using System.ComponentModel;
using Order1;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        public string KeyWord { get; set; }
        public OrderService service = new OrderService();
        public int action_status = 0;
        string fileName = @"./orders.xml";
        public Form1()
        {
            InitializeComponent();
            Client client1 = new Client("Diyuan");
            Client client2 = new Client("Sama");
            Good game1 = new Good("Death cell", 38);
            Good game2 = new Good("Empty Knight", 78);
            Good game3 = new Good("Elda halo", 199);
            OrderDetails gameDetail1 = new OrderDetails(game1, 3);
            OrderDetails gameDetail2 = new OrderDetails(game2, 2);
            OrderDetails gameDetail3 = new OrderDetails(game3, 5);
            List<OrderDetails> Detail1 = new List<OrderDetails>{ gameDetail1, gameDetail2, gameDetail3 };
            List<OrderDetails> Detail2 = new List<OrderDetails>{ gameDetail1, gameDetail3 };
            List<OrderDetails> Detail3 = new List<OrderDetails>{ gameDetail2, gameDetail3 };
            Order order1 = new Order(client1, 1, Detail1);
            Order order2 = new Order(client1, 2, Detail2);
            Order order3 = new Order(client2, 3, Detail3);
            service.addOrder(order1);
            service.addOrder(order2);
            service.addOrder(order3);
            OrderbindingSource.DataSource = service.orders;
            QuerytextBox.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            action_status = 0;
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            action_status = 1;
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            int orderNo = (int)OrderdataGridView.CurrentRow.Cells[0].Value;
            Order order = service.getOrder(orderNo);
            if (order != null)
            {
                service.orders.Remove(order);
            }
            OrderbindingSource.ResetBindings(false);
        }

        private void Importbutton_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => 
                {
                    if (!service.orders.Contains(order))
                    {
                       service.orders.Add(order);
                    }
                });
            }
        }

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, service.orders);
            }
        }
        private void QuerybyNobutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyWord == null || KeyWord == "")
                {
                    OrderbindingSource.DataSource = service.orders;
                }
                else
                {
                    OrderbindingSource.DataSource = service.orders.Where(s => s.orderNo == int.Parse(KeyWord));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void QuerybyClientbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyWord == null || KeyWord == "")
                {
                    OrderbindingSource.DataSource = service.orders;
                }
                else
                {
                    OrderbindingSource.DataSource = service.orders.Where(s => s.client.clientName == KeyWord);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void QuerybyGoodbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyWord == null || KeyWord == "")
                {
                    OrderbindingSource.DataSource = service.orders;
                }
                else
                {
                    OrderbindingSource.DataSource = service.orders.Where(s => s.orderDetails.Exists(detail => detail.orderedGood.goodName == KeyWord));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void QuerybyPricebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyWord == null || KeyWord == "")
                {
                    OrderbindingSource.DataSource = service.orders;
                }
                else
                {
                    OrderbindingSource.DataSource = service.orders.Where(s => s.orderPrice >= int.Parse(KeyWord));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
