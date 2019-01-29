using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Team_Manager
{
    public partial class TeamViewForm : Form
    {

        List<string> positions = new List<string>();
        List<PlayerPosControl> positioncontrol = new List<PlayerPosControl>();
        public TeamViewForm()
        {
            InitializeComponent();
        }
        List<PlayerControl> players = new List<PlayerControl>();
        public DialogResult ShowDialoq(string name, string countrycode, List<string> position, List<PlayerControl> players)
        {
            //pictureBoxTeam.Image = Properties.Resources.soccer_field_148894_960_720;
            //pictureBoxTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            labelCountry.Text = name;
            String url = "https://www.countryflags.io/az/flat/64.png";
            var nurl = url.Insert(28, countrycode);
            var newUrl = nurl.Remove(30, 2);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.Load(newUrl);
            positions = position; int f = 0, dd = 0, md = 0;
            foreach (var item in position)
            {
                if (item == "F")
                {
                    ++f;
                }
                else if (item == "MD")
                {
                    ++md;
                }
                else if (item == "DD")
                {
                    ++dd;
                }
            }
            int x = 0, xd = 0, xmd = 0;
            if (f == 3)
            {
                x = 115; xmd = 115; xd = 100;
            }
            else if (f == 2)
            {
                x = 150; xmd = 88; xd = 88;
            }
            if (dd == 5)
            {
                x = 150; xmd = 110; xd = 78;
            }
            for (int i = 0; i < 11; i++)
            {
                PlayerPosControl player1 = new PlayerPosControl();
                if (positions[i] == "F")
                {

                    player1.Location = new Point(x * (i + 1), 100);
                }
                else if (positions[i] == "DD")
                {
                    if (dd == 5)
                    {
                        i -= 5;
                     
                        player1.Location = new Point(xd * (i + 1), 450);
                        i += 5;
                    }
                    else
                    {
                        i -= 6;
        
                        player1.Location = new Point(xd * (i + 1), 450);
                        i += 6;
                    }

                }
                else if (positions[i] == "MD")
                {
                    if (f == 2)
                    {
                        i -= 2;
                        player1.Location = new Point(xmd * (i + 1), 300);
                        i += 2;
                    }
                    else
                    {
                        i -= 3;
                        player1.Location = new Point(xmd * (i + 1), 300);
                        i += 3;
                    }

                }
                else if (positions[i] == "GK")
                {
                    player1.Location = new Point(230, 550);
                }
                player1.Name = players[i].Name;
       
                player1.PlayerImage.SizeMode = PictureBoxSizeMode.StretchImage;
                player1.PlayerImage.Image = Properties.Resources.t_shirt;
                positioncontrol.Add(player1);
            }


            this.Controls.AddRange(positioncontrol.ToArray());
            return base.ShowDialog();
        }
        private void TeamViewForm_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pictureBoxFlag_Click_1(object sender, EventArgs e)
        {

        }
    }
}
