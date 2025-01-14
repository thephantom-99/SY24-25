using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        int total = 0;
        List<TextBox> textBoxes = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();

            textBoxes.Add(Bit1);
            textBoxes.Add(Bit2);
            textBoxes.Add(Bit3);
            textBoxes.Add(Bit4);
            textBoxes.Add(Bit5);
            textBoxes.Add(Bit6);
            textBoxes.Add(Bit7);
            textBoxes.Add(Bit8);
        }

        private void Bit_TextChanged(object sender, EventArgs e)
        {
            TextBox tbSender = sender as TextBox;
            if (int.TryParse(tbSender.Text, out int value))
            {
                Clamp(ref value, 0, 1);
                tbSender.Text = value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            var TB = textBoxes.Where(t => t.Text == "1").ToList();

            TB.ForEach(t =>
            {
                int index = int.Parse(t.Name.Remove(0, 3)) - 1;
                total += (int)Math.Pow(2, index);
            });
            label1.Text = total.ToString();
        }

        private int Clamp (ref int value, int min, int max) 
        {
            if (value < min)
                value = min;
            else if (value > max)
                value = max;

            return value;
        }
    }
}
