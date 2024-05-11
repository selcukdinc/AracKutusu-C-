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

    //public class RoundedButton : Button
    //{
    //    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    //    {
    //        float m = 2.75F;
    //        float r2 = radius / 2f;
    //        GraphicsPath GraphPath = new GraphicsPath();

    //        GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
    //        GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
    //        GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
    //                       Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
    //        GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
    //        GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
    //        GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

    //        GraphPath.CloseFigure();
    //        return GraphPath;
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        int borderRadius = 50;
    //        float borderThickness = 1.75f;
    //        base.OnPaint(e);
    //        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
    //        GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

    //        this.Region = new Region(GraphPath);
    //        using (Pen pen = new Pen(Color.Silver, borderThickness))
    //        {
    //            pen.Alignment = PenAlignment.Inset;
    //            e.Graphics.DrawPath(pen, GraphPath);
    //        }
    //    }
    //}
        public partial class AnaSayfa : Form
    {
            

            public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox2, textBox1);
            wordPickerReset();
            tabMain.SelectedIndex = 1;
            rdDirectory.Select();
        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox2, textBox1);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox1, textBox2);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text = Convert.ToString((char)Convert.ToDouble(0 + textBox1.Text));
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            int ascii = e.KeyValue;
            textBox1.Text = Convert.ToString(ascii);
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

        bool Source = false, Target = false;

        //string il;
        //    StreamReader sr = new StreamReader(@".\iller\iller.txt");
        //    try
        //    {
        //        while ((il = sr.ReadLine()) != null)
        //        {
        //            cmbIller.Items.Add(il);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally 
        //    { 
        //        sr.Close(); 
        //    }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(Source && Target && mtbCharValue.Text != "") {
                //FileStream fsRead = new FileStream(srcLocation, FileMode.Open);
                //FileStream fsWrite = new FileStream(trgtLocation, FileMode.Open);
                if (sourceDirectory) {
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
                        while ((word = sr.ReadLine()) != null)
                        {
                            //MessageBox.Show($"Kelime : '{word}'\nKelime uzunluğu : {word.Length}", $"Dosyada {words.Length} adet kelime var");
                            
                            string result = word.Trim();
                            result = Regex.Replace(result, @"\s", "");

                            if (result.Length == Convert.ToInt32(mtbCharValue.Text))
                                sw.WriteLine(result);

                            wordPickerLabelSet(Lbl.Status, true, "", -1, ++count, words.Length);
                            pbWordProg.Value = count;
                        }
                        sw.Close();
                        sr.Close();
                    }
                } else {
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

        string srcLocation, trgtLocation;



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
        //FolderBrowserDialog fdb = new FolderBrowserDialog();
        //if(fdb.ShowDialog() == DialogResult.OK)
        //{
        //    clbSources.Items.Clear();
        //    clbSources.Items.AddRange(Directory.GetFiles(fdb.SelectedPath));

        //}
        bool sourceDirectory;
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
