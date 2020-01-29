using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProj.Classes.Entity;
using FinalProj.Classes;
using FinalProj.Classes.MapSettings;

namespace FinalProj
{
    public partial class BattleWindow : Form
    {
        Penguin penguin;
        Orcas orca;
        public BattleWindow(Penguin penguin , Orcas orca)
        {
            InitializeComponent();
            this.penguin = penguin;
            this.orca = orca;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            this.buttonAttack.Enabled = ! this.buttonAttack.Enabled;
            this.buttonDefend.Enabled = !this.buttonDefend.Enabled;
            penguin.Attack(orca);
            this.listBox1.Items.Add("You've attacked the orca! \n Current enemy's Hp = " + orca.Hitpoint);
            if (!orca.isAlive()) {
                this.Close();
                Map.eData[orca.Rows, orca.Columns] = EntityFactory.CreateWay(new Point (orca.Rows, orca.Columns)); 
            }
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            this.buttonAttack.Enabled = !this.buttonAttack.Enabled;
            this.buttonDefend.Enabled = !this.buttonDefend.Enabled;
            orca.Attack(penguin);
            this.listBox1.Items.Add("Defend yourself! The orca has attacked you! \n Your current Hp = " + penguin.Hitpoint);
            if (penguin.Hitpoint <= 0)
            {
                this.Close();
                MessageBox.Show("Game Over");
            }
        }
    }
}
