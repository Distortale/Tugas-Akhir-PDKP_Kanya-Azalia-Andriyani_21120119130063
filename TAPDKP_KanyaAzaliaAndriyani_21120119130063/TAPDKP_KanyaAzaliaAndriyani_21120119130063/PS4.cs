using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPDKP_KanyaAzaliaAndriyani_21120119130063
{
    public partial class PS4 : Form
    {
        System.Media.SoundPlayer startup = new System.Media.SoundPlayer();
        System.Media.SoundPlayer select = new System.Media.SoundPlayer();

        public static string namaps = Form1.nama;

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

        public PS4()
        {
            InitializeComponent();

            startup.SoundLocation = "Playstation Logo.wav";
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
                nsaction.setNama1("Monster Hunter World");
                nsaction.setNama2("Bloodborne");
                nsaction.setNama3("Nier: Automata");
                nsaction.setGnr1("Action-RPG" + newLine + "26 Januari 2018");
                nsaction.setGnr2("Action-RPG" + newLine + "24 Maret 2015");
                nsaction.setGnr3("Action-RPG" + newLine + "7 Maret 2017");
                nsaction.setDnp1("Capcom" + newLine + "PS4, PC, Xbox One");
                nsaction.setDnp2("FromSoftware" + newLine + "PS4");
                nsaction.setDnp3("Platinum Games" + newLine + "PS4, PC, Xbox One");
                nsaction.setRev1("90% Metacritic," + newLine + "9/10 GameSpot");
                nsaction.setRev2("92% Metacritic," + newLine + "9/10 GameSpot");
                nsaction.setRev3("88% Metacritic," + newLine + "9/10 GameSpot");

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
                nsaction.setNama1("Persona 5");
                nsaction.setNama2("Dragon Age: Inquisition");
                nsaction.setNama3("Final Fantasy VII Remake");
                nsaction.setGnr1("RPG, Social Simulation" + newLine + "15 September 2016");
                nsaction.setGnr2("Action-RPG" + newLine + "18 November 2014");
                nsaction.setGnr3("Action-RPG" + newLine + "10 April 2020");
                nsaction.setDnp1("P-Studio" + newLine + "PS3-4");
                nsaction.setDnp2("BioWare" + newLine + "PS3-4, PC, Xbox 360-One");
                nsaction.setDnp3("Square Enix Business Division 1" + newLine + "PS4");
                nsaction.setRev1("95% Metacritic," + newLine + "9.7/10 IGN.com");
                nsaction.setRev2("85% Metacritic," + newLine + "9/10 GameSpot");
                nsaction.setRev3("10/10 Gamespot," + newLine + "88% Metacritic");

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
                nsaction.setNama1("The Sims 4");
                nsaction.setNama2("Overcooked 2");
                nsaction.setNama3("Goat Simulator");
                nsaction.setGnr1("Simulation" + newLine + "2 September 2014");
                nsaction.setGnr2("Simulation" + newLine + "7 Agustus 2018");
                nsaction.setGnr3("Action-Simulation" + newLine + "1 April 2014");
                nsaction.setDnp1("Maxis" + newLine + "PS4, PC, Xbox One");
                nsaction.setDnp2("Team 17 & Ghost Town Games" + newLine + "PS4, Nintendo Switch, PC, Xbox One");
                nsaction.setDnp3("Coffee Stain Studio" + newLine + "PS3-4, PC, Mobile, Xbox 360-One, Nintendo Switch");
                nsaction.setRev1("70% Metacritic");
                nsaction.setRev2("81% Metacritic, 4/5 GameRadar");
                nsaction.setRev3("6/10 Push Square, 30% PC Gamer");

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
            namaps = selamatdatang.Text;
            f1.Show();
        }

        private void PS4_Load(object sender, EventArgs e)
        {
            startup.Play();

            selamatdatang.Text = Form1.nama;

        }
    }
}
