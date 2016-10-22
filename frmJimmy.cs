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

 * Date Last Modified: 10/20/2016

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
             
             string Name = (txtName.Text);
            
            string Gender = (txtGender.Text);
            /**
             * THE HUMANITY SOB SOB WORK THAT COULDNT BE USED
             int Level = Convert.ToInt32(txtLvl.Text);
            
             int Vitality = Convert.ToInt32(txtVitality.Text);
            
             int Attunement = Convert.ToInt32(txtAttunement.Text);
            
             int Endurance = Convert.ToInt32(txtEndurance.Text);
            
             int Strength = Convert.ToInt32(txtStrength.Text);
            
             int Dexterity = Convert.ToInt32(txtDexterity.Text);
            
            int Resistance = Convert.ToInt32(txtResistance.Text);
            
             int Intelligence = Convert.ToInt32(txtIntelligence.Text);
            */
            
             int milliseconds = 2000;
            
             MessageBox.Show("JIMMY: Hello" + Name + " I am your Guide Jimmy");
             Thread.Sleep(milliseconds);
             DialogResult dialogResult = MessageBox.Show("Youre " + Gender + " right?", "Hi im Jimmy", MessageBoxButtons.YesNo);
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

            MessageBox.Show("JIMMY: Well im watching you drifter until the next update for story content.... ");
            Thread.Sleep(milliseconds);
            MessageBox.Show("JIMMY: Bye!");
            Application.Exit();
            //Tools Untouched

            /**
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
            if (rbHerculeArm.Checked)
                lblGiftInfo.Text = " Music cleanses the soul,it once brought my wife to life imagine what music can do for you \nVITALITY +15";
        }

        private void rbThesusCandle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHerculeArm.Checked)
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

        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            double firstgrade = Convert.ToDouble(txtGrade1.Text);
            double secondgrade = Convert.ToDouble(txtGrade2.Text);
            double thirdgrade = Convert.ToDouble(txtGrade3.Text);
            double fourthgrade = Convert.ToDouble(txtGrade4.Text);
            double fifthgrade = Convert.ToDouble(txtGrade5.Text);
            double average = (firstgrade + secondgrade + thirdgrade + fourthgrade + fifthgrade) / 5;
            double HP = (average * 100);
            double MP = (average * 15);
            double STA = (average * 20);
            lblAverageGrade.Text = String.Format("{0,10}{1,15},","Average",average);
            lblHP.Text = String.Format("{0,10}{1,15},", "HP:",HP);
            lblCalcAverage.Text = String.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}", "Grade 1", firstgrade, "Grade 2", secondgrade ,"Grade 3", thirdgrade, "Grade 4", fourthgrade, "Grade 5", fifthgrade);


            //lblMP.Text = String.Format("{0,10}{1,200},", "MP:",MP);
            //lblSTAMINA.Text = String.Format("{0,10}{1,200},", "STA:",STA);
        }

        private void lblHP_Click(object sender, EventArgs e)
        {
             
            double firstgrade = Convert.ToDouble(txtGrade1.Text);
            double secondgrade = Convert.ToDouble(txtGrade2.Text);
            double thirdgrade = Convert.ToDouble(txtGrade3.Text);
            double fourthgrade = Convert.ToDouble(txtGrade4.Text);
            double fifthgrade = Convert.ToDouble(txtGrade5.Text);
            double average = (firstgrade + secondgrade + thirdgrade + fourthgrade + fifthgrade) / 5;
            double HP = (average * 100);
            lblHP.Text = String.Format("{0,10}{1,15},", "HP:", HP);
    
        }

        private void lblMP_Click(object sender, EventArgs e)
        {
             /**
            double firstgrade = Convert.ToDouble(txtGrade1.Text);
            double secondgrade = Convert.ToDouble(txtGrade2.Text);
            double thirdgrade = Convert.ToDouble(txtGrade3.Text);
            double fourthgrade = Convert.ToDouble(txtGrade4.Text);
            double fifthgrade = Convert.ToDouble(txtGrade5.Text);
            double average = (firstgrade + secondgrade + thirdgrade + fourthgrade + fifthgrade) / 5;
            double MP = (average * 15);
            lblMP.Text = String.Format("{0,10}{1,200},", "MP:", MP);
     */
        }

        private void lblSTAMINA_Click(object sender, EventArgs e)
        {
            /**
            double firstgrade = Convert.ToDouble(txtGrade1.Text);
            double secondgrade = Convert.ToDouble(txtGrade2.Text);
            double thirdgrade = Convert.ToDouble(txtGrade3.Text);
            double fourthgrade = Convert.ToDouble(txtGrade4.Text);
            double fifthgrade = Convert.ToDouble(txtGrade5.Text);
            double average = (firstgrade + secondgrade + thirdgrade + fourthgrade + fifthgrade) / 5;
            double STA = (average * 20);
            lblSTAMINA.Text = String.Format("{0,10}{1,200},", "STA:", STA);
    */
        }

        private void rbTalented_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "10", "Vitality", "9", "Attunement", "10","Endurance", "10", "Strength", "10", "Dexterity", "10","Resistance", "10", "Intelligence", "10");
        }

        private void rbTitan_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "7", "Vitality", "8", "Attunement", "2", "Endurance", "8", "Strength", "10", "Dexterity", "3", "Resistance", "8", "Intelligence", "5");
        }

        private void rbRougue_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "6", "Vitality", "6", "Attunement", "4", "Endurance", "5", "Strength", "8", "Dexterity", "8", "Resistance", "4", "Intelligence", "7" );
        }

        private void rbMage_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "3", "Vitality", "6", "Attunement", "10", "Endurance", "4", "Strength", "1", "Dexterity", "1", "Resistance", "1", "Intelligence", "10");
        }

        private void rbTheif_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "1", "Vitality", "8", "Attunement", "0", "Endurance", "8", "Strength", "4", "Dexterity", "10", "Resistance", "2", "Intelligence", "9");
        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }

        private void rbDilinquent_CheckedChanged(object sender, EventArgs e)
        {
            lblCharacStats.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n{10,10}{11,15}\n{12,10}{13,15}\n{14,10}{15,15}",
            "Level", "0", "Vitality", "10", "Attunement", "0", "Endurance", "3", "Strength", "3", "Dexterity", "7", "Resistance", "10", "Intelligence", "4");
        }

        private void lblCalcAverage_Click(object sender, EventArgs e)
        {
           
        }
    }
}









