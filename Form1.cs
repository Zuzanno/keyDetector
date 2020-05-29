using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyDetector
{
    public partial class KeyMapper : Form
    {
        public bool keyhold = false;
        public int n1 = 0;
        public int n2 = 0;
        public int n3 = 0;
        public int n4 = 0;
        public int n5 = 0;
        public int n6 = 0;
        public int n7 = 0;
        public int n8 = 0;
        public int n9 = 0;
        public int n0 = 0;
        public int KQ = 0;
        public int KW = 0;
        public int KE = 0;
        public int KR = 0;
        public int KT = 0;
        public int KY = 0;
        public int KU = 0;
        public int KI = 0;
        public int KO = 0;
        public int KP = 0;
        public int KA = 0;
        public int KS = 0;
        public int KD = 0;
        public int KF = 0;
        public int KG = 0;
        public int KH = 0;
        public int KJ = 0;
        public int KK = 0;
        public int KL = 0;
        public int KÑ = 0;
        public int KZ = 0;
        public int KX = 0;
        public int KC = 0;
        public int KV = 0;
        public int KB = 0;
        public int KN = 0;
        public int KM = 0;
        public int comma = 0;
        public int period = 0;
        public int dash = 0;
        public int backS = 0;
        public int enter = 0;
        public int space = 0;



        public KeyMapper()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            TB.Focus();
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData) 
            {
                case Keys.D1:
                    n1++;
                    button35.PerformClick();
                    label68.Text = n1.ToString();
                    button35.Focus();
                    break;

                case Keys.D2:
                    n2++;
                    button36.PerformClick();
                    label69.Text = n2.ToString();
                    button36.Focus();
                     break;

                case Keys.D3:
                        n3++;
                        button37.PerformClick();
                        label70.Text = n3.ToString();
                    button37.Focus();
                      break;
                case Keys.D4:
                        n4++;
                        button38.PerformClick();
                        label71.Text = n4.ToString();
                        button38.Focus();
                     break;

                case Keys.D5:
                        n5++;
                        button39.PerformClick();
                        label72.Text = n5.ToString();
                    button39.Focus();
                     break;
                case Keys.D6:
                        n6++;
                        button40.PerformClick();
                        label73.Text = n6.ToString();
                    button40.Focus();
                    break;

                case Keys.D7:
                        n7++;
                        button41.PerformClick();
                        label74.Text = n7.ToString();
                    button41.Focus();
                    break;

                case Keys.D8:
                        n8++;
                        button42.PerformClick();
                        label75.Text = n8.ToString();
                    button42.Focus();
                    break;

                case Keys.D9:
                        n9++;
                        button43.PerformClick();
                        label76.Text = n9.ToString();
                    button43.Focus();
                    break;

                case Keys.D0:
                        n0++;
                        button44.PerformClick();
                        label77.Text = n0.ToString();
                    button44.Focus();
                    break;

                case Keys.Q:
                        KQ++;
                        button1.PerformClick();
                        label44.Text = KQ.ToString();
                    button1.Focus();
                    break;
                    
                case (Keys.Q | Keys.Shift):
                    KQ++;
                    button1.PerformClick();
                    label44.Text = KQ.ToString();
                    button1.Focus();
                    break;

                case Keys.W:
                        KW++;
                        button2.PerformClick();
                        label45.Text = KW.ToString();
                    button2.Focus();
                    break;

                case (Keys.W | Keys.Shift):
                    KW++;
                    button2.PerformClick();
                    label45.Text = KW.ToString();
                    button2.Focus();
                    break;

                case Keys.E:
                        KE++;
                        button3.PerformClick();
                        label46.Text = KE.ToString();
                    button3.Focus();
                    break;

                case (Keys.E | Keys.Shift):
                    KE++;
                    button3.PerformClick();
                    label46.Text = KE.ToString();
                    button3.Focus();
                    break;

                case Keys.R:
                        KR++;
                        button4.PerformClick();
                        label47.Text = KR.ToString();
                    button4.Focus();
                    break;

                case (Keys.R | Keys.Shift):
                    KR++;
                    button4.PerformClick();
                    label47.Text = KR.ToString();
                    button4.Focus();
                    break;

                case Keys.T:
                        KT++;
                        button5.PerformClick();
                        label48.Text = KT.ToString();
                    button5.Focus();
                    break;

                case (Keys.T | Keys.Shift):
                    KT++;
                    button5.PerformClick();
                    label48.Text = KT.ToString();
                    button5.Focus();
                    break;

                case Keys.Y:
                        KY++;
                        button6.PerformClick();
                        label49.Text = KY.ToString();
                    button6.Focus();
                    break;

                case (Keys.Y | Keys.Shift):
                    KY++;
                    button6.PerformClick();
                    label49.Text = KY.ToString();
                    button6.Focus();
                    break;

                case Keys.U:
                        KU++;
                        button7.PerformClick();
                        label50.Text = KU.ToString();
                    button7.Focus();
                    break;

                case Keys.I:
                        KI++;
                        button8.PerformClick();
                        label51.Text = KI.ToString();
                    button8.Focus();
                    break;

                case Keys.O:
                        KO++;
                        button9.PerformClick();
                        label52.Text = KO.ToString();
                    button9.Focus();
                    break;

                case Keys.P:
                        KP++;
                        button10.PerformClick();
                        label53.Text = KP.ToString();
                    button10.Focus();
                    break;

                case Keys.A:
                        KA++;
                        button11.PerformClick();
                        label54.Text = KA.ToString();
                    button11.Focus();
                    break;

                case Keys.S:
                        KS++;
                        button12.PerformClick();
                        label55.Text = KS.ToString();
                    button12.Focus();
                    break;

                case Keys.D:
                        KD++;
                        button13.PerformClick();
                        label56.Text = KD.ToString();
                    button13.Focus();
                    break;

                case Keys.F:
                        KF++;
                        button14.PerformClick();
                        label57.Text = KF.ToString();
                    button14.Focus();
                    break;

                case Keys.G:
                        KG++;
                        button15.PerformClick();
                        label58.Text = KG.ToString();
                    button15.Focus();
                    break;
                    case Keys.H:
                        KH++;
                        button16.PerformClick();
                        label59.Text = KH.ToString();
                    button16.Focus();
                    break;
                    case Keys.J:
                    
                        KJ++;
                        button17.PerformClick();
                        label60.Text = KJ.ToString();
                    button17.Focus();
                    break;
                    case Keys.K:
                    
                        KK++;
                        button18.PerformClick();
                        label61.Text = KK.ToString();
                    button18.Focus();
                    break;
                    case Keys.L:
                    
                        KL++;
                        button19.PerformClick();
                        label78.Text = KL.ToString();
                    button19.Focus();
                    break;
                    case Keys.Oemtilde:
                    
                        KÑ++;
                        button20.PerformClick();
                        label79.Text = KÑ.ToString();
                    button20.Focus();
                    break;
                    case Keys.Z:
                    
                        KZ++;
                        button21.PerformClick();
                        label80.Text = KZ.ToString();
                    button21.Focus();
                    break;
                    case Keys.X:
                    
                        KX++;
                        button22.PerformClick();
                        label81.Text = KX.ToString();
                    button22.Focus();
                    break;
                    case Keys.C:
                    
                        KC++;
                        button23.PerformClick();
                        label82.Text = KC.ToString();
                    button23.Focus();
                    break;
                    case Keys.V:
                    
                        KV++;
                        button24.PerformClick();
                        label83.Text = KV.ToString();
                    button24.Focus();
                    break;
                    case Keys.B:
                    
                        KB++;
                        button25.PerformClick();
                        label84.Text = KB.ToString();
                    button25.Focus();
                    break;
                    case Keys.N:
                    
                        KN++;
                        button26.PerformClick();
                        label85.Text = KN.ToString();
                    button26.Focus();
                    break;
                    case Keys.M:
                    
                        KM++;
                        button27.PerformClick();
                        label86.Text = KM.ToString();
                    button27.Focus();
                    break;
                    case Keys.Space:
                    
                        space++;
                        button48.PerformClick();
                        label65.Text = space.ToString();
                    button48.Focus();
                    break;
                    case Keys.Back:
                    
                        backS++;
                        button47.PerformClick();
                        label67.Text = backS.ToString();
                    button47.Focus();
                    break;
                    case Keys.Oemcomma:
                    
                        comma++;
                        button28.PerformClick();
                        label62.Text = comma.ToString();
                    button28.Focus();
                    break;
                case Keys.OemMinus:
                    
                        dash++;
                        button30.PerformClick();
                        label64.Text = dash.ToString();
                    button30.Focus();
                    break;
                    case Keys.OemPeriod:
                    
                        period++;
                        button29.PerformClick();
                        label63.Text = period.ToString();
                    button29.Focus();
                    break;
                    case Keys.Enter:
                    
                        enter++;
                        button31.PerformClick();
                        label66.Text = enter.ToString();
                    button31.Focus();
                    break;

                case (Keys.U|Keys.Shift):
                    KU++;
                    button7.PerformClick();
                    label50.Text = KU.ToString();
                    button7.Focus();
                    break;

                case (Keys.I | Keys.Shift):
                    KI++;
                    button8.PerformClick();
                    label51.Text = KI.ToString();
                    button8.Focus();
                    break;

                case (Keys.O | Keys.Shift):
                    KO++;
                    button9.PerformClick();
                    label52.Text = KO.ToString();
                    button9.Focus();
                    break;

                case (Keys.P | Keys.Shift):
                    KP++;
                    button10.PerformClick();
                    label53.Text = KP.ToString();
                    button10.Focus();
                    break;

                case (Keys.A | Keys.Shift):
                    KA++;
                    button11.PerformClick();
                    label54.Text = KA.ToString();
                    button11.Focus();
                    break;

                case (Keys.S | Keys.Shift):
                    KS++;
                    button12.PerformClick();
                    label55.Text = KS.ToString();
                    button12.Focus();
                    break;

                case (Keys.D | Keys.Shift):
                    KD++;
                    button13.PerformClick();
                    label56.Text = KD.ToString();
                    button13.Focus();
                    break;

                case (Keys.F | Keys.Shift):
                    KF++;
                    button14.PerformClick();
                    label57.Text = KF.ToString();
                    button14.Focus();
                    break;

                case (Keys.G | Keys.Shift):
                    KG++;
                    button15.PerformClick();
                    label58.Text = KG.ToString();
                    button15.Focus();
                    break;
                case (Keys.H | Keys.Shift):
                    KH++;
                    button16.PerformClick();
                    label59.Text = KH.ToString();
                    button16.Focus();
                    break;
                case (Keys.J | Keys.Shift):

                    KJ++;
                    button17.PerformClick();
                    label60.Text = KJ.ToString();
                    button17.Focus();
                    break;
                case (Keys.K | Keys.Shift):

                    KK++;
                    button18.PerformClick();
                    label61.Text = KK.ToString();
                    button18.Focus();
                    break;
                case (Keys.L | Keys.Shift):

                    KL++;
                    button19.PerformClick();
                    label78.Text = KL.ToString();
                    button19.Focus();
                    break;
                
                case (Keys.Z | Keys.Shift):

                    KZ++;
                    button21.PerformClick();
                    label80.Text = KZ.ToString();
                    button21.Focus();
                    break;
                case (Keys.X | Keys.Shift):

                    KX++;
                    button22.PerformClick();
                    label81.Text = KX.ToString();
                    button22.Focus();
                    break;
                case (Keys.C | Keys.Shift):

                    KC++;
                    button23.PerformClick();
                    label82.Text = KC.ToString();
                    button23.Focus();
                    break;
                case (Keys.V | Keys.Shift):

                    KV++;
                    button24.PerformClick();
                    label83.Text = KV.ToString();
                    button24.Focus();
                    break;
                case (Keys.B | Keys.Shift):

                    KB++;
                    button25.PerformClick();
                    label84.Text = KB.ToString();
                    button25.Focus();
                    break;
                case (Keys.N | Keys.Shift):

                    KN++;
                    button26.PerformClick();
                    label85.Text = KN.ToString();
                    button26.Focus();
                    break;
                case (Keys.M | Keys.Shift):

                    KM++;
                    button27.PerformClick();
                    label86.Text = KM.ToString();
                    button27.Focus();
                    break;

            }

           

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void button35_KeyDown(object sender, KeyEventArgs e)
        {

         /*   if (e.KeyCode == Keys.D1)
            {
                button35.BackColor = Color.LightGreen;
            }*/
        }

        private void button35_KeyUp(object sender, KeyEventArgs e)
        {
            button35.BackColor = Color.Transparent;
            TB.Focus();
        }

        private void button36_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D2)
            {
                button36.BackColor = Color.LightGreen;
            }
        }

        private void button36_KeyUp(object sender, KeyEventArgs e)
        {
            button35.BackColor = Color.Transparent;
            TB.Focus();
        }

        private void button37_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                button37.BackColor = Color.LightGreen;
            }
        }

        private void button37_KeyUp(object sender, KeyEventArgs e)
        {
            button37.BackColor = Color.Transparent;
            TB.Focus();
        }

        private void button35_Enter(object sender, EventArgs e)
        {
            if (a.KeyCode == Keys.D2)
            {
                button37.BackColor = Color.LightGreen;
            }
        }
    }
}