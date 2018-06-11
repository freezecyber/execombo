using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execombo
{
    public partial class Form1 : Form
    {
        private IEnumerable<string> hsd;
        System.Speech.Synthesis.SpeechSynthesizer say = new System.Speech.Synthesis.SpeechSynthesizer();
        private string setdir;
        private string[] hdf;
        private IEnumerable<string> sdf;
        private IEnumerable<string> ffh;
        private IEnumerable<string> ddv;
        private IEnumerable<string> dvp;
        private IEnumerable<string> dbg;
        private IEnumerable<string> fvgn;
        private IEnumerable<string> dvgf;
        private IEnumerable<string> dfdg;
        private int ikk;

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("execombo.tx"))
            {
                File.WriteAllText("execombo.tx", "");
            }
            if (!File.Exists("execombo2.tx"))
            {
                File.WriteAllText("execombo2.tx", "");
            }
            Application.DoEvents(); Thread.Sleep(0);
            comboBox1.Items.Clear();
            setdir = Directory.GetCurrentDirectory();
            string[] dpf = File.ReadAllLines("execombo2.tx");
           dfdg= dpf.Distinct();
            foreach (string fjf in dfdg)
            {
                try
                {
                    if (fjf.Contains("vshost"))
                    { }
                    else
                    {
                        string dhf = Path.GetPathRoot(fjf);
                        string fhjg = Path.GetFileName(dhf + fjf);
                        comboBox1.Items.Add(dhf + fhjg);
                    }
                }
                catch { }
            }
            Application.DoEvents(); Thread.Sleep(0);
            say.SpeakAsync("it is good all done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sjdf = new FolderBrowserDialog();
            Application.DoEvents();
            sjdf.ShowDialog();
            Application.DoEvents();

            setdir = sjdf.SelectedPath; 
            say.SpeakAsync("all done directory set");
            comboBox1.Items.Clear();

            string[] dpf = File.ReadAllLines("execombo2.tx");
           sdf= dpf.Distinct();
            foreach (string fjf in sdf)
            {
                try
                {
                    if (fjf.Contains("vshost"))
                    {
                    }
                    else
                    {
                        string dhf = Path.GetPathRoot(fjf);
                        string fhjg = Path.GetFileName(dhf + fjf);
                        comboBox1.Items.Add(fhjg);
                    }
                }
                catch { }
            }
            Application.DoEvents(); Thread.Sleep(0);
            say.SpeakAsync("it is good all done");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    hdf = Directory.GetFiles(setdir, "*.exe", SearchOption.AllDirectories);
                }
                else
                {
                    hdf = Directory.GetFiles(setdir, "*.exe");
                }
            }
            catch { }
            say.SpeakAsync("get file");
            foreach (string fhjg in hdf)
            {
                try
                {
                    if (fhjg.Contains("vshost"))
                    {
                    }
                    else
                    {
                        string fht = Path.GetFileName(fhjg);
                        comboBox1.Items.Add(setdir + fht);
                        File.AppendAllText("execombo.tx", fhjg + Environment.NewLine);

                    }
                }
                catch { }
            }
            say.SpeakAsync("file found organize type");
            string[] fhty = File.ReadAllLines("execombo.tx");
          ffh=  fhty.Distinct(); Application.DoEvents(); Thread.Sleep(0);
            foreach (string hdfgf in ffh)
            {
                if (hdfgf.Contains("vshost"))
                {
                }
                else
                {
                    File.AppendAllText("execombo2.tx", hdfgf + Environment.NewLine);
                }
            }
            say.SpeakAsync("all done file set");
            button3_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            string[] dpf = File.ReadAllLines("execombo2.tx");
           ddv= dpf.Distinct();
            foreach (string fjf in ddv)
            {
                try
                {
                    if (fjf.Contains("vshost"))
                    {
                    }
                    else
                    {
                        string hdf = Path.GetPathRoot(fjf);
                        string fhjg = Path.GetFileName(fjf);
                        comboBox1.Items.Add(hdf + fhjg);
                    }
                }
                catch { }
            }
            Application.DoEvents(); Thread.Sleep(0);
            say.SpeakAsync("it is good all done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            say.SpeakAsync("starting");
            Process.Start("execombo2.tx"); Application.DoEvents(); Thread.Sleep(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                say.SpeakAsync("start deleting");
                string[] psnbf = File.ReadAllLines("execombo2.tx");
                Application.DoEvents(); Thread.Sleep(0);
               dvgf= psnbf.Distinct();
                foreach (string dhf in dvgf)
                {
                    string shdf = Path.GetFileName(dhf);
                    if (comboBox1.GetItemText(comboBox1.SelectedItem).Contains(shdf))
                    {
                        try
                        {
                            if (dhf.Contains("vshost"))
                            {
                            }
                            else
                            {
                                string fht = File.ReadAllText("execombo2.tx");

                                string hdgf = fht.Replace(dhf, "");
                                File.WriteAllText("execombo2.tx", hdgf);
                                comboBox1.Items.Remove(comboBox1.GetItemText(comboBox1.SelectedItem));
                                Application.DoEvents(); Thread.Sleep(0);
                            }
                        }
                        catch { }
                    }

                }
                comboBox1.Items.Clear();

                string[] dpf = File.ReadAllLines("execombo2.tx");
               fvgn= dpf.Distinct();
                foreach (string fjf in fvgn)
                {
                    try
                    {
                        if (fjf.Contains("vshost"))
                        {
                        }
                        else
                        {
                            string dhf = Path.GetPathRoot(fjf);
                            string fhjg = Path.GetFileName(dhf + fjf);
                            comboBox1.Items.Add(fhjg);
                        }
                    }
                    catch { }
                }
                Application.DoEvents(); Thread.Sleep(0);
                say.SpeakAsync("it is good all done");
            }
            catch { say.SpeakAsync("error with deleting error"); }
            say.SpeakAsync("finish deleted"); Application.DoEvents(); Thread.Sleep(0);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ikk = 1;
                say.SpeakAsync("ok ouverture");
                string[] pfg = File.ReadAllLines("execombo2.tx");
               dbg=  pfg.Distinct();
                foreach (string dhf in dbg)
                {

                    string shdf = Path.GetFileName(dhf);
                    if (comboBox1.GetItemText(comboBox1.SelectedItem).Contains(shdf))
                    {
                        if (ikk == 1)
                        {
                            if (shdf.Contains("vshost"))
                            {
                            }
                            else
                            {
                                ikk++;
                                say.SpeakAsync("yes");
                                Process.Start(dhf); Application.DoEvents(); Thread.Sleep(0);
                            }
                        }
                    }

                }
                 say.SpeakAsync("it is ouvert");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ikk = 1;

            say.SpeakAsync("ok ouverture");
            string[] pfg = File.ReadAllLines("execombo2.tx");
           dvp= pfg.Distinct();
            foreach (string dhf in dvp)
            {
                string shdf = Path.GetFileName(dhf);
                if (comboBox1.GetItemText(comboBox1.SelectedItem).Contains(shdf))
                {
                    if (ikk == 1)
                        if (dhf.Contains("vshost"))
                        {
                        }
                        else
                        {
                            ikk++;
                            say.SpeakAsync("yes");
                            Process.Start(dhf); Application.DoEvents(); Thread.Sleep(0);
                        }
                }
            }

            
             say.SpeakAsync("it is done ouvert");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText("execombo2.tx", "");
        }
    }
}
