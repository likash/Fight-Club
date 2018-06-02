using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
            
        }

        private void StartGamebtn_Click(object sender, EventArgs e)
        {
            TransferData.Name = EnterName.Text;

            GameForm gameForm = new GameForm();
            Hide();
            gameForm.ShowDialog();
            
        }
    }
}
