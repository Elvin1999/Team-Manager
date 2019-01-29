using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Manager
{

    public partial class PlayerPosControl : UserControl
    {
        public string Name { get { return labelName.Text; } set { labelName.Text = value; } }
        public PictureBox PlayerImage { get { return picturePlayer; } set { picturePlayer = value; } }
        public PlayerPosControl()
        {
            InitializeComponent();
        }
    }
}
