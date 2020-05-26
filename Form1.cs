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
                    break;

                case Keys.D2:
                    n2++;
                    button36.PerformClick();
                    label69.Text = n2.ToString();
                     break;

                case Keys.D3:
                        n3++;
                        button37.PerformClick();
                        label70.Text = n3.ToString();
                      break;
                case Keys.D4:
                        n4++;
                        button38.PerformClick();
                        label71.Text = n4.ToString();
                     break;

                case Keys.D5:
                        n5++;
                        button39.PerformClick();
                        label72.Text = n5.ToString();
                     break;
                case Keys.D6:
                        n6++;
                        button40.PerformClick();
                        label73.Text = n6.ToString();
                    break;

                case Keys.D7:
                        n7++;
                        button41.PerformClick();
                        label74.Text = n7.ToString();
                    break;

                case Keys.D8:
                        n8++;
                        button42.PerformClick();
                        label75.Text = n8.ToString();
                    break;

                case Keys.D9:
                        n9++;
                        button43.PerformClick();
                        label76.Text = n9.ToString();
                    break;

                case Keys.D0:
                        n0++;
                        button44.PerformClick();
                        label77.Text = n0.ToString();
                    break;

                case Keys.Q:
                        KQ++;
                        button1.PerformClick();
                        label44.Text = KQ.ToString();
                    break;
                    
                case (Keys.Q | Keys.Shift):
                    KQ++;
                    button1.PerformClick();
                    label44.Text = KQ.ToString();
                    break;

                case Keys.W:
                        KW++;
                        button2.PerformClick();
                        label45.Text = KW.ToString();
                    break;

                case (Keys.W | Keys.Shift):
                    KW++;
                    button2.PerformClick();
                    label45.Text = KW.ToString();
                    break;

                case Keys.E:
                        KE++;
                        button3.PerformClick();
                        label46.Text = KE.ToString();
                    break;

                case (Keys.E | Keys.Shift):
                    KE++;
                    button3.PerformClick();
                    label46.Text = KE.ToString();
                    break;

                case Keys.R:
                        KR++;
                        button4.PerformClick();
                        label47.Text = KR.ToString();
                    break;

                case (Keys.R | Keys.Shift):
                    KR++;
                    button4.PerformClick();
                    label47.Text = KR.ToString();
                    break;

                case Keys.T:
                        KT++;
                        button5.PerformClick();
                        label48.Text = KT.ToString();
                    break;

                case (Keys.T | Keys.Shift):
                    KT++;
                    button5.PerformClick();
                    label48.Text = KT.ToString();
                    break;

                case Keys.Y:
                        KY++;
                        button6.PerformClick();
                        label49.Text = KY.ToString();
                    break;

                case (Keys.Y | Keys.Shift):
                    KY++;
                    button6.PerformClick();
                    label49.Text = KY.ToString();
                    break;

                case Keys.U:
                        KU++;
                        button7.PerformClick();
                        label50.Text = KU.ToString();
                    break;

                case Keys.I:
                        KI++;
                        button8.PerformClick();
                        label51.Text = KI.ToString();
                    break;

                case Keys.O:
                        KO++;
                        button9.PerformClick();
                        label52.Text = KO.ToString();
                    break;

                case Keys.P:
                        KP++;
                        button10.PerformClick();
                        label53.Text = KP.ToString();
                    break;

                case Keys.A:
                        KA++;
                        button11.PerformClick();
                        label54.Text = KA.ToString();
                    break;

                case Keys.S:
                        KS++;
                        button12.PerformClick();
                        label55.Text = KS.ToString();
                    break;

                case Keys.D:
                        KD++;
                        button13.PerformClick();
                        label56.Text = KD.ToString();
                    break;

                case Keys.F:
                        KF++;
                        button14.PerformClick();
                        label57.Text = KF.ToString();
                    break;

                case Keys.G:
                        KG++;
                        button15.PerformClick();
                        label58.Text = KG.ToString();
                    break;
                    case Keys.H:
                        KH++;
                        button16.PerformClick();
                        label59.Text = KH.ToString();
                    break;
                    case Keys.J:
                    
                        KJ++;
                        button17.PerformClick();
                        label60.Text = KJ.ToString();
                    break;
                    case Keys.K:
                    
                        KK++;
                        button18.PerformClick();
                        label61.Text = KK.ToString();
                    break;
                    case Keys.L:
                    
                        KL++;
                        button19.PerformClick();
                        label78.Text = KL.ToString();
                    break;
                    case Keys.Oemtilde:
                    
                        KÑ++;
                        button20.PerformClick();
                        label79.Text = KÑ.ToString();
                    break;
                    case Keys.Z:
                    
                        KZ++;
                        button21.PerformClick();
                        label80.Text = KZ.ToString();
                    break;
                    case Keys.X:
                    
                        KX++;
                        button22.PerformClick();
                        label81.Text = KX.ToString();
                    break;
                    case Keys.C:
                    
                        KC++;
                        button23.PerformClick();
                        label82.Text = KC.ToString();
                    break;
                    case Keys.V:
                    
                        KV++;
                        button24.PerformClick();
                        label83.Text = KV.ToString();
                    break;
                    case Keys.B:
                    
                        KB++;
                        button25.PerformClick();
                        label84.Text = KB.ToString();
                    break;
                    case Keys.N:
                    
                        KN++;
                        button26.PerformClick();
                        label85.Text = KN.ToString();
                    break;
                    case Keys.M:
                    
                        KM++;
                        button27.PerformClick();
                        label86.Text = KM.ToString();
                    break;
                    case Keys.Space:
                    
                        space++;
                        button48.PerformClick();
                        label65.Text = space.ToString();
                    break;
                    case Keys.Back:
                    
                        backS++;
                        button47.PerformClick();
                        label67.Text = backS.ToString();
                    break;
                    case Keys.Oemcomma:
                    
                        comma++;
                        button28.PerformClick();
                        label62.Text = comma.ToString();
                    break;
                case Keys.OemMinus:
                    
                        dash++;
                        button30.PerformClick();
                        label64.Text = dash.ToString();
                    break;
                    case Keys.OemPeriod:
                    
                        period++;
                        button29.PerformClick();
                        label63.Text = period.ToString();
                    break;
                    case Keys.Enter:
                    
                        enter++;
                        button31.PerformClick();
                        label66.Text = enter.ToString();
                    break;

                case (Keys.U|Keys.Shift):
                    KU++;
                    button7.PerformClick();
                    label50.Text = KU.ToString();
                    break;

                case (Keys.I | Keys.Shift):
                    KI++;
                    button8.PerformClick();
                    label51.Text = KI.ToString();
                    break;

                case (Keys.O | Keys.Shift):
                    KO++;
                    button9.PerformClick();
                    label52.Text = KO.ToString();
                    break;

                case (Keys.P | Keys.Shift):
                    KP++;
                    button10.PerformClick();
                    label53.Text = KP.ToString();
                    break;

                case (Keys.A | Keys.Shift):
                    KA++;
                    button11.PerformClick();
                    label54.Text = KA.ToString();
                    break;

                case (Keys.S | Keys.Shift):
                    KS++;
                    button12.PerformClick();
                    label55.Text = KS.ToString();
                    break;

                case (Keys.D | Keys.Shift):
                    KD++;
                    button13.PerformClick();
                    label56.Text = KD.ToString();
                    break;

                case (Keys.F | Keys.Shift):
                    KF++;
                    button14.PerformClick();
                    label57.Text = KF.ToString();
                    break;

                case (Keys.G | Keys.Shift):
                    KG++;
                    button15.PerformClick();
                    label58.Text = KG.ToString();
                    break;
                case (Keys.H | Keys.Shift):
                    KH++;
                    button16.PerformClick();
                    label59.Text = KH.ToString();
                    break;
                case (Keys.J | Keys.Shift):

                    KJ++;
                    button17.PerformClick();
                    label60.Text = KJ.ToString();
                    break;
                case (Keys.K | Keys.Shift):

                    KK++;
                    button18.PerformClick();
                    label61.Text = KK.ToString();
                    break;
                case (Keys.L | Keys.Shift):

                    KL++;
                    button19.PerformClick();
                    label78.Text = KL.ToString();
                    break;
                
                case (Keys.Z | Keys.Shift):

                    KZ++;
                    button21.PerformClick();
                    label80.Text = KZ.ToString();
                    break;
                case (Keys.X | Keys.Shift):

                    KX++;
                    button22.PerformClick();
                    label81.Text = KX.ToString();
                    break;
                case (Keys.C | Keys.Shift):

                    KC++;
                    button23.PerformClick();
                    label82.Text = KC.ToString();
                    break;
                case (Keys.V | Keys.Shift):

                    KV++;
                    button24.PerformClick();
                    label83.Text = KV.ToString();
                    break;
                case (Keys.B | Keys.Shift):

                    KB++;
                    button25.PerformClick();
                    label84.Text = KB.ToString();
                    break;
                case (Keys.N | Keys.Shift):

                    KN++;
                    button26.PerformClick();
                    label85.Text = KN.ToString();
                    break;
                case (Keys.M | Keys.Shift):

                    KM++;
                    button27.PerformClick();
                    label86.Text = KM.ToString();
                    break;

            }

           

            return base.ProcessCmdKey(ref msg, keyData);

        }


    }
}