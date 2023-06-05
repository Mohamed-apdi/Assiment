using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(sizeArray.Text);

                //int value = Convert.ToInt32(valueArray.Text);

                int[] moh = new int[size];

                //moh[value] = value;

                for (int i = 0; i < size; i++)
                {
                    //moh[i] = value + i;
                    moh[i] = int.Parse(valueArray.Text);
                }
                List<int> num = new List<int>();
                for(int m = 0; m < size; m++)
                {
                    for(int j = m + 1; j < size; j++)
                    {
                        if(moh[m] != moh[j])
                        {
                            num.Add(moh[m]);
                            num.Add(moh[j]);
                        }
                    }
                }

                lbl.Text = string.Join(" ,", num);
                //lbl.Text =lbl.Text + " , " + moh.ToString();
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
