using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmFood : Form
    {
        public FrmFood()
        {
            InitializeComponent();
        }
        //class constants
        //const int TAX_RATE = 10;
        //const int SANDWICH = 150;
        //const int ZINGER = 250;
        //const int BIRYANI = 100;
        //const int SAUCES = 50;
        //const int SALAD = 100;
        //const int SPRITE = 50;
        //const int STING = 50;
        //const int COKE = 80;
        //const int SODA = 30;
        //const int FRIES = 100;
        //const int ONION_RINGS = 100;
        ////class variables
        //int subTotal;
        //int Tax;
        //int Total;
        private void Display_Load(object sender, EventArgs e)
        {
            //initializeVariables();
            //ClearCustomerSelections();
            //ClearTheReceipt();
        }
        private void initializeVariables()
        {
            //subTotal = 0;
            //Tax = 0;
            //Total = 0;
        }
        private void ClearCustomerSelections()
        {
            //radNone.Checked = true;
            //radNoDrink.Checked = true;
            //radSndwich.Checked = false;
            //radZinger.Checked = false;
            //radBiryani.Checked = false;
            //radSprite.Checked = false;
            //radSting.Checked = false;
            //radCoke.Checked = false;
            //radSoda.Checked = false;
            //chkFries.Checked = false;
            //chkRings.Checked = false;
            //chkSalad.Checked = false;
            //chkSauce.Checked = false;

        }
        private void ClearTheReceipt()
        {
        //    lstTotal.Items.Clear();
        //    lstOrder.Items.Clear();
        }
        private void ComputeCurrentSelection()
        {
            //if (radSndwich.Checked == true)
            //{
            //    subTotal += SANDWICH;
            //    String SandwichItem=SANDWICH.ToString("C")+("Sandwich");
            //    lstOrder.Items.Add(SandwichItem);
            //}
            //else if (radZinger.Checked == true)
            //{
            //    subTotal += ZINGER;
            //    String ZingerItem = ZINGER.ToString("C") + ("Zinger");
            //    lstOrder.Items.Add(ZingerItem);
            //}
            //else if (radBiryani.Checked == true)
            //{
            //    subTotal += BIRYANI;
            //    String BiryaniItem = BIRYANI.ToString("C") + ("Biryani");
            //    lstOrder.Items.Add(BiryaniItem);
            //}
            //else if (chkSauce.Checked == true)
            //{
            //    subTotal += SAUCES;
            //    String SauceItem = SAUCES.ToString("C") + ("Sauce");
            //    lstOrder.Items.Add(SauceItem);
            //}
            //else if (chkSalad.Checked == true)
            //{
            //    subTotal += SALAD;
            //    String SaladItem = SALAD.ToString("C") + ("Salad");
            //    lstOrder.Items.Add(SaladItem);
            //}
            //else if (chkFries.Checked == true)
            //{
            //    subTotal += FRIES;
            //    String FriesItem = FRIES.ToString("C") + ("fries");
            //    lstOrder.Items.Add(FriesItem);
            //}
            //else if (chkRings.Checked == true)
            //{
            //    subTotal += ONION_RINGS;
            //    String RingsItem = ONION_RINGS.ToString("C") + ("Onion Rings");
            //    lstOrder.Items.Add(RingsItem);
            //}

            //else if (radSprite.Checked == true)
            //{
            //    subTotal += SPRITE;
            //    String SpriteItem = SPRITE.ToString("C") + ("Sprite");
            //    lstOrder.Items.Add(SpriteItem);
            //}
            //else if (radSting.Checked == true)
            //{
            //    subTotal += STING;
            //    String StingItem = STING.ToString("C") + ("Sting");
            //    lstOrder.Items.Add(StingItem);
            //}
            //else if (radCoke.Checked == true)
            //{
            //    subTotal += COKE;
            //    String CokeItem = COKE.ToString("C") + ("Coke");
            //    lstOrder.Items.Add(CokeItem);
            //}
            //else if (radSoda.Checked == true)
            //{
            //    subTotal += SODA;
            //    String SodaItem = SODA.ToString("C") + ("Soda");
            //    lstOrder.Items.Add(SodaItem);
            //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Desi d = new Desi();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chinese c = new Chinese();
            c.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FastFood f2 = new FastFood();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ////private void updateTotal()
        ////{
        ////    //clear previous subtotal,tax and total
        ////    lstTotal.Items.Clear();
        ////    //compute and display the subtotal
        ////    lstTotal.Items.Add("SubTotal= " + subTotal.ToString("C"));
        ////    //compute and display the tax
        ////    Tax = subTotal * TAX_RATE;
        ////    lstTotal.Items.Add("Tax= " + Tax.ToString("C"));
        ////    //compute and display the total
        ////    Total = subTotal + Tax;
        ////    lstTotal.Items.Add("Total= " + Total.ToString("C"));
        ////    //separating each persons order on the receipt
        ////    lstOrder.Items.Add("-------------------------");

        ////}

       


       

       

       

       
    }
}
