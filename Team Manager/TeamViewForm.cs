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

        public TeamViewForm()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialoq(string name, string countrycode)
        {
            labelCountry.Text = name;
            String url = "https://www.countryflags.io/az/flat/64.png";
            var nurl = url.Insert(28, countrycode);
            var newUrl = nurl.Remove(30, 2);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.Load(newUrl);
            return base.ShowDialog();
        }
        private void TeamViewForm_Load(object sender, EventArgs e)
        {
        }
    }
}
