using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPDKP_KanyaAzaliaAndriyani_21120119130063
{
    public partial class NintendoSwitch : Form
    {
        System.Media.SoundPlayer startup = new System.Media.SoundPlayer();
        System.Media.SoundPlayer select = new System.Media.SoundPlayer();

        public static string namans = Form1.nama;

        class Action
        {
            private string Nama1;
            private string Nama2;
            private string Nama3;
            private string Gnr1;
            private string Gnr2;
            private string Gnr3;
            private string Dnp1;
            private string Dnp2;
            private string Dnp3;
            private string Rev1;
            private string Rev2;
            private string Rev3;

            public void setNama1(string nama1)
            {
                this.Nama1 = nama1;
            }
            public string getNama1()
            {
                return Nama1;
            }
            public void setNama2(string nama2)
            {
                this.Nama2 = nama2;
            }
            public string getNama2()
            {
                return Nama2;
            }
            public void setNama3(string nama3)
            {
                this.Nama3 = nama3;
            }
            public string getNama3()
            {
                return Nama3;
            }

            public void setGnr1(string gnr1)
            {
                this.Gnr1 = gnr1;
            }
            public string getGnr1()
            {
                return Gnr1;
            }
            public void setGnr2(string gnr2)
            {
                this.Gnr2 = gnr2;
            }
            public string getGnr2()
            {
                return Gnr2;
            }
            public void setGnr3(string gnr3)
            {
                this.Gnr3 = gnr3;
            }
            public string getGnr3()
            {
                return Gnr3;
            }

            public void setDnp1(string dnp1)
            {
                this.Dnp1 = dnp1;
            }
            public string getDnp1()
            {
                return Dnp1;
            }
            public void setDnp2(string dnp2)
            {
                this.Dnp2 = dnp2;
            }
            public string getDnp2()
            {
                return Dnp2;
            }
            public void setDnp3(string dnp3)
            {
                this.Dnp3 = dnp3;
            }
            public string getDnp3()
            {
                return Dnp3;
            }

            public void setRev1(string rev1)
            {
                this.Rev1 = rev1;
            }
            public string getRev1()
            {
                return Rev1;
            }
            public void setRev2(string rev2)
            {
                this.Rev2 = rev2;
            }
            public string getRev2()
            {
                return Rev2;
            }
            public void setRev3(string rev3)
            {
                this.Rev3 = rev3;
            }
            public string getRev3()
            {
                return Rev3;
            }
        }

        class RPG
        {
            private string Nama1;
            private string Nama2;
            private string Nama3;
            private string Gnr1;
            private string Gnr2;
            private string Gnr3;
            private string Dnp1;
            private string Dnp2;
            private string Dnp3;
            private string Rev1;
            private string Rev2;
            private string Rev3;

            public void setNama1(string nama1)
            {
                this.Nama1 = nama1;
            }
            public string getNama1()
            {
                return Nama1;
            }
            public void setNama2(string nama2)
            {
                this.Nama2 = nama2;
            }
            public string getNama2()
            {
                return Nama2;
            }

            public void setGnr1(string gnr1)
            {
                this.Gnr1 = gnr1;
            }
            public string getGnr1()
            {
                return Gnr1;
            }
            public void setGnr2(string gnr2)
            {
                this.Gnr2 = gnr2;
            }
            public string getGnr2()
            {
                return Gnr2;
            }
            public void setGnr3(string gnr3)
            {
                this.Gnr3 = gnr3;
            }
            public string getGnr3()
            {
                return Gnr3;
            }

            public void setDnp1(string dnp1)
            {
                this.Dnp1 = dnp1;
            }
            public string getDnp1()
            {
                return Dnp1;
            }
            public void setDnp2(string dnp2)
            {
                this.Dnp2 = dnp2;
            }
            public string getDnp2()
            {
                return Dnp2;
            }
            public void setDnp3(string dnp3)
            {
                this.Dnp3 = dnp3;
            }
            public string getDnp3()
            {
                return Dnp3;
            }

            public void setRev1(string rev1)
            {
                this.Rev1 = rev1;
            }
            public string getRev1()
            {
                return Rev1;
            }
            public void setRev2(string rev2)
            {
                this.Rev2 = rev2;
            }
            public string getRev2()
            {
                return Rev2;
            }
            public void setRev3(string rev3)
            {
                this.Rev3 = rev3;
            }
            public string getRev3()
            {
                return Rev3;
            }
        }

        class Simulation
        {
            private string Nama1;
            private string Nama2;
            private string Nama3;
            private string Gnr1;
            private string Gnr2;
            private string Gnr3;
            private string Dnp1;
            private string Dnp2;
            private string Dnp3;
            private string Rev1;
            private string Rev2;
            private string Rev3;

            public void setNama1(string nama1)
            {
                this.Nama1 = nama1;
            }
            public string getNama1()
            {
                return Nama1;
            }
            public void setNama2(string nama2)
            {
                this.Nama2 = nama2;
            }
            public string getNama2()
            {
                return Nama2;
            }

            public void setGnr1(string gnr1)
            {
                this.Gnr1 = gnr1;
            }
            public string getGnr1()
            {
                return Gnr1;
            }
            public void setGnr2(string gnr2)
            {
                this.Gnr2 = gnr2;
            }
            public string getGnr2()
            {
                return Gnr2;
            }
            public void setGnr3(string gnr3)
            {
                this.Gnr3 = gnr3;
            }
            public string getGnr3()
            {
                return Gnr3;
            }

            public void setDnp1(string dnp1)
            {
                this.Dnp1 = dnp1;
            }
            public string getDnp1()
            {
                return Dnp1;
            }
            public void setDnp2(string dnp2)
            {
                this.Dnp2 = dnp2;
            }
            public string getDnp2()
            {
                return Dnp2;
            }
            public void setDnp3(string dnp3)
            {
                this.Dnp3 = dnp3;
            }
            public string getDnp3()
            {
                return Dnp3;
            }

            public void setRev1(string rev1)
            {
                this.Rev1 = rev1;
            }
            public string getRev1()
            {
                return Rev1;
            }
            public void setRev2(string rev2)
            {
                this.Rev2 = rev2;
            }
            public string getRev2()
            {
                return Rev2;
            }
            public void setRev3(string rev3)
            {
                this.Rev3 = rev3;
            }
            public string getRev3()
            {
                return Rev3;
            }
        }

        public NintendoSwitch()
        {
            InitializeComponent();

            startup.SoundLocation = "Nintendo Switch Click.wav";
            select.SoundLocation = "Select Sound Effect.wav";
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre.Text = genre.SelectedItem.ToString();
        }

        private void lihatgame_Click(object sender, EventArgs e)
        {
            select.Play();

            string newLine = Environment.NewLine;

            if (genre.Text == "Action")
            {
                Action nsaction = new Action();
                nsaction.setNama1("LoZ: Breath of The Wild");
                nsaction.setNama2("Super Smash Bros. Ultimate");
                nsaction.setNama3("Bayonetta");
                nsaction.setGnr1("Action-Adventure" + newLine + "3 Maret 2017");
                nsaction.setGnr2("Action, Fighting" + newLine + "7 Desember 2018");
                nsaction.setGnr3("Action, Hack and Slash" + newLine + "29 Oktober 2009");
                nsaction.setDnp1("Nintendo EPD" + newLine + "Nintendo Switch dan Wii U");
                nsaction.setDnp2("Bandai Namco Studios Sora Ltd." + newLine + "Nintendo Switch");
                nsaction.setDnp3("Platinum Games" + newLine + "Nintendo Switch, PS3-4, PC, Xbox 360-One, Wii U");
                nsaction.setRev1("10/10 Gamespot," + newLine + "97% Metacritic");
                nsaction.setRev2("93% Metacritic," + newLine + "9/10 Digital Trends");
                nsaction.setRev3("7/10 Push Square," + newLine + "8/10 GameSpot");

                game1.Text = nsaction.getNama1();
                game2.Text = nsaction.getNama2();
                game3.Text = nsaction.getNama3();
                gr1.Text = nsaction.getGnr1();
                gr2.Text = nsaction.getGnr2();
                gr3.Text = nsaction.getGnr3();
                dp1.Text = nsaction.getDnp1();
                dp2.Text = nsaction.getDnp2();
                dp3.Text = nsaction.getDnp3();
                r1.Text = nsaction.getRev1();
                r2.Text = nsaction.getRev2();
                r3.Text = nsaction.getRev3();
            }
            if (genre.Text == "RPG")
            {
                Action nsaction = new Action();
                nsaction.setNama1("Fire Emblem: Three Houses");
                nsaction.setNama2("Octopath Traveler");
                nsaction.setNama3("Dragon Quest XI");
                nsaction.setGnr1("Tactical-RPG" + newLine + "26 Juli 2019");
                nsaction.setGnr2("RPG" + newLine + "13 Juli 2018");
                nsaction.setGnr3("RPG" + newLine + "29 Juli 2017");
                nsaction.setDnp1("Intelligent Systems Koei Tecmo" + newLine + "Nintendo Switch");
                nsaction.setDnp2("Square Enix Business Division 11" + newLine + "Nintendo Switch, PC, Stadia");
                nsaction.setDnp3("Square Enix" + newLine + "Nintendo Switch, Nintendo 3DS, PS4, PC");
                nsaction.setRev1("89% Metacritic");
                nsaction.setRev2("83% Metacritic");
                nsaction.setRev3("91% Metacritic," + newLine + "8.8/10 IGN.com");

                game1.Text = nsaction.getNama1();
                game2.Text = nsaction.getNama2();
                game3.Text = nsaction.getNama3();
                gr1.Text = nsaction.getGnr1();
                gr2.Text = nsaction.getGnr2();
                gr3.Text = nsaction.getGnr3();
                dp1.Text = nsaction.getDnp1();
                dp2.Text = nsaction.getDnp2();
                dp3.Text = nsaction.getDnp3();
                r1.Text = nsaction.getRev1();
                r2.Text = nsaction.getRev2();
                r3.Text = nsaction.getRev3();
            }
            if (genre.Text == "Simulation")
            {
                Action nsaction = new Action();
                nsaction.setNama1("AC: New Horizons");
                nsaction.setNama2("Stardew Valley");
                nsaction.setNama3("Cities: Skylines");
                nsaction.setGnr1("Social Simulation" + newLine + "20 Maret 2020");
                nsaction.setGnr2("Simulation, RPG" + newLine + "26 Februari 2016");
                nsaction.setGnr3("City-Building, Construction and Managment Simulation" + newLine + "10 Maret 2015");
                nsaction.setDnp1("Nintendo EPD" + newLine + "Nintendo Switch");
                nsaction.setDnp2("ConcernedApe" + newLine + "Nintendo Switch, PS VIta-4, PC, Mobile");
                nsaction.setDnp3("Colossal Order" + newLine + "Nintendo Switch, PC, PS4, Xbox One");
                nsaction.setRev1("9/10 GameSpot," + newLine + "90% Metacritic");
                nsaction.setRev2("87% Metacritic");
                nsaction.setRev3("67% Metacritic," + newLine + "8/10 Nintendo Enthusiast");

                game1.Text = nsaction.getNama1();
                game2.Text = nsaction.getNama2();
                game3.Text = nsaction.getNama3();
                gr1.Text = nsaction.getGnr1();
                gr2.Text = nsaction.getGnr2();
                gr3.Text = nsaction.getGnr3();
                dp1.Text = nsaction.getDnp1();
                dp2.Text = nsaction.getDnp2();
                dp3.Text = nsaction.getDnp3();
                r1.Text = nsaction.getRev1();
                r2.Text = nsaction.getRev2();
                r3.Text = nsaction.getRev3();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            namans = selamatdatang.Text;
            f1.Show();
        }

        private void NintendoSwitch_Load(object sender, EventArgs e)
        {
          startup.Play();

          selamatdatang.Text = Form1.nama;
        }
    }
}