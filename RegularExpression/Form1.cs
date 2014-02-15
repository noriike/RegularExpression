using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// マッチング
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MatchCollection mc = Regex.Matches(txtSource.Text, txtMeta.Text);
           
            if (mc.Count > 0)
            {
                foreach (var s in mc)
                {
                    int st=txtSource.Find(s.ToString().ToArray(),0,txtSource.TextLength);
                    if (st != -1)
                    {
                        int l = s.ToString().Length;
                        txtSource.SelectionStart = st;
                        txtSource.SelectionLength = l;
                        //txtSource.SelectionColor = Color.Red;
                        txtSource.SelectionBackColor = Color.Red;
                    }
                   
                }
            }
            else
            {
                txtMatch.Text = "マッチしませんでした";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
