// Created by : Chris and Charlie
// Date       : 
// Description: A Choose your own adventure game based off the hunger games
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

namespace Hunger_Games_Choose_Your_Own_Adventure
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int scene = 1;
        int randomChance;

        int combatSkill = 0;
        int berrySkill = 0;
        int camoSkill = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            randomChance = randGen.Next(1, 5);

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 7;
                    combatSkill = 1;
                }
                else if (scene == 9)
                {
                    scene = 21;
                }
                else if (scene == 11)
                {
                    scene = 13;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 17)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 32;
                }
                else if (scene == 33)
                {
                    //percentage question
                    if (camoSkill == 1)
                    {
                        scene = 35;
                    }
                    else if (randomChance == 1)
                    {
                        scene = 35;
                    }
                    else
                    {
                        scene = 36;
                    }
                }
                else if (scene == 35)
                {
                    scene = 38;
                }
                else if (scene == 37)
                {
                    scene = 41;
                }
                else if (scene == 38)
                {
                    scene = 41;
                }
                else if (scene == 26)
                {
                    scene = 28;
                }
                else if (scene == 27)
                {
                    scene = 31;
                }   
                else if (e.KeyCode == Keys.B)  //blue button press
                {
                    if (scene == 1)
                    {
                        scene = 2;
                    }
                    else if (scene == 4)
                    {
                        scene = 5;
                        berrySkill = 1;
                    }
                    else if (scene == 9)
                    {
                        //percentage question
                        if (combatSkill == 1)
                        {
                            scene = 11;
                        }
                        else if (randomChance == 1)
                        {
                            scene = 11;
                        }
                        else
                        { 
                            scene = 10;
                        }
                    }
                    else if (scene == 11)
                    {
                        scene = 12;
                    }
                    else if (scene == 14)
                    {
                        scene = 15;
                    }
                    else if (scene == 17)
                    {
                        scene = 18;
                    }
                    else if (scene == 22)
                    {
                        scene = 23;
                    }
                    else if (scene == 26)
                    {
                        scene = 27;
                    }
                    else if (scene == 27)
                    {
                        scene = 29;
                    }
                    else if (scene == 33)
                    {
                        scene = 34;
                    }
                    else if (scene == 35)
                    {
                        scene = 37;
                    }
                    else if (scene == 37)
                    {
                        scene = 39;
                    }
                    else if (scene == 38)
                    {
                        scene = 39;
                    }
                    else if (e.KeyCode == Keys.N)  //Yellow button press
                    {
                        if (scene == 4)
                        {
                            scene = 6;
                            camoSkill = 1;
                        }
                        else if (scene == 17)
                        {
                            scene = 19;
                        }
                        else if (scene == 27)
                        {
                            scene = 30;
                        }
                        else if (scene == 37)
                        {
                            scene = 40;
                        }
                        else if (scene == 38)
                        {
                            scene = 40;
                        }
                    }
                    switch (scene) { 

                    case 0:  
                        outputLabel.Text = "";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 1:
                        outputLabel.Text = "Your cousin has been chosen to particiate in the hunger games. Do you want to take their place or go home?";
                        redLabel.Text = "Volunteer.";
                        blueLabel.Text = "Go home.";
                        break;
                    case 2:
                        outputLabel.Text = "You go home feeling awful. You live out the rest of your mundane life carrying this guit.";
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
                        outputLabel.Text = "You get stabbed and die.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 11:
                        outputLabel.Text = "You manage to kill all but one of the other kids. Do you attempt to ally yourself with the other survivor, or do you try to kill her?";
                        redLabel.Text = "Kill her.";
                        blueLabel.Text = "Attemot to ally yourself.";
                        break;
                    case 12:
                        outputLabel.Text = "She pretends to want to work with you, then stabs you in the back. Literally. You die.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 13:
                        outputLabel.Text = "Probably a good choice. Anybody who goes to the cornicopia is in search of blood.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 14:
                        outputLabel.Text = "Tired after slaughtering a dozen kids, you barracade yourself in the Cornicopia and fall asleep. When you wake up you hear wolves in the distance. Do you want to try to hunt other kids, or stay where you are and try to hide?";
                        redLabel.Text = "Hunt the other survivors.";
                        blueLabel.Text = "Hide from the wolves.";
                        break;
                    case 15:
                        outputLabel.Text = "You try to hide behind a few boxes. The wolves see you and eat you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 16:
                        outputLabel.Text = "As you go to hunt the other survivors, you hear some people being eaten somewhere behind you. Good thing you didn't stay at the cornicopia.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 17:
                        outputLabel.Text = "You come across the last three remaining survivors. They appear to be in an alliance. Do you want to try to throw your suppllies at them, try to sneak up on them, or try to fight them in fair combat?";
                        redLabel.Text = "Attack the alliance.";
                        blueLabel.Text = "Throw your supplies at them.";

                        yellowImage.Visible = true;
                        yellowLabel.Visible = true;

                        yellowLabel.Text = "Try to sneak up on them.";
                        break;
                    case 18:
                        outputLabel.Text = "What exactly was that supposed to do? They turn around and kill you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";

                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;

                        break;
                    case 19:
                        outputLabel.Text = "You try to sneak up on them, but they hear you a mile away and kill you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";

                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;

                        break;
                    case 20:
                        outputLabel.Text = "You yell and run at them with your sword. Good thing you trained in combat because you easily defeat all of them!";
                        redLabel.Text = "";
                        blueLabel.Text = "";

                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        Thread.Sleep(10000);
                        scene = 42;

                        break;
                    case 21:
                        outputLabel.Text = "As you run into the forest you pick up a bag of supplies. It continues food, water, and a knife.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 22:
                        outputLabel.Text = "It starts to get dark. Do you want to try and camouflage or run further into the forest?";
                        redLabel.Text = "Camouflage yourself in the tree.";
                        blueLabel.Text = "Run into the forest.";
                        break;
                    case 23:
                        outputLabel.Text = "Probably a good choice. You run further and further away to the edge of the arena and sleep below a tree.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 24:
                        outputLabel.Text = "As you wake up in the morning you find a bush full of berries beside you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 25:
                        outputLabel.Text = "Starving, you go to eat the berries. As it turns out, they are poisonous and you die.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 26:
                        outputLabel.Text = "You recognize them as poisonous and put them in your pocket for later. You hear wolves running around near you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 27:
                        outputLabel.Text = "As you run away you encounter the last remaining survivor. Do you want to switch the berries in his food supply with the poisonous ones, hide in a bush, or run at him with your knife?";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 28:
                        outputLabel.Text = "You run bravely at them with your knife and are eaten almost instantly.";
                        redLabel.Text = "Attack them.";
                        blueLabel.Text = "Switch the berries";
                        
                        yellowImage.Visible = true;
                        yellowLabel.Visible = true;

                        yellowLabel.Text = "Hide in a bush.";
                        break;
                    case 29:
                        outputLabel.Text = "You switch the berries successfully, and watch as he mistakenly eats the poisoned ones and dies. ";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        Thread.Sleep(10000);
                        scene = 42;
                        
                        break;
                    case 30:
                        outputLabel.Text = "You try to hide in a bush, but he sees you instantly and stabs you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        break;
                    case 31:
                        outputLabel.Text = "You run at him with your knife, but he turns around and stabs you. You die.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        break;
                    case 32:
                        outputLabel.Text = "You successfully camouflage yourself in the tree and fall asleep.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 33:
                        outputLabel.Text = "You wake up in the morning and hear people rustling around below you. Do you want to trust your camouflage or try to run away by jumping from tree to tree?";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 34:
                        outputLabel.Text = "You start jumping from tree to tree, but fall out instantly and break your leg. It turns out that the rustling you heard was multiple survivors. You are helpless as they kill you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 35:
                        outputLabel.Text = "You are well enough hidden for the people to go away. Do you go check out the Cornucopia or stay hidden?";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    case 36:
                        outputLabel.Text = "They notice you almost immediately and they kill you.";
                        redLabel.Text = "Go to the Cornucopia.";
                        blueLabel.Text = "Stay hidden.";
                        break;
                    case 37:
                        outputLabel.Text = "You decide to stay hidden in the tree. As you hide there, packs of wolves run beneath you. You understand that there is only one other remaining survivor. You see him walk past you. Do you trow your bag at him, stay hidden and wait for something to happen, or try to stab him with your knife.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = true;
                        yellowLabel.Visible = true;

                        yellowLabel.Text = "Stay hidden.";
                        
                        break;
                    case 38:
                        outputLabel.Text = "You decide to go and see the Cornucopia. You hide behind a bush on the edge of the clearing. You hear wolves in the distance. You understand that there is only one other remaining survivor. You see him walk past you. Do you trow your bag at him, stay hidden and wait for something to happen, or try to stab him with your knife.";
                        redLabel.Text = "Try to stab him.";
                        blueLabel.Text = "Throw your bag at him.";
                        
                        yellowImage.Visible = true;
                        yellowLabel.Visible = true;

                        yellowLabel.Text = "Stay hidden.";
                        
                        break;
                    case 39:
                        outputLabel.Text = "What exactly was that supposed to do? He turns around and kills you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        break;
                    case 40:
                        outputLabel.Text = "Good thing you trained in camouflage! He passes by without seeing you, and he is killed by the wolves. You win!";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        Thread.Sleep(10000);
                        scene = 42;
                        
                        break;
                    case 41:
                        outputLabel.Text = "You go up to stab him, and realize that you have no idea how to use a knife. You try to use the blunt end , but he turns around and kills you.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        
                        yellowImage.Visible = false;
                        yellowLabel.Visible = false;
                        
                        break;
                    case 42:
                        outputLabel.Text = "You won the hunger games! You and your family live happily ever after in victor's row.";
                        redLabel.Text = "";
                        blueLabel.Text = "";
                        break;
                    }

                }
            }
        }
    }
}
