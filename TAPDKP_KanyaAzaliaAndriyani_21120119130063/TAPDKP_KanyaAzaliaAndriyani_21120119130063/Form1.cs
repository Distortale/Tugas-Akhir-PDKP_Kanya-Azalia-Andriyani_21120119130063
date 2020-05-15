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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startup = new System.Media.SoundPlayer();

        public static string nama = "";

        public Form1()
        {
            InitializeComponent();

            startup.SoundLocation = "IwatodaiDorm.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namauser.Text != "" && namauser.Text != "Tolong ini diisi!")
            {
                if (platform.Text == "Nintendo Switch")
                {
                    this.Hide();
                    NintendoSwitch ns = new NintendoSwitch();
                    nama = namauser.Text;
                    ns.Show();
                }
                if (platform.Text == "PS4")
                {
                    this.Hide();
                    PS4 ps = new PS4();
                    nama = namauser.Text;
                    ps.Show();
                }
                if (platform.Text == "PC")
                {
                    this.Hide();
                    PC pc = new PC();
                    nama = namauser.Text;
                    pc.Show();
                }
            }
            else
            {
                namauser.Text = "Tolong ini diisi!";
            }
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void platform_SelectedIndexChanged(object sender, EventArgs e)
        {
            platform.Text = platform.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startup.Play();

            namauser.Text = NintendoSwitch.namans;
            namauser.Text = PS4.namaps;
            namauser.Text = PC.namapc;
        }

        private void namauser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
