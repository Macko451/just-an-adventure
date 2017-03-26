using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace JustAnAdventure
{
    public partial class JustAnAdventure : Form
    {
        private Player player;

        public JustAnAdventure()
        {
            InitializeComponent();

            player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = player.CurrentHitPoints.ToString();
            lblGold.Text = player.Gold.ToString();
            lblExperience.Text = player.ExperiencePoints.ToString();
            lblLevel.Text = player.Level.ToString();
        }

        private void JustAnAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
