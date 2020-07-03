using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_ArcadeBubblePopper
{
    public partial class AddNameForm : Form
    {
        public Player player;
        public AddNameForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            player = new Player();
            player.Name = txtName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
