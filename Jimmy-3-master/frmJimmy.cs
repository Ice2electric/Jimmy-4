using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



/**

 *

 * Name: Daniel Olaniyanu

 * Teacher: Mr Hardman

 * Assignment #2, Program #1

 * Date Last Modified: 

 *

 */


namespace Jimmy
{
    public partial class Jimmy : Form
    {
        public Jimmy()
        {
            InitializeComponent();
        }

        private void Jimmy_Load(object sender, EventArgs e)
        {

        }

        private void Hello_Click(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            DialogResult dialogResult = MessageBox.Show("A new friend?", "Hi im Jimmy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: I always wanted a new friend");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Will you play with me im lonely");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Why not? ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Jimmy MAD");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:Il just make you play my game");
            }

            dialogResult = MessageBox.Show("Lets Play Dungeon", "Hi im Jimmy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Ok youre in my dungeon");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You have to escape");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: I dont care so...");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:Ok youre in my dungeon ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You have to escape  ");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            int milliseconds = 2000;
            MessageBox.Show("JIMMY: Cancel if your a Chicken ");
            Thread.Sleep(milliseconds);
            DialogResult dialogResult = MessageBox.Show("DUNGEON TWO READY", "Hi im Jimmy", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Your not a Chicken");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You meet a man with two cups ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Sit with him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Sit with him");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Chicken but you didnt press cancel stupid");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You meet a man with two cups ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Sit with him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Sit with him");
            }
            MessageBox.Show("Sit?!", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: He asks you to take  a drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Take the one on the left");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Take the one on the right ");



            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: He asks you to take  a drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Take the one on the left");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Take the one on the right ");
            }
            MessageBox.Show("Left or Right", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: You take the left drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: You die");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: It was fun bye");



            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: You take the right drink ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Poor manners he says");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol why is he pulling out a gun");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: It was fun bye");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            DialogResult dialogResult = MessageBox.Show("ARE YOU READY", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Alright you have a sword and sheild");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: A skeleton archer charges at you what do you do");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Charge at it with your sword");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Charge at it with your sheild");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: Be a man is what my mom always tells me");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Alright you have a sword and sheild");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: A skeleton archer  charges at you what do you do");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Yes: Charge at it with your sword");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: No: Charge at it with your sheild");
            }
            MessageBox.Show("FIGHT", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: You charged at it with your sword ");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: He shoots you in the face");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Dont look at me you didnt tell me to input a swing after you got to him");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY HAPPY");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:One more to go");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: You charged at him with your shield");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Used Sheild Bash to kill archer");
                System.Threading.Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: An assasin leaps from above thrusting his blade in your chest ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: GAME OVER ");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY: Lol you didnt ask if there was anything else");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY HAPPY");
                Thread.Sleep(milliseconds);
                MessageBox.Show("JIMMY:One more to go");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Strings and Info that needs to be stored
            string Name = (txtName.Text);

            string Gender = (txtGender.Text);

            int Level = Convert.ToInt32(txtLvl.Text);

            int Vitality = Convert.ToInt32(txtVitality.Text);

            int Attunement = Convert.ToInt32(txtAttunement.Text);

            int Endurance = Convert.ToInt32(txtEndurance.Text);

            int Strength = Convert.ToInt32(txtStrength.Text);

            int Dexterity = Convert.ToInt32(txtDexterity.Text);

            int Resistance = Convert.ToInt32(txtResistance.Text);

            int Intelligence = Convert.ToInt32(txtIntelligence.Text);
            

            int milliseconds = 2000;




            MessageBox.Show("JIMMY: Hello" + Name + " I am your Guide Jimmy");
            Thread.Sleep(milliseconds);
            DialogResult dialogResult = MessageBox.Show("Youre "+ Gender + " right?", "Hi im Jimmy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("JIMMY: Good the info on you is correct");
                System.Threading.Thread.Sleep(milliseconds);
                

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("JIMMY: That cant be right try again");
                Thread.Sleep(milliseconds);
                Application.Exit();

            }

             MessageBox.Show (string.Format("{0,10}{1,15:C2}\n{2,10}{3,15:P}\n{4,10}{5,15:C2}",
            "Subtotal", CostofGoods, "Taxes", taxes, "Total", totalCost);

            /**
             * Tools!!!!
            Random rand = new Random();
            int milliseconds = 2000;
            int chance = rand.Next(1, 26);
            string chancedisplay = chance.ToString();
            MessageBox.Show(chancedisplay + "%");
            
            double CostofGoods = Convert.ToDouble(txtUserCost.Text);

            double taxes = Convert.ToDouble(txtUserTax.Text);

            double totalCost = CostofGoods * (1 + taxes / 100.0);

            lblDisplay.Text = string.Format("{0,10}{1,15:C2}\n{2,10}{3,15:P}\n{4,10}{5,15:C2}",
            "Subtotal", CostofGoods, "Taxes", taxes, "Total", totalCost);
    */



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        // Starting here is the line of code that is associated with the gifts that change and boost your stats
        private void rbHpPotion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHpPotion.Checked)
                lblGiftInfo.Text = " HP Potion made from the bronze teir alchemy guild Thra, in the village of Valdemar\nVITALITY +25";
        }

        private void rbMidasScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMidasScroll.Checked)
                lblGiftInfo.Text = " Said to have infinte amounts of knowledge stored within,able to decipher any code or spell as well as teach it\nINTELLIGENCE +4";
        }

        private void rb1upDoll_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1upDoll.Checked)
                lblGiftInfo.Text = " The Nine present you with a doll filled with the light, albe to replaced a dead mans husk with life it self\n1UP";
        }

        private void rbHerculeArm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHerculeArm.Checked)
                lblGiftInfo.Text = " Take me and i will give thee strength insurmountable,O bearer mine\nSTRENGTH +3";
        }

        private void rbStyxOint_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStyxOint.Checked)
                lblGiftInfo.Text = " If you wish to claim water from the border of life and death, then quench your thirst and be harmed no further \nRESISTANCE +3";
        }

        private void OdyseusBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (OdyseusBranch.Checked)
                lblGiftInfo.Text = " I have lost my ghost,my mind not the same, picked apart endlessly and you will face the same fate .But there is still hope,i am alive,the branch is i and i the branch my crafts are yours my ally \nATTUNEMENT +4";
        }

        private void PosiedonTrydant_CheckedChanged(object sender, EventArgs e)
        {
            if (PosiedonTrydant.Checked)
                lblGiftInfo.Text = " Every weapon has its currents,its waves constant never changing. Only the will of the wielder can bend the current of his weapon weild me and make it so \nDEXTERITY +4";
        }

        private void rbMedusaSkull_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedusaSkull.Checked)
                lblGiftInfo.Text = " A mans emotions can betray him when he see's a ugly girl with an unpleasant face or figure.Gaze upon my skull friend,foe your fate will be the same your mind \nRESISTANCE +3";
        }

        private void rbOrpheusHrp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrpheusHrp.Checked)
                lblGiftInfo.Text = " Music cleanses the soul,it once brought my wife to life imagine what music can do for you \nVITALITY +15";
        }

        private void rbThesusCandle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThesusCandle.Checked)
                lblGiftInfo.Text = " I was once told that i am a light in  the dark,that a man who could escape the labyringth could do anything.But im not a GOD, i am a man who needs light and isnt light .Evry legend needs a light Drifter wield my candle well \nLights up Deungons\nINTELLIGENCE +5\n DETERITY +2";
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if (txtGender.Text == "Male")
            {
                lblGenderMale.Visible = true;
            }
            { 

                if (txtGender.Text == "Female")
                {
                    lblGenderFemale.Visible = true;


                }
            }

        }

    }
}



        

