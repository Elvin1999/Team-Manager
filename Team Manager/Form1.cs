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
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
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
            CountryName = countryname;
            RegionInfo info = new RegionInfo(cultures[0].LCID);
            string countrycode = String.Empty;
            foreach (CultureInfo culture in cultures)
            {
                info = new RegionInfo(culture.LCID);

                //MessageBox.Show(info.Name + info.EnglishName);
                if (countryname == info.EnglishName)
                {
                    countrycode = info.Name;
                    CountryCode = countrycode;
                }
            }
            
        }
        public string Position { get; set; }
        List<string> position442 = new List<string>() { "F", "F", "MD", "MD", "MD", "MD", "DD", "DD", "DD", "DD", "GK" };
        List<string> position433 = new List<string>() { "F", "F", "F", "MD", "MD","MD","DD", "DD", "DD", "DD","GK"  };
        List<string> position532 = new List<string>() { "F", "F", "MD", "MD", "MD", "DD", "DD", "DD", "DD", "DD", "GK" };
        PlayerControl player1 = new PlayerControl();
        public List<string> GeneralPos { get; set; }
        List<PlayerControl> players = new List<PlayerControl>();

        List<PlayerControl> willdelete = new List<PlayerControl>();
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is PlayerControl pb)
                {
                    willdelete.Add(pb);
                }
            }
            willdelete.ForEach((o) => { o.Dispose(); });
            Position = metroCbPosition.SelectedItem.ToString();
            if (Position == "4-4-2")
            {
                GeneralPos = position442;
            }
            else if (Position == "4-3-3")
            {
                GeneralPos = position433;
            }
            else if (Position == "5-3-2")
            {
                GeneralPos = position532;
            }
            for (int i = 0; i < 11; i++)
            {
                player1.Position = GeneralPos[i];
                player1.Location = new Point(2, 40 * (i + 1));
                players.Add(player1);
                player1 = new PlayerControl();
            }
            this.Controls.AddRange(players.ToArray());
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            TeamViewForm form = new TeamViewForm();
            form.ShowDialoq(CountryName, CountryCode,GeneralPos,players);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
