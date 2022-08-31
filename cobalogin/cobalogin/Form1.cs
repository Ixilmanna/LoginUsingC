using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobalogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textboxUser.Text;
            string password = textboxPass.Text;
            string UserPass = username + password;

            int UsPasLen = UserPass.Length;
            int userlen = username.Length;
            int passlen = username.Length;
            int countpass =0;

            Console.Write("username anda : ");
            for (int i = 0; i < userlen; i++)
            {
                countpass++;
                Console.Write(UserPass [i]);
                
                if (countpass == userlen){
                Console.Write(" Password anda : ");
                    for (int j = countpass; j < (UsPasLen); j++)
                    {
                        Console.Write(UserPass[j]);
                    }
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
