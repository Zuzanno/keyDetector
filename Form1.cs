﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyDetector
{
    public partial class KeyMapper : Form
    {
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
                    //button35.Focus();
                    label68.Text = n1.ToString();
                    break;

                case Keys.D2:
                    n2++;
                    button36.PerformClick();
                    //button36.Focus();
                    label69.Text = n2.ToString();
                     break;

                case Keys.D3:
                        n3++;
                        button37.PerformClick();
                       // button37.Focus();
                        label70.Text = n3.ToString();
                      break;
                case Keys.D4:
                        n4++;
                        button38.PerformClick();
                       // button38.Focus();
                        label71.Text = n4.ToString();
                     break;

                case Keys.D5:
                        n5++;
                        button39.PerformClick();
                      //  button39.Focus();
                        label72.Text = n5.ToString();
                     break;
                case Keys.D6:
                        n6++;
                        button40.PerformClick();
                       // button40.Focus();
                        label73.Text = n6.ToString();
                    break;

                case Keys.D7:
                        n7++;
                        button41.PerformClick();
                       // button41.Focus();
                        label74.Text = n7.ToString();
                    break;

                case Keys.D8:
                        n8++;
                        button42.PerformClick();
                       // button42.Focus();
                        label75.Text = n8.ToString();
                    break;

                case Keys.D9:
                        n9++;
                        button43.PerformClick();
                       // button43.Focus();
                        label76.Text = n9.ToString();
                    break;

                case Keys.D0:
                        n0++;
                        button44.PerformClick();
                       // button44.Focus();
                        label77.Text = n0.ToString();
                    break;

                case Keys.Q:
                        KQ++;
                        button1.PerformClick();
                      //  button1.Focus();
                        label44.Text = KQ.ToString();
                    break;

                case Keys.W:
                        KW++;
                        button2.PerformClick();
                      //  button2.Focus();
                        label45.Text = KW.ToString();
                    break;

                case Keys.E:
                        KE++;
                        button3.PerformClick();
                      //  button3.Focus();
                        label46.Text = KE.ToString();
                    break;

                case Keys.R:
                        KR++;
                        button4.PerformClick();
                      //  button4.Focus();
                        label47.Text = KR.ToString();
                    break;

                case Keys.T:
                        KT++;
                        button5.PerformClick();
                      //  button5.Focus();
                        label48.Text = KT.ToString();
                    break;

                case Keys.Y:
                        KY++;
                        button6.PerformClick();
                      //  button6.Focus();
                        label49.Text = KY.ToString();
                    break;

                case Keys.U:
                        KU++;
                        button7.PerformClick();
                     //   button7.Focus();
                        label50.Text = KU.ToString();
                    break;

                case Keys.I:
                        KI++;
                        button8.PerformClick();
                      //  button8.Focus();
                        label51.Text = KI.ToString();
                    break;

                case Keys.O:
                        KO++;
                        button9.PerformClick();
                     //   button9.Focus();
                        label52.Text = KO.ToString();
                    break;

                case Keys.P:
                        KP++;
                        button10.PerformClick();
                     //   button10.Focus();
                        label53.Text = KP.ToString();
                    break;

                case Keys.A:
                        KA++;
                        button11.PerformClick();
                     //   button11.Focus();
                        label54.Text = KA.ToString();
                    break;

                case Keys.S:
                        KS++;
                        button12.PerformClick();
                    //    button12.Focus();
                        label55.Text = KS.ToString();
                    break;

                case Keys.D:
                        KD++;
                        button13.PerformClick();
                     //   button13.Focus();
                        label56.Text = KD.ToString();
                    break;

                case Keys.F:
                        KF++;
                        button14.PerformClick();
                     //   button14.Focus();
                        label57.Text = KF.ToString();
                    break;

                case Keys.G:
                        KG++;
                        button15.PerformClick();
                    //    button15.Focus();
                        label58.Text = KG.ToString();
                    break;
                    case Keys.H:
                        KH++;
                        button16.PerformClick();
                    //    button16.Focus();
                        label59.Text = KH.ToString();
                    break;
                    case Keys.J:
                    
                        KJ++;
                        button17.PerformClick();
                    //    button17.Focus();
                        label60.Text = KJ.ToString();
                    break;
                    case Keys.K:
                    
                        KK++;
                        button18.PerformClick();
                    //    button18.Focus();
                        label61.Text = KK.ToString();
                    break;
                    case Keys.L:
                    
                        KL++;
                        button19.PerformClick();
                    //    button19.Focus();
                        label78.Text = KL.ToString();
                    break;
                    case Keys.Oemtilde:
                    
                        KÑ++;
                        button20.PerformClick();
                   //     button20.Focus();
                        label79.Text = KÑ.ToString();
                    break;
                    case Keys.Z:
                    
                        KZ++;
                        button21.PerformClick();
                    //    button21.Focus();
                        label80.Text = KZ.ToString();
                    break;
                    case Keys.X:
                    
                        KX++;
                        button22.PerformClick();
                    //    button22.Focus();
                        label81.Text = KX.ToString();
                    break;
                    case Keys.C:
                    
                        KC++;
                        button23.PerformClick();
                    //    button23.Focus();
                        label82.Text = KC.ToString();
                    break;
                    case Keys.V:
                    
                        KV++;
                        button24.PerformClick();
                    //    button24.Focus();
                        label83.Text = KV.ToString();
                    break;
                    case Keys.B:
                    
                        KB++;
                        button25.PerformClick();
                    //    button25.Focus();
                        label84.Text = KB.ToString();
                    break;
                    case Keys.N:
                    
                        KN++;
                        button26.PerformClick();
                    //    button26.Focus();
                        label85.Text = KN.ToString();
                    break;
                    case Keys.M:
                    
                        KM++;
                        button27.PerformClick();
                    //    button27.Focus();
                        label86.Text = KM.ToString();
                    break;
                    case Keys.Space:
                    
                        space++;
                        button48.PerformClick();
                    //    button48.Focus();
                        label65.Text = space.ToString();
                    break;
                    case Keys.Back:
                    
                        backS++;
                        button47.PerformClick();
                    //    button47.Focus();
                        label67.Text = backS.ToString();
                    break;
                    case Keys.Oemcomma:
                    
                        comma++;
                        button28.PerformClick();
                    //    button28.Focus();
                        label62.Text = comma.ToString();
                    break;
                case Keys.OemMinus:
                    
                        dash++;
                        button30.PerformClick();
                    //    button30.Focus();
                        label64.Text = dash.ToString();
                    break;
                    case Keys.OemPeriod:
                    
                        period++;
                        button29.PerformClick();
                    //    button29.Focus();
                        label63.Text = period.ToString();
                    break;
                    case Keys.Enter:
                    
                        enter++;
                        button31.PerformClick();
                    //    button31.Focus();
                        label66.Text = enter.ToString();
                    break;

            }

           

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}