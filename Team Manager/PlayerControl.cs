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
    public partial class PlayerControl : UserControl
    {
        public TextBox NameTextbox { get { return textBoxName; } set { textBoxName = value; } }
        public TextBox NumberTextbox { get { return textBoxNumber; } set { textBoxNumber = value; } }
        public string Number { get { return textBoxNumber.Text; } set { textBoxNumber.Text = value; } }
        public string Name { get { return textBoxName.Text; } set { textBoxName.Text = value; } }
        public string Position { get { return textBoxPosition.Text; } set { textBoxPosition.Text = value; } }
        public PlayerControl()
        {
            InitializeComponent();
        }
    }
}
