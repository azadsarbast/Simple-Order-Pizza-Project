using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       float CostOfPizzaSize()
        {
           
            if(rbbSmall.Checked)
            {
               return Convert.ToSingle(rbbSmall.Tag);
            }
            else if (rbMeduim.Checked)
            {
               return Convert.ToSingle(rbMeduim.Tag);
            }
            else 
            {
               return Convert.ToSingle(rbLarge.Tag);
            }

           
        }

        float CostOfCrustType()
        {
            if(rbthinCrust.Checked) 
             return Convert.ToSingle(rbthinCrust.Tag);
           else
                return Convert.ToSingle(rbLarge.Tag);
              
           
        }

        float CostOftoppingsType()
        {
            float cost = 0;
            if (chkExtraChees.Checked)
            {
                cost += Convert.ToSingle(chkExtraChees.Tag);
            }
            if(chkGreenPrppers.Checked)
            {
                cost += Convert.ToSingle(chkGreenPrppers.Tag);
            }
            if(chkMushrooms.Checked)
            {
                cost += Convert.ToSingle(chkMushrooms.Tag);
            }
            if(chkOlives.Checked)
            {
                cost += Convert.ToSingle(chkOlives.Tag);

            }
            if (chkOnion.Checked)
            {
               cost +=Convert.ToSingle(chkOnion.Tag);
            }
            if(chkTomatose.Checked)
            {
                cost += Convert.ToSingle(chkTomatose.Tag);
            }
            return cost;

        }

        float UpdateTotalPrice()
        {
            return CostOfCrustType() + CostOftoppingsType() + CostOfPizzaSize();
        }

        void TotalPrice()
        {
            lblCost.Text= "$ "+UpdateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            if (rbbSmall.Checked)
             lblSize.Text = "Small";
            if (rbMeduim.Checked)
             lblSize.Text = "Meduim";
            if (rbLarge.Checked)
                lblSize.Text = "Large";
            
        }

        void UpdateCruestType()
        {
            if(rbthinCrust.Checked)
             lblcurstType.Text = "Thin Crust";
            if (rbThinkCrust.Checked)
             lblcurstType.Text = "Think Crust";
            
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lblWhereToeat.Text = "Eat In";
            if (rbtakeOut.Checked)
                lblWhereToeat.Text = "Take Out";
        }

        void UpdateToppings()
        {
            string Topping = "";
            if (chkExtraChees.Checked)
                Topping = "extra Chees";
            if (chkMushrooms.Checked)
                Topping += " , Mushrooms";
            if (chkTomatose.Checked)
                Topping += " , Tomatose";
            if (chkOnion.Checked)
                Topping += " , Onion";
            if (chkOlives.Checked)
                Topping += " , Olives";
            if (chkGreenPrppers.Checked)
                Topping += " , Green Peppers";
            if (Topping == "")
                Topping = "No Topping";
            lblTopping.Text = Topping;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         UpdateSize();  

        }

        private void tbSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCruestType();

        }

        private void rdthinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCruestType();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void ckbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
             
            UpdateToppings();



        }

        private void ckbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ckbTomatose_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void ckbGreenPrppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbtopping_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void lblCost_Click(object sender, EventArgs e)
        {
            TotalPrice();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
