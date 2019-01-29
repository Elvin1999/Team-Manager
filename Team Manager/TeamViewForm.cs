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
        public DialogResult ShowDialoq(string name, string countrycode, List<string> position)
        {
            //pictureBoxTeam.Image = Properties.Resources.soccer_field_148894_960_720;
            //pictureBoxTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            labelCountry.Text = name;
            String url = "https://www.countryflags.io/az/flat/64.png";
            var nurl = url.Insert(28, countrycode);
            var newUrl = nurl.Remove(30, 2);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.Load(newUrl);
            positions = position;
            PlayerPosControl player1 = new PlayerPosControl();
            player1.Location = new Point(100, 100);
            player1.Name = "Elvin";
            player1.PlayerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.PlayerImage.Image = Properties.Resources._1182156;

            positioncontrol.Add(player1);

            this.Controls.AddRange(positioncontrol.ToArray());
            return base.ShowDialog();
        }
        private void TeamViewForm_Load(object sender, EventArgs e)
        {


        }

        private void pictureBoxFlag_Click(object sender, EventArgs e)
        {
            positioncontrol = new List<PlayerPosControl>();
            PlayerPosControl player1 = new PlayerPosControl();
            player1.Location = new Point(150, 50);
            player1.Name = "Elvin";
            player1.PlayerImage = new PictureBox();
            player1.PlayerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.PlayerImage.Image = Properties.Resources._1182156;

            positioncontrol.Add(player1);

            this.Controls.AddRange(positioncontrol.ToArray());
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
