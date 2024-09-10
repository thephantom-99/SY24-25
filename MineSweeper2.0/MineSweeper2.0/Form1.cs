using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper2._0
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        tile[] tileGrid = new tile[100];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++) 
            {
                btnGrid[i] = (Button)Controls["button" + (i)];
                tileGrid[i] = new tile(btnGrid[i]);
                btnGrid[i].BackColor = Color.Lavender;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            getIndex(sender as Button);
        }
        private Button GetButton(int r, int c)
        {
            return(Button) GetButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal -1;
        }

        private void button0_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Purple;
        }
    }
}