/**
 * A LOT OF WHAT I WORKED ON BUT JUST FIGUTRED THE WAS A EASIER WAY TO DO IT, SO YEAH MORE TEARS  :(
       }
      
       private void txtLvl_TextChanged(object sender, EventArgs e)
       {
           int milliseconds = 2000;
           if (Convert.ToInt32(txtLvl.Text ) >= 9  )
           {
               
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtVitality_TextChanged(object sender, EventArgs e)
       {
           int milliseconds = 2000;
           if (Convert.ToInt32(txtVitality.Text) >= 9)
           {
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtAttunement_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtAttunement.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtEndurance_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtEndurance.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtStrength_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtStrength.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtDexterity_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtDexterity.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtResistance_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtResistance.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void txtIntelligence_TextChanged(object sender, EventArgs e)
       {
           if (Convert.ToInt32(txtIntelligence.Text) >= 9)
           {
               int milliseconds = 2000;
               MessageBox.Show("JIMMY: You did it now!");
               Thread.Sleep(milliseconds);
               Application.Exit();
           }
       }

       private void button4_Click(object sender, EventArgs e)
       {
           double Lvl = Convert.ToDouble(txtLvl.Text);

           double Vitality = Convert.ToDouble(txtVitality.Text);

           double Attunement = Convert.ToDouble(txtAttunement.Text);

           double Endurance = Convert.ToDouble(txtEndurance.Text);

           double Strength = Convert.ToDouble(txtStrength.Text);

           double Dexterity = Convert.ToDouble(txtDexterity.Text);

           double Intellligence = Convert.ToDouble(txtIntelligence.Text);

           double ClassEquation = (Lvl + Vitality + Attunement + Endurance + Strength + Dexterity + Intellligence ) ;
           
           if (ClassEquation == 64)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "TALENTED");
           }

           
               if (ClassEquation == 56)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "TITAN");
           }
               
                   if (ClassEquation == 48)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "PALADIN");
           }
                   
                       if (ClassEquation == 40)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "ROUGE");
           }
                       
                           if (ClassEquation == 32)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "ARCHER");
           }
                           
                               if (ClassEquation == 24)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "MAGE");
           }
                               
                                   if (ClassEquation == 16)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "THEIF");
           }
                                   
             if (ClassEquation == 8)
           {
               lblClass.Text = String.Format("{0,10}{1,15},", "Class:", "SLOW LEARNER");
           }
          
           }
       }
}
   */



