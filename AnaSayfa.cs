using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace KarakterDonusum
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Fn.TextBDeg(tbChar, tbAsciiCode);
            wordPickerReset();
            tabMain.SelectedIndex = 1;
            rdDirectory.Select();
            Control.CheckForIllegalCrossThreadCalls = false;
            t1 = new Thread(new ThreadStart(wordPickerLabelSet));
        }

        private Thread t1;
        bool Source = false, Target = false;
        bool sourceDirectory;
        string srcLocation, trgtLocation;

        private void tbAsciiCode_Click(object sender, EventArgs e)
        {// tbAsciiCode
            Fn.TextBDeg(tbChar, tbAsciiCode);
        }

        private void tbChar_Click(object sender, EventArgs e)
        {// tbChar
            Fn.TextBDeg(tbAsciiCode, tbChar);
        }

        private void tbAsciiCode_KeyDown(object sender, KeyEventArgs e)
        {
            tbChar.Text = Convert.ToString((char)Convert.ToDouble(0 + tbAsciiCode.Text));
        }

        private void tbChar_KeyDown(object sender, KeyEventArgs e)
        {

            tbAsciiCode.Text = "";
            tbChar.Text = "";
            int ascii = e.KeyValue;
            tbAsciiCode.Text = Convert.ToString(ascii);
        }

        private void textBGirdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBSyc.Text = Convert.ToString(textBGirdi.TextLength);
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordPickerReset();
        }

        enum Lbl
        {
            Source, Target, Highlight, Status
        }

        private void wordPickerReset()
        {
            for (int i = 0; i < 4; i++)
                wordPickerLabelSet((Lbl)i, false, "", -1, -1, -1);
        }

        private void wordPickerLabelSet(Lbl label, bool status, string folderName, int stringLength, int counter, int length)
        {
            switch (label)
            {
                case Lbl.Source:
                    if (status){
                        lblSource.Text = $"Kaynak dosya: {folderName}";
                        lblSource.ForeColor = Color.Lime;
                    } else {
                        lblSource.Text = "Kaynak dosya: Seçilmedi";
                        lblSource.ForeColor = Color.Crimson;
                    }
                    break;
                case Lbl.Target:
                    if (status){
                        lblTarget.Text = $"Hedef dosya: {folderName}";
                        lblTarget.ForeColor = Color.Lime;
                    } else {
                        lblTarget.Text = "Hedef dosya: Seçilmedi";
                        lblTarget.ForeColor = Color.Crimson;
                    }
                    break;
                case Lbl.Highlight:
                    if (status){
                        lblHighlight.Text = $"{stringLength}";
                        lblHighlight.ForeColor = Color.Lime;
                    } else {
                        lblHighlight.Text = "X";
                        lblHighlight.ForeColor = Color.Crimson;
                    }
                    break;
                case Lbl.Status:
                    if (status)
                    {
                        lblStatus.Text = $"{counter} / {length} kelime kaldı";
                        lblStatus.ForeColor = Color.Lime;
                    } else {
                        lblStatus.Text = "Program başlatılmadı";
                        lblStatus.ForeColor = Color.Crimson;
                    }
                    break;
            }
        }

        private void wordPickerLabelSet()
        {
            lblStatus.ForeColor = Color.Lime;
            while (true)
            {
                Console.WriteLine("wordPickerLabelSet method is alive ;)");
                lblStatus.Text = $"{globalCount} / {globalWordsLength} kelime kaldı";
            }
        }

        private void trueFileRW()
        {// if sourceDirectory ture [folder selected] then this method works, and read line by line source text file and selected word length if match then write target file line by line
            foreach (string item in clbSources.Items)
            {
                //MessageBox.Show($"{item}");
                wordPickerLabelSet(Lbl.Highlight, true, "", Convert.ToInt32(mtbCharValue.Text), -1, -1);
                StreamReader sr = new StreamReader(item);
                StreamWriter sw = new StreamWriter(trgtLocation, true);
                string word;
                string[] words = File.ReadAllLines(item);
                int count = 0;

                pbWordProg.Step = 1;
                pbWordProg.Maximum = words.Length;
                globalWordsLength = words.Length;
                while ((word = sr.ReadLine()) != null)
                {
                    //MessageBox.Show($"Kelime : '{word}'\nKelime uzunluğu : {word.Length}", $"Dosyada {words.Length} adet kelime var");

                    string result = word.Trim();
                    result = Regex.Replace(result, @"\s", "");

                    if (result.Length == Convert.ToInt32(mtbCharValue.Text))
                        sw.WriteLine(result);
                    //++globalCount;
                    this.Invoke(new Action(() => {
                        wordPickerLabelSet(Lbl.Status, true, "", -1, ++count, words.Length);
                        pbWordProg.Value = count;
                    }));
                }
                sw.Close();
                sr.Close();
            }
        }

        int globalCount = 0, globalWordsLength = 0;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if(Source && Target && mtbCharValue.Text != "") 
            {
                //FileStream fsRead = new FileStream(srcLocation, FileMode.Open);
                //FileStream fsWrite = new FileStream(trgtLocation, FileMode.Open);
                if (sourceDirectory) 
                {// if source directory is a folder then if will be true
                    if (!t1.IsAlive)
                    {
                        await Task.Run(() => trueFileRW());
                    }
                } 
                else 
                {
                    wordPickerLabelSet(Lbl.Highlight, true, "", Convert.ToInt32(mtbCharValue.Text), -1, -1);
                    StreamReader sr = new StreamReader(srcLocation);
                    StreamWriter sw = new StreamWriter(trgtLocation, true);

                    string word;
                    string[] words = File.ReadAllLines(srcLocation);
                    int count = 0;
                    pbWordProg.Step = 1;
                    pbWordProg.Maximum = words.Length;
                    while ((word = sr.ReadLine()) != null)
                    {
                        //MessageBox.Show($"Kelime : '{word}'\nKelime uzunluğu : {word.Length}", $"Dosyada {words.Length} adet kelime var");
                        string result = word.Trim();
                        if (result.Length == Convert.ToInt32(mtbCharValue.Text))
                            sw.WriteLine(result);

                        wordPickerLabelSet(Lbl.Status, true, "", -1, ++count, words.Length);
                        pbWordProg.Value = count;
                    }
                    sw.Close();
                    sr.Close();
                }
                //MessageBox.Show($"Kaynak : {srcLocation}\nHedef : {trgtLocation}\nProgram başarılı bir şekilde çalıştı");
            } else {
                if (!Source)
                    MessageBox.Show("Kaynak seçmeden devam edemezsiniz");
                else if(!Target)
                    MessageBox.Show("Hedef seçmeden devam edemezsiniz");
                else
                    MessageBox.Show("Kelime uzunluğu belirlemeden devam edemezsiniz");

            }
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1.IsAlive)
                t1.Abort();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            clbSources.Items.Clear();
            if (sourceDirectory)
            {
                FolderBrowserDialog fdb = new FolderBrowserDialog();
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    clbSources.Items.Clear();
                    clbSources.Items.AddRange(Directory.GetFiles(fdb.SelectedPath));
                    wordPickerLabelSet(Lbl.Source, true, "Çoklu kaynak seçildi", -1, -1, -1);
                    Source = true;
                }
            } else {
                selectFolder(btnSelectSource, null);
            }
        }
        
        private void rdSelector(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;

            if(rd.Name == rdDirectory.Name) {
                btnSelectSource.Text = "Klasör seç";
                sourceDirectory = true;
                Source = false;
                wordPickerLabelSet(Lbl.Source, false, "", -1, -1, -1);
                clbSources.Items.Clear();
            } else {
                btnSelectSource.Text = "dosya seç";
                sourceDirectory = false;
                Source = false;
                wordPickerLabelSet(Lbl.Source, false, "", -1, -1, -1);
                clbSources.Items.Clear();
            }
        }

        private void selectFolder(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            Lbl selectedLabel = Lbl.Highlight;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ofd.Multiselect = false;
            ofd.ShowReadOnly = true;
            ofd.ShowHelp = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fLocation = ofd.FileName;
                string dosyaAdi = fLocation.Substring(fLocation.LastIndexOf('\\') + 1);
                //MessageBox.Show($"{fLocation}");
                //dosyaAdi = dosyaAdi.Remove(dosyaAdi.LastIndexOf('.'));
                if (btn.Name == "btnSelectSource"){
                    selectedLabel = Lbl.Source;
                    srcLocation = fLocation;
                    Source = true;
                } else {
                    selectedLabel = Lbl.Target;
                    trgtLocation = fLocation;
                    Target = true;
                }
                wordPickerLabelSet(selectedLabel, true, $"{dosyaAdi}", -1, -1, -1);
            }
        
        }
    }

}
