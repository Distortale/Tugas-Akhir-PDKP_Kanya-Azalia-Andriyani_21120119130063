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
    public partial class PC : Form
    {
        System.Media.SoundPlayer startup = new System.Media.SoundPlayer();
        System.Media.SoundPlayer select = new System.Media.SoundPlayer();

        public static string namapc = Form1.nama;

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

        public PC()
        {
            InitializeComponent();

            startup.SoundLocation = "Windows 7 Startup.wav";
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
                nsaction.setNama1("Okami");
                nsaction.setNama2("Yakuza 0");
                nsaction.setNama3("Grand Theft Auto V");
                nsaction.setGnr1("Action-Adventure" + newLine + "20 April 2006");
                nsaction.setGnr2("Action-Adventure" + newLine + "1 Agustus 2018");
                nsaction.setGnr3("Action-Adventure" + newLine + "17 September 2013");
                nsaction.setDnp1("Clover Studio" + newLine + "PC, PS4, dan Nintendo Switch");
                nsaction.setDnp2("Ryu Ga Gotoku Studio" + newLine + "PC, PS3-4, Xbox One");
                nsaction.setDnp3("Rockstar North" + newLine + "PC, PS3-4, Xbox 360-One");
                nsaction.setRev1("89% Metacritic," + newLine + "5/5 Game Radar");
                nsaction.setRev2("90% PC Gamer," + newLine + "9/10 Steam");
                nsaction.setRev3("92% PC Gamer," + newLine + "96% Metacritic");

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
                nsaction.setNama1("Zanki Zero: Last Beginning");
                nsaction.setNama2("Disgaea");
                nsaction.setNama3("The Witcher 3: Wild Hunt");
                nsaction.setGnr1("Dungeon Crawler-RPG" + newLine + "9 April 2019");
                nsaction.setGnr2("Tactical-RPG" + newLine + "27 Agustus 2007");
                nsaction.setGnr3("Action-RPG" + newLine + "19 Mei 2015");
                nsaction.setDnp1("Spike Chunsoft" + newLine + "PC, PS Vita-4");
                nsaction.setDnp2("Nippon Ichi Software" + newLine + "PC, PS2-4, Nintendo DS-Switch");
                nsaction.setDnp3("CD Projekt Red" + newLine + "PC, PS4, Nintendo Switch, Xbox One");
                nsaction.setRev1("72% Spike Chunsoft," + newLine + "7/10 Steam");
                nsaction.setRev2("76% Metacritic," + newLine + "9/10 Steam");
                nsaction.setRev3("92% PC Gamer," + newLine + "10/10 Steam");

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
                nsaction.setNama1("My Time at Portia");
                nsaction.setNama2("Two Point Hospital");
                nsaction.setNama3("House Flipper");
                nsaction.setGnr1("Simulation, Action-RPG" + newLine + "15 Januari 2019");
                nsaction.setGnr2("Business Simulation" + newLine + "30 Agustus 2018");
                nsaction.setGnr3("Simulation" + newLine + "17 Mei 2018");
                nsaction.setDnp1("Pathea Games" + newLine + "PC, Nintendo Switch, PS4, Xbox One");
                nsaction.setDnp2("Two Point Studios" + newLine + "PC, PS4, Xbox One, Nintendo Switch");
                nsaction.setDnp3("Empyrean" + newLine + "PC, PS4, Xbox One");
                nsaction.setRev1("4,5/5 GameRadar," + newLine + "7% Metacritic");
                nsaction.setRev2("87% PC Gamer," + newLine + "82% Metacritic");
                nsaction.setRev3("9/10 Steam," + newLine + "7/10 Gamereactor");

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
            namapc = selamatdatang.Text;
            f1.Show();
        }

        private void PC_Load(object sender, EventArgs e)
        {
            startup.Play();

            selamatdatang.Text = Form1.nama;

        }
    }
}
