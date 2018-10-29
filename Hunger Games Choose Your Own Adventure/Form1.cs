// Created by : Chris and Charlie
// Date       : 
// Description: 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading

namespace Hunger_Games_Choose_Your_Own_Adventure
{
    public partial class Form1 : Form
    {
        int scene = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (e.KeyCode == Keys.N)  //Yellow button press
                {
                    if (scene == 0)
                    {
                        scene = 2;
                    }
                    else if (scene == 1)
                    {
                        scene = 4;
                    }
                    else if (scene == 4)
                    {
                        scene = 6;
                    }
                }
            }
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 1:
                    outputLabel.Text = "Your cousin has been chosen to particiate in the hunger games. Do you want to take their place or go home?";
                    redLabel.Text = "You volunteer.";
                    blueLabel.Text = "Go home.";
                    break;
                case 2:
                    outputLabel.Text = "You go home feeling awful. You live out the rest of yourmundane life carrying this guit.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Everyone is suprised, and your cousin is releived. Your family cries as you leave on the train.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You arrive at the capital and begin training for the battle ahead. Will you train in survival, camoflauge, or combat?";
                    redLabel.Text = "Survival";
                    blueLabel.Text = "Combat";
                    yellowLabel.Text = "Camo";
                    break;
                case 5:
                    outputLabel.Text = "You trained in survival!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You trained in camo!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You trained in combat!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "Congradulatons! You are now ready to begin the Hunger Games.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "Finally you arrive in the arena. You see a large forest behind you, and the cornucopia in front of you. Go for the cornucopiaor run into the forest?";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 26:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 27:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 28:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 29:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 30:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 31:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 32:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 33:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 34:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 35:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 36:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 37:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 38:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 39:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 40:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 41:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 42:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
            }
        }
    }
}
