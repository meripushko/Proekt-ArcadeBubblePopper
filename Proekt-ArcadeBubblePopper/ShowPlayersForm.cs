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
    public partial class ShowPlayersForm : Form
    {
        public List<Player> players;
        public ShowPlayersForm(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            players = players.OrderBy(p => p.Score).ToList();
            players.Reverse();
            lbPlayers.DataSource = players;
        }
    }
}
