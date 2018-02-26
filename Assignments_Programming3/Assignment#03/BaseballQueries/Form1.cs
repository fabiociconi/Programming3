using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BaseballDataModel;

namespace BaseballQueries
{
    public partial class Form1 : Form
    {
        private BaseballEntities dbcontext = new BaseballEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.ToList();
        }

        private void playerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (textBoxQuery.Text != "")
            {
                string LastNameQuery = textBoxQuery.Text;

                var LastPlayers = from Player in dbcontext.Players
                                  orderby Player.LastName
                                  where Player.LastName == LastNameQuery
                                  select Player;
                playerBindingSource.DataSource = LastPlayers.ToList();
                label1.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var players = from Player in dbcontext.Players
                          orderby Player.PlayerID
                          select Player;

            playerBindingSource.DataSource = players.ToList();

        }
    }
}
