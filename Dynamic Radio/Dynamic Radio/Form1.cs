using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Radio
{
    public partial class Form1 : Form
    {
        string btnID = string.Empty;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 81; i++)
            {
                string radio = "radioButton" + i;

                var checkboxControl = Controls.Find(radio, true).FirstOrDefault() as RadioButton;
                checkboxControl.Visible = false;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= 81; j++)
            {
                string radio = "radioButton" + j;

                var checkboxControl = Controls.Find(radio, true).FirstOrDefault() as RadioButton;
                checkboxControl.Visible = false;
            }


            int rows = Convert.ToInt16(txtRow.Text);
            int columns = Convert.ToInt16(txtColumn.Text);
            int[] limit=new int [rows];
            int start = 0;
            for(int i=1;i<=rows;i++)
            {
                limit[i-1]=start+1;
                start = (i*9);
            }

            Generate(limit,columns);
        }
        public void Generate(int [] val,int col)
        {
            for(int i=0;i<val.Length;i++)
            {
                int value = val[i];
                Gen(value,col);
            }
        }
        public void Gen(int val,int col)
        {
            int v = val;
            for(int i=val;i<val+col;i++)
            {
                string radio1 = "radioButton" + i;
                var checkboxControl1 = Controls.Find(radio1, true).FirstOrDefault() as RadioButton;
                checkboxControl1.Visible = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A4";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A5";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A6";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A7";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A8";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "A9";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B1";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B2";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B3";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B4";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B5";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B6";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B7";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B8";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "B9";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C1";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C2";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C3";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C4";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C5";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C6";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C7";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C8";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "C9";
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D1";
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D2";
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D3";
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D4";
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D5";
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D6";
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D7";
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D8";
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "D9";
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E1";
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E2";
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E3";
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E4";
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E5";
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E6";
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E7";
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E8";
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "E9";
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F1";
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F2";
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F3";
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F4";
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F5";
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F6";
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F7";
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F8";

        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "F9";
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G1";
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G2";

        }

        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G3";
        }

        private void radioButton58_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G4";

        }

        private void radioButton59_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G5";
        }

        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G6";
        }

        private void radioButton61_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G7";
        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G8";
        }

        private void radioButton63_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "G9";

        }

        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H1";
        }

        private void radioButton65_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H2";
        }

        private void radioButton66_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H3";
        }

        private void radioButton67_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H4";
        }

        private void radioButton68_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H5";
        }

        private void radioButton69_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H6";

        }

        private void radioButton70_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H7";
        }

        private void radioButton71_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H8";

        }

        private void radioButton72_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "H9";
        }

        private void radioButton73_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I1";
        }

        private void radioButton74_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I2";

        }

        private void radioButton75_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I3";
        }

        private void radioButton76_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I4";
        }

        private void radioButton77_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I5";
        }

        private void radioButton78_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I6";

        }

        private void radioButton79_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I7";
        }

        private void radioButton80_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I8";
        }

        private void radioButton81_CheckedChanged(object sender, EventArgs e)
        {
            lblBtnid.Text = "I9";
        }
    }
}








//logic 1


 //for (int j = 1; j <= 81; j++)
 //           {
 //               string radio = "radioButton" + j;

 //               var checkboxControl = Controls.Find(radio, true).FirstOrDefault() as RadioButton;
 //               checkboxControl.Visible = false;
 //           }
 //           int rows = Convert.ToInt16(txtRow.Text);
 //           int columns = Convert.ToInt16(txtColumn.Text);
 //           int tot=rows*columns;
 //           int rem =Math.Abs(columns - 9);
 //           int k = 1;
 //           int[] limit=new int [columns];
 //           int column=columns;
 //           for(int i=0;i<columns;i++)
 //           {
 //               limit[i]=column;
 //               column = column + 9;

 //           }
 //           Generate(limit);
 //       }
 //       public void Generate(int [] val)
 //       {
 //           for(int i=0;i<val.Length;i++)
 //           {
 //               int value = val[i];
 //               Gen(value,val.Length);
 //           }
 //       }
 //       public void Gen(int val,int col)
 //       {
 //           int v = val;
 //           for(int i=v-col+1;i<=v;i++)
 //           {
 //               string radio1 = "radioButton" + i;
 //               var checkboxControl1 = Controls.Find(radio1, false).FirstOrDefault() as RadioButton;
 //               checkboxControl1.Visible = true;
 //           }
 //       }