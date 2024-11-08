using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        int page = 1;
        bool sword = false;
        new Random randGen = new Random();
        int chance;

        private void Form1_Load(object sender, EventArgs e)
        {
            displayPage();
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.cave2;
                    outputLabel.Text = "Whilst adventuring through the woods, you discover a cave with two entrances. Which way do you go?";
                    option1Label.Text = "Go right";
                    option2Label.Text = "Go left";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.skeleton;
                    outputLabel.Text = "You come across an empty room, with a skeleton lying in the center.";
                    option1Label.Text = "Inspect the corpse";
                    option2Label.Text = "Move along";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.bat;
                    outputLabel.Text = "As you enter into a massive chamber, a giant bat drops down from the cieling and attacks you!";
                    option1Label.Text = "Fight back";
                    option2Label.Text = "Run away";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.sword;
                    outputLabel.Text = "The skeleton is clutching an old sword in its arms. It glistens with a faint glow.";
                    option1Label.Text = "Take the sword";
                    option2Label.Text = "Move along";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.skeleton;
                    outputLabel.Text = "You escape the giant bat.\nYou come across an empty room, with a skeleton lying in the center.";
                    option1Label.Text = "Inspect the corpse";
                    option2Label.Text = "Move along";
                    break;
                case 6:
                    outputLabel.Text = "After a long and hard fought battle, you beat the bat to death, but you feel exhausted.";
                    option1Label.Text = "Take a rest";
                    option2Label.Text = "Press onwards";
                    break;
                case 7:
                    outputLabel.Text = "You are brutally mauled and eaten by the bat. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    outputLabel.Text = "You continue your journey, finding a chamber with a pond in it.";
                    option1Label.Text = "Peer into the water";
                    option2Label.Text = "Ignore the pond";
                    break;
                case 9:
                    outputLabel.Text = "You are bitten by a venomous spider in yuor sleep, killing you before you wake up. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You feel something in the depths calling out to you.";
                    option1Label.Text = "Peer deeper";
                    option2Label.Text = "Back away from the pond";
                    break;
                case 11:
                    outputLabel.Text = "An unknown presence ambushes you from behind, killing you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "A monster suddenly pulls you into the water!\nYou fight back with your sword, slaying the beast, but you pass out due to blood loss.\nWhen you awake, you are on the beach, out of the cave.\nEscape ending. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "A monster suddenly pulls you into the water, eating you alive. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "As you back away, a monster jumps out of the water and rips you apart. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.sword;
                    sword = true;
                    outputLabel.Text = "You pry the sword from the skeleton's hands and proceed to the next chamber.\nYou feel like you could take on all kinds of monsters!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "Continue";
                    break;
                case 16:
                    outputLabel.Text = "You squeeze through a narrow passage until it opens to a massive ravine.\nThere's a safe route to the left, but you could climb down.";
                    option1Label.Text = "Safe route";
                    option2Label.Text = "Climb down";
                    break;
                case 17:
                    outputLabel.Text = "You lose your footing and fall to your death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    option3Label.Enabled = true;
                    option3.Enabled = true;
                    option3Label.Visible = true;
                    option3.Visible = true;
                    outputLabel.Text = "After climbing down the rocky surface, you find yourself surrounded by volcanoes. Ahead of you, you see a dragon, sleeping atop his hoard of gold.";
                    option1Label.Text = "Fight the dragon";
                    option2Label.Text = "Steal the gold";
                    option3Label.Text = "Sneak around";
                    break;
                case 19:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You try to steal the gold, but the coins moving creates a loud noise, waking the dragon.\nYou are burnt to a crisp by its fire breath. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You don't have a sword, so you're burned instantly. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You draw your sword, declaring your presence to the dragon. The dragon proceeds to spit fire at you.";
                    option1Label.Text = "Cut through the fire";
                    option2Label.Text = "Dodge out of the way";
                    break;
                case 22:
                    outputLabel.Text = "You try to dodge, but the flames surround you, and the dragon stomps on you. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 23:
                    outputLabel.Text = "Your sword glows bright and you cut straight through the fire. But what now?";
                    option1Label.Text = "Make a distraction";
                    option2Label.Text = "Charge at the dragon";
                    break;
                case 24:
                    outputLabel.Text = "You charge bravely at the dragon, but he squashes you underneath his heel. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 25:
                    outputLabel.Text = "You stab your sword into the ground, kicking up dust. What now?";
                    option1Label.Text = "Charge";
                    option2Label.Text = "Hide";
                    break;
                case 26:
                    outputLabel.Text = "You try to charge out of the dust, but the dragon just spews fire everywhere, reducing you to ash. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 27:
                    outputLabel.Text = "The dragon spews fire everywhere, but since you hid behind a rock formation, you are safe.\nThe dragon begins searching for your location.";
                    option1Label.Text = "Escape";
                    option2Label.Text = "Sneak attack";
                    break;
                case 28:
                    outputLabel.Text = "You try to escape, but the dragon slaps you with its tail, breaking everybone in your body. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 29:
                    outputLabel.Text = "Taking the dragon by surprise, you jump on its back. It tries to shake you but you hold firm.\nWith one mighty swing, you cut the dragon's head clean off.\nHero Ending. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 30:
                    outputLabel.Text = "You attempt to sneak past the dragon, but a volcano rumbles and the dragon wakes up and confronts you.";
                    option1Label.Text = "Run";
                    option2Label.Text = "Talk";
                    break;
                case 31:
                    option3Label.Enabled = true;
                    option3.Enabled = true;
                    option3Label.Visible = true;
                    option3.Visible = true;
                    outputLabel.Text = "How do you talk your way out of this?";
                    option1Label.Text = "Compliment";
                    option2Label.Text = "Make an excuse";
                    option3Label.Text = "Flirt";
                    break;
                case 32:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You tell the dragon that it has amazing teeth. It is so flattered that it decides to eat you instead of burning you.\nPlay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 33:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You tell the dragon you were just meeting a friend. The dragon is not amused, and burns you alive. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 34:
                    option3Label.Enabled = false;
                    option3.Enabled = false;
                    option3Label.Visible = false;
                    option3.Visible = false;
                    outputLabel.Text = "You make a witty quip at the dragon, in an attempt to seduce it. The dragon enjoys this and flirts back.\nYou and the dragon wind up getting married and moving to the countryside.\nSecret Ending. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;

            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                chance = randGen.Next(0,101);
                if(chance >= 70)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }

            }
            else if (page == 4)
            {
                page = 15;
            }
            else if (page == 5)
            {
                page = 4;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                if (sword == true)
                {
                    page = 12;
                }
                else
                {
                    page = 13;
                }
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 8;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                if (sword == true)
                {
                    page = 21;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 32;
            }
            else if (page == 32)
            {
                page = 1;
            }
            else if (page == 33)
            {
                page = 1;
            }
            else if (page == 34)
            {
                page = 1;
            }
            displayPage();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 16;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 15;
            }
            else if (page == 5)
            {
                page = 16;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                Close();
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                Close();
            }
            else if (page == 10)
            {
                page = 14;
            }
            else if (page == 11)
            {
                Close();
            }
            else if (page == 12)
            {
                Close();
            }
            else if (page == 13)
            {
                Close();
            }
            else if (page == 14)
            {
                Close();
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                chance = randGen.Next(0, 101);
                if (chance >= 50)
                {
                    page = 18;
                }
                else
                {
                    page = 17;
                }
            }
            else if (page == 17)
            {
                Close();
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                Close();
            }
            else if (page == 20)
            {
                Close();
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                Close();
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                Close();
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                Close();
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                Close();
            }
            else if (page == 29)
            {
                Close();
            }
            else if (page == 30)
            {
                page = 31;
            }
            else if (page == 31)
            {
                page = 33;
            }
            else if (page == 32)
            {
                Close();
            }
            else if (page == 33)
            {
                Close();
            }
            else if (page == 34)
            {
                Close();
            }
            displayPage();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 18)
            {
                page = 30;
            }
            else if (page == 31)
            {
                page = 34;
            }
            displayPage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
