using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        int lower = 0;
        int hight = 10;
        int triesCount = 5;
        int userNumber;
        Random rand = new Random();
        private void Form1_Activated(object sender, EventArgs e)
        {
            label5.Text = (Convert.ToString(triesCount) + "/5");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            triesCount--;
            label5.Text = (Convert.ToString(triesCount) + "/5");
            number = rand.Next(lower, hight);
            userNumber = Convert.ToInt32(textBox1.Text);
            label5.Visible = true;
            if (triesCount > 0)
            {
                if (number == userNumber)
                {
                    label3.Visible = true;
                    label3.Text = "Победа";
                    button1.Enabled = false;
                }
                else
                    button1.Enabled = true;
               
                
            }
            
            else
            {
                label3.Visible = true;
                button1.Enabled = false;
                label3.Text = "Проигрыш";
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Close();
        }
    }
}
