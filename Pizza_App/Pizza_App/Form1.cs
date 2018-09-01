using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Measure small = new Measure { Name = "Small", Multiplication = 1 };
            Measure middle = new Measure { Name = "Middle", Multiplication = 1.25 };
            Measure big = new Measure { Name = "Big", Multiplication = 1.75 };
            Measure Maxi = new Measure { Name = "Maxi", Multiplication = 2 };

            cmdMeasure.Items.Add(small);
            cmdMeasure.Items.Add(middle);
            cmdMeasure.Items.Add(big);
            cmdMeasure.Items.Add(Maxi);

            Pizza classic = new Pizza { Name = "Classic", Price = 14 };
            Pizza mixed = new Pizza { Name = "Mixed", Price = 17 };
            Pizza Pico = new Pizza { Name = "Pico", Price = 20 };
            Pizza bruno = new Pizza { Name = "Bruno", Price = 21 };
            Pizza mizza = new Pizza { Name = "Mizza", Price = 19 };
            Pizza holiday = new Pizza { Name = "Holiday", Price = 22 };

            ListPizzas.Items.Add(classic);
            ListPizzas.Items.Add(mixed);
            ListPizzas.Items.Add(Pico);
            ListPizzas.Items.Add(bruno);
            ListPizzas.Items.Add(mizza);
            ListPizzas.Items.Add(holiday);

            Outside exquisite = new Outside { Name = "Exquisite Edge", Extraprice = 0 };
            rdbexquisite.Tag = exquisite;
            Outside Thick = new Outside { Name = "Thick Edge", Extraprice = 2 };
            rdbthick.Tag = Thick;
        }

        Order s;

        private void btnCount_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)ListPizzas.SelectedItem;
            p.Measure = (Measure)cmdMeasure.SelectedItem;
            p.Outside = rdbexquisite.Checked ? (Outside)rdbexquisite.Tag : (Outside)rdbthick.Tag;
            p.Products = new List<string>();

            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Products.Add(ctrl.Text);
                }
                decimal Amount = numNumber.Value * p.TotalCount;
                textAmount.Text = Amount.ToString();
                s = new Order();
                s.Pizza = p;
                s.Number = (int)numNumber.Value;




            }
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                listBasket.Items.Add(s);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

            decimal Total = 0;
            int number = 0;
            foreach (Order sif in listBasket.Items)
            {
                Total += sif.Number * sif.Pizza.TotalCount;
                number++;
            }
            label7.Text = Total.ToString();
            MessageBox.Show(string.Format("Total Order Number : {0} \n Total Order invoice  : {1}", number, Total));
        }
    }
}
