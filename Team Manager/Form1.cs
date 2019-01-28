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
        {//player1.Name = "Elvin";//player1.Number = "7";
            
            PlayerControl player1 = new PlayerControl();            
            player1.Position = "F";           
            player1.Location = new Point(2,40);

            players = new List<PlayerControl>();
            //players.Add(player1); players.Add(player2); players.Add(player3); players.Add(player4); players.Add(player5);
            this.Controls.AddRange(players.ToArray());
        }

        private void pictureFlag_Click(object sender, EventArgs e)
        {

        }
        private void metroCmCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> CulturesInfo = new List<string>();
            //CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //string countryname = metroCmCountry.SelectedItem.ToString();
            //RegionInfo info = new RegionInfo(cultures[0].LCID);
            //string countrycode = String.Empty;
            //foreach (CultureInfo culture in cultures)
            //{
            //    info = new RegionInfo(culture.LCID);

            //    //MessageBox.Show(info.Name + info.EnglishName);
            //    if (countryname == info.EnglishName)
            //    {
            //        countrycode = info.Name;
            //    }
            //}
            //String url = "https://www.countryflags.io/az/flat/64.png";
            //var nurl = url.Insert(28, countrycode);
            //var newUrl = nurl.Remove(30, 2);
            //pictureFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureFlag.Load(newUrl);
        }
    }
}
