using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Moonbase
{
    public partial class Aeris : Form
    {
        Room room;

        public Aeris()
        {
            InitializeComponent();

            room = new Room(Background, North, South, East, West, Middle, RoomName, RoomDescription, RoomNumber,
                            Crew1,Crew2, Crew3, Crew4, Crew5, Job1, Job2, Job3, Job4, Job5);
        }

        // Making the Soundplayer objects to the play the .Wav Files on

        SoundPlayer ACSound = new SoundPlayer("C:\\Dev\\c# class\\Moonbase\\Moonbase\\Audio Files\\AC.wav");
        SoundPlayer WaterDrip = new SoundPlayer("C:\\Dev\\c# class\\Moonbase\\Moonbase\\Audio Files\\WaterDrop.wav");
        SoundPlayer ComputerFan = new SoundPlayer("C:\\Dev\\c# class\\Moonbase\\Moonbase\\Audio Files\\ComputerRoom.wav");

        //Room Functions using the room object funcitons

        private void Middle_Click(object sender, EventArgs e)
        {
            //Configuring which sound is playing
            WaterDrip.Stop();
            ComputerFan.Stop();
            ACSound.Play();

            room.RestingQuarters();
        }

        private void North_Click(object sender, EventArgs e)
        {
            //Configuring which sound is playing
            ComputerFan.Stop();
            ACSound.Stop();
            WaterDrip.Play();
            room.bathroom(); 
        }

        private void South_Click(object sender, EventArgs e)
        {
            //Configuring which sound is playing
            WaterDrip.Stop();
            ComputerFan.Stop();
            ACSound.Play();
            room.Kitchen();
        }

        private void West_Click(object sender, EventArgs e)
        {
            WaterDrip.Stop();
            ComputerFan.Stop();
            ACSound.Play();
            room.Airlock();
        }

        private void East_Click(object sender, EventArgs e)
        {
            //Configuring which sound is playing
            WaterDrip.Stop();
            ACSound.Stop();
            ComputerFan.Play();
            room.ControlRoom();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RoomName_Click(object sender, EventArgs e)
        {

        }

        // Room class that contains the room information
        public class Room
        {
            //Room references
            public PictureBox Background { get; set; }
            public Button North { get; set; }
            public Button South { get; set; }
            public Button East { get; set; }
            public Button West { get; set; }
            public Button Middle { get; set; }
            public Label RoomName { get; set; }
            public Label RoomDescription { get; set; }
            public Label RoomNumber { get; set; }
            private Random random { get; set; }

            public Label Crew1 { get; set; }
            public Label Crew2 { get; set; }
            public Label Crew3 { get; set; }
            public Label Crew4 { get; set; }
            public Label Crew5 { get; set; }

            public Label Job1 { get; set; }
            public Label Job2 { get; set; }
            public Label Job3 { get; set; }
            public Label Job4 { get; set; }
            public Label Job5 { get; set; }


            public Room(PictureBox background, Button north, Button south, 
             Button east, Button west, Button middle, Label roomName, Label roomDescription, Label roomNumber,
             Label Crew1, Label Crew2, Label Crew3, Label Crew4, Label Crew5,
             Label Job1, Label Job2, Label Job3, Label Job4, Label Job5)
            {
                //Room class variables
                Background = background;
                North = north;
                South = south;
                East = east;
                West = west;
                Middle = middle;
                RoomName = roomName;
                RoomDescription = roomDescription;
                RoomNumber = roomNumber;

                this.Crew1 = Crew1;
                this.Crew2 = Crew2;
                this.Crew3 = Crew3;
                this.Crew4 = Crew4;
                this.Crew5 = Crew5;

                this.Job1 = Job1;
                this.Job2 = Job2;
                this.Job3 = Job3;
                this.Job4 = Job4;
                this.Job5 = Job5;

                random = new Random();
                
            }

            

            //Room Class Functinos

            public void bathroom()
            {
                int randomNumber = random.Next(1,5);

                Background.Image = Properties.Resources.Bathroom;
                Background.SizeMode = PictureBoxSizeMode.StretchImage;
                RoomName.Text = "Bathroom";
                RoomNumber.Text = "3";

                //Arrays for the information to be housed in

                string[] CrewNames = new string[5];
                string[] JobNames = new string[5];

                //Arrays with the information

                string[] bathroomCrewNames = new string[] {"Randy", "Julian", "Bubbles", "Ricky","Jim"};
                string[] BathroomJobNames = new string[] { "Surveilliance", "Product Management", "Cleaner Supervisor", "Repair man", "Upper Management" };

                for (int i = 0; i < 5; i++)
                {
                    CrewNames[i] = bathroomCrewNames[i];
                    JobNames[i] = BathroomJobNames[i];

                }

                //Assigns the string in the array to the Labels within the groupBoxes 

                Crew1.Text = CrewNames[0];
                Crew2.Text = CrewNames[1];
                Crew3.Text = CrewNames[2];
                Crew4.Text = CrewNames[3];
                Crew5.Text = CrewNames[4];

                Job1.Text = JobNames[0];
                Job2.Text = JobNames[1];
                Job3.Text = JobNames[2];
                Job4.Text = JobNames[3];
                Job5.Text = JobNames[4];


                if (randomNumber == 1) { RoomDescription.Text = "You walk into the bathroom and it is surprisingly clean. You begin to wonder if anyone has even used it at all. You don't feel like you need to use the toilet so you begin to move on."; }
                if (randomNumber == 2) { RoomDescription.Text = "You walk into the bathroom and it is weirdly clean. You need to use the toilet. Afterwards you begin to move on."; }
                if (randomNumber == 3) { RoomDescription.Text = "It is, strangely quiet..."; }
                if (randomNumber == 4) { RoomDescription.Text = "You hear faint drips from the faucets"; }
                if (randomNumber == 5) { RoomDescription.Text = "There is steam left behind like someone was taking a shower..."; }


            }

            public void RestingQuarters()
            {
                int randomNumber = random.Next(1, 5);
                Background.Image = Properties.Resources.moonbasepic;
                Background.SizeMode = PictureBoxSizeMode.StretchImage;
                RoomName.Text = "Resting Quarters";
                RoomNumber.Text = "1";

                //Arrays for the information to be housed in

                string[] CrewNames = new string[5];
                string[] JobNames = new string[5];

                //Arrays with the information

                string[] bathroomCrewNames = new string[] { "Barbra", "Darla", "Blade", "Rosaria", "Evva" };
                string[] BathroomJobNames = new string[] { "Cleaning", "Product Inventory", "Cleaner Supervisor", "Vaccuming", "Upper Management" };

                for (int i = 0; i < 5; i++)
                {
                    CrewNames[i] = bathroomCrewNames[i];
                    JobNames[i] = BathroomJobNames[i];

                }

                //Assigns the string in the array to the Labels within the groupBoxes

                Crew1.Text = CrewNames[0];
                Crew2.Text = CrewNames[1];
                Crew3.Text = CrewNames[2];
                Crew4.Text = CrewNames[3];
                Crew5.Text = CrewNames[4];

                Job1.Text = JobNames[0];
                Job2.Text = JobNames[1];
                Job3.Text = JobNames[2];
                Job4.Text = JobNames[3];
                Job5.Text = JobNames[4];



                if (randomNumber == 1) { RoomDescription.Text = "You wake up in the Resting Quarters confused and wondering how you got on the moon. The last thing you remember is taking off on a routine space flight and you remember blacking out."; }
                if (randomNumber == 2) { RoomDescription.Text = "You roll over and hit the snooze button on your alarm clock."; }
                if (randomNumber == 3) { RoomDescription.Text = "You jump back into the bed feeling sleepy"; }
                if (randomNumber == 4) { RoomDescription.Text = "You wonder why you were the only one sleeping here."; }
                if (randomNumber == 5) { RoomDescription.Text = "You can't sleep and decide to move on"; }
            }

            public void Kitchen()
            {
                int randomNumber = random.Next(1, 5);
                Background.Image = Properties.Resources.Kitchen;
                Background.SizeMode = PictureBoxSizeMode.StretchImage;
                RoomName.Text = "Kitchen";
                RoomNumber.Text = "2";


                //Arrays for the information to be housed in

                string[] CrewNames = new string[5];
                string[] JobNames = new string[5];

                //Arrays with the information

                string[] bathroomCrewNames = new string[] { "Vanessa", "PAFF", "NEKO", "ROBO_Head", "Ivy" };
                string[] BathroomJobNames = new string[] { "Inventory", "Food Inventory", "Cook", "Researcher", "Upper Management" };

                for (int i = 0; i < 5; i++)
                {
                    CrewNames[i] = bathroomCrewNames[i];
                    JobNames[i] = BathroomJobNames[i];

                }

                //Assigns the string in the array to the Labels within the groupBoxes

                Crew1.Text = CrewNames[0];
                Crew2.Text = CrewNames[1];
                Crew3.Text = CrewNames[2];
                Crew4.Text = CrewNames[3];
                Crew5.Text = CrewNames[4];

                Job1.Text = JobNames[0];
                Job2.Text = JobNames[1];
                Job3.Text = JobNames[2];
                Job4.Text = JobNames[3];
                Job5.Text = JobNames[4];

                if (randomNumber == 1) { RoomDescription.Text = "It smells as if a meal was just cooked in here. You check the fridge and find left overs with a note. The note seems to be addressed to you and you notice your favorite meal was in it. You take the tupperware with you as you leave"; }
                if (randomNumber == 2) { RoomDescription.Text = "You decide to heat up ypur food in the microwave!"; }
                if (randomNumber == 3) { RoomDescription.Text = "You crack open an ice cold soda that you found in the fridge!"; }
                if (randomNumber == 4) { RoomDescription.Text = "You notice that there are spices and start to add salt to your meal in the tupperware."; }
                if (randomNumber == 5) { RoomDescription.Text = "You walk in and see pans in a cabnet across the room."; }
            }

            public void Airlock()
            {
                int randomNumber = random.Next(1, 5);
                Background.Image = Properties.Resources.Airlock;
                Background.SizeMode = PictureBoxSizeMode.StretchImage;
                RoomName.Text = "AirLock";
                RoomNumber.Text = "4";

                //Arrays for the information to be housed in

                string[] CrewNames = new string[5];
                string[] JobNames = new string[5];

                //Arrays with the information

                string[] bathroomCrewNames = new string[] { "Tank Dempsey", "Nikolai Belinski", "Takeo Masaki", "Edward Richtofen", "Samantha Maxis"};
                string[] BathroomJobNames = new string[] { "Guard", "Guard", "Guard", "Guard", "Lookout" };

                for (int i = 0; i < 5; i++)
                {
                    CrewNames[i] = bathroomCrewNames[i];
                    JobNames[i] = BathroomJobNames[i];

                }

                //Assigns the string in the array to the Labels within the groupBoxes

                Crew1.Text = CrewNames[0];
                Crew2.Text = CrewNames[1];
                Crew3.Text = CrewNames[2];
                Crew4.Text = CrewNames[3];
                Crew5.Text = CrewNames[4];

                Job1.Text = JobNames[0];
                Job2.Text = JobNames[1];
                Job3.Text = JobNames[2];
                Job4.Text = JobNames[3];
                Job5.Text = JobNames[4];

                if (randomNumber == 1) { RoomDescription.Text = "It appears to be the exit to the moonbase, but you don't see a space suit nearby. You don't even try to go outside"; }
                if (randomNumber == 2) { RoomDescription.Text = "You hear a small hiss from the dooor and your imagination begins to run wild."; }
                if (randomNumber == 3) { RoomDescription.Text = "You hear what sounds like knocking, but you are unable to figure out how to open the door."; }
                if (randomNumber == 4) { RoomDescription.Text = "After hearing some knocking, you then decide to see if you can get help"; }
                if (randomNumber == 5) { RoomDescription.Text = "There is nothing for you to do here so you move on."; }
            }


            public void ControlRoom()
            {
                int randomNumber = random.Next(1, 5);
                Background.Image = Properties.Resources.ControlRoom;
                Background.SizeMode = PictureBoxSizeMode.StretchImage;
                RoomName.Text = "ControlRoom";
                RoomNumber.Text = "5";

                //Arrays for the information to be housed in

                string[] CrewNames = new string[5];
                string[] JobNames = new string[5];

                //Arrays with the information

                string[] bathroomCrewNames = new string[] { "???", "???", "???", "???", "???" };
                string[] BathroomJobNames = new string[] { "???", "???", "???", "Leader", "???" };

                for (int i = 0; i < 5; i++)
                {
                    CrewNames[i] = bathroomCrewNames[i];
                    JobNames[i] = BathroomJobNames[i];

                }

                //Assigns the string in the array to the Labels within the groupBoxes

                Crew1.Text = CrewNames[0];
                Crew2.Text = CrewNames[1];
                Crew3.Text = CrewNames[2];
                Crew4.Text = CrewNames[3];
                Crew5.Text = CrewNames[4];

                Job1.Text = JobNames[0];
                Job2.Text = JobNames[1];
                Job3.Text = JobNames[2];
                Job4.Text = JobNames[3];
                Job5.Text = JobNames[4];


                if (randomNumber == 1) { RoomDescription.Text = "You walk into what appears to be the control room. You hear beeping buttons and blinking lights. At the endo of the runway you see a man. 'Look who decided to wake up.' The man says, 'We need your help. Come to me when your ready.'"; }
                if (randomNumber == 2) { RoomDescription.Text = "You see a strange man standing in the distance, he apperas to notice you."; }
                if (randomNumber == 3) { RoomDescription.Text = "You notice on of the computers has packman on. You fight the temptation to sit down and play..."; }
                if (randomNumber == 4) { RoomDescription.Text = "It smells like clener in here, but there is a mysterious man standing in the middle of the room."; }
                if (randomNumber == 5) { RoomDescription.Text = "You here what sounds like keys clacking in the middle of the room. A man then stands up and stares at you."; }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RoomNumber_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        //Crew
        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Jobs
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
