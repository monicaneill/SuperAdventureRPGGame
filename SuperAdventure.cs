using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player; // “class-level” variable. That means it can be seen by everything
                                // in the class. create a class level variable by having it inside
                                // your class (in this case, the SuperAdventure form – which is a
                                // class), but outside of any functions or methods.

                                //Datatype is Player because we want to store a Player object in it

        public SuperAdventure() //constructor for the class. The code in the constructor gets
                                //called when we create a new object of the class – in this case,
                                //the form.
        {
            InitializeComponent();

            Location test1 = new Location(1, "Home", "This is your house.");
            Location test2 = new Location(1, "Your House", "This is your house",
                null, null, null);

            //instantiate a Player object and store it in the _player variable.
            //creates a new Player object, assigns that object to the _player variable
            _player = new Player(10, 10, 20, 0, 1); 


            /*do above rather than this (assigning values to the _player object)
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;*/


            //getting the values of the properties from the _player object and assigning them to
            //the text of the labels on the screen.
            lblHP.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }
    }
}
