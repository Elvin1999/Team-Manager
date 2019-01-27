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
            
            
            String url = "https://www.countryflags.io/az/flat/64.png";
            pictureFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFlag.Load(url);
        }
    }
}
