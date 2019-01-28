using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            metroCmCountry.DataSource = GetCountries();
            List<string> positions = new List<string>()
            {
                "4-4-2","4-3-3","5-3-2"
            };
            metroCbPosition.DataSource = positions.ToArray();
        }
        public List<PlayerControl> players { get; set; }
        private List<string> GetCountries()
        {
            List<string> CulturesInfo = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {

                RegionInfo info = new RegionInfo(culture.LCID);
                if (!CulturesInfo.Contains(info.EnglishName))
                {
                    CulturesInfo.Add(info.EnglishName);
                }
            }
            CulturesInfo.Sort();
            return CulturesInfo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureFlag_Click(object sender, EventArgs e)
        {

        }
        private void metroCmCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> CulturesInfo = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            string countryname = metroCmCountry.SelectedItem.ToString();
            RegionInfo info = new RegionInfo(cultures[0].LCID);
            string countrycode = String.Empty;
            foreach (CultureInfo culture in cultures)
            {
                info = new RegionInfo(culture.LCID);

                //MessageBox.Show(info.Name + info.EnglishName);
                if (countryname == info.EnglishName)
                {
                    countrycode = info.Name;
                }
            }
            String url = "https://www.countryflags.io/az/flat/64.png";
            var nurl = url.Insert(28, countrycode);
            var newUrl = nurl.Remove(30, 2);
            pictureFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFlag.Load(newUrl);
        }
        public string Position { get; set; }
        List<string> position442 = new List<string>() { "GK", "DD", "DD", "DD", "DD", "MD", "MD", "MD", "MD", "F", "F" };
        List<string> position433 = new List<string>() { "GK", "DD", "DD", "DD", "DD", "MD", "MD", "MD", "F", "F", "F" };
        List<string> position532 = new List<string>() { "GK", "DD", "DD", "DD", "DD", "DD", "MD", "MD", "MD", "F", "F" };
        PlayerControl player1 = new PlayerControl();
        public List<string> GeneralPos { get; set; }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Position = metroCbPosition.SelectedItem.ToString();
            if (Position == "4-4-2")
            {
                GeneralPos = position442;
            }
            else if(Position == "4-3-3")
            {
                GeneralPos = position433;
            }
            else if(Position == "5-3-2")
            {
                GeneralPos = position532;

            }
            players = new List<PlayerControl>();
            for (int i = 0; i < 11; i++)
            {
                player1.Position = GeneralPos[i];
                player1.Location = new Point(2, 40 * (i + 1));
                players.Add(player1);
                player1 = new PlayerControl();
            }
            this.Controls.AddRange(players.ToArray());
        }
    }
}
