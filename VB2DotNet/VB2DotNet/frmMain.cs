using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace VB2DotNet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadPatternFile();
        }

        public void loadPatternFile()
        {

            string pattern;
            string[] strPattern;
            string fromPattern, toPattern;
            int intPatternCount = 0;

            //Ignore commented lines
            var regex = new Regex("(^$)|(^//)");

            //Create List View Control


            //Locate the pattern file and assign to Stream Reader
            StreamReader srPatFile = new StreamReader(txtSrcFolderName.Text + "\\pattern.txt");

            //Start Reading file
            //Ignore commented lines
            while ((pattern = srPatFile.ReadLine()) != null)
            {
                if (!regex.Match(pattern).Success)
                {
                    intPatternCount++;
                    strPattern = pattern.Split(' ');

                    if(strPattern[1] == "~")
                    {
                        strPattern[1] = " ";
                    }

                    fromPattern = strPattern[0] + strPattern[1] + strPattern[2];
                    toPattern = strPattern[3] + strPattern[1] + strPattern[4];
                    lvwPatterns.Items.Add(new ListViewItem(new string[] { intPatternCount.ToString(), fromPattern, toPattern }, intPatternCount - 1));
                }

            }
        }

        private void butBrowsePatternFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPatternFile = new OpenFileDialog();
            ofdPatternFile.Filter = "Pattern Files|*.txt";
            ofdPatternFile.Title = "Select a Pattern File";

            if (ofdPatternFile.ShowDialog() == DialogResult.OK)
            {
                txtPatternFileName.Text = ofdPatternFile.FileName;
            }
        }

        private void butBrowseSourceFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdBrowseSrc = new FolderBrowserDialog();

            fbdBrowseSrc.ShowNewFolderButton = false;
            if(fbdBrowseSrc.ShowDialog() == DialogResult.OK)
            {
                txtSrcFolderName.Text = fbdBrowseSrc.SelectedPath;
            }
            
        }

        private void butProcess_Click(object sender, EventArgs e)
        {
            string vbLine;
            string outputPath = "\\Output";
            string outputFullPath = txtSrcFolderName.Text + outputPath;
            string outfileName;

            int intCount = 0;
            int fileCount = 0;

            Directory.CreateDirectory(outputFullPath);

            foreach (string fileName in Directory.GetFiles(txtSrcFolderName.Text, "*.vb"))
            {
                outfileName = fileName.Insert(fileName.LastIndexOf("\\"), outputPath);
                fileCount++;
                using (StreamWriter swVBFile = new StreamWriter(outfileName))
                {
                    using (StreamReader srVBFile = new StreamReader(fileName))
                    {
                        while ((vbLine = srVBFile.ReadLine()) != null)
                        {
                            intCount++;
                            vbLine = matchAndReplace(vbLine);
                            swVBFile.WriteLine(vbLine);
                        }

                    }
                }
                lvwProcessedFiles.Items.Add(new ListViewItem(new string[] { fileCount.ToString(), fileName, lblLinesChanged.Text }, intCount - 1));
                lblLinesChanged.Text = "0";
            }
            
        }

        public string matchAndReplace(string subject)
        {
            int intNumberOfPatterns = lvwPatterns.Items.Count;
            string output;

            for (int iteration = 0; iteration < intNumberOfPatterns;iteration++)
            {
                if(Regex.Match(subject, @"\b" + lvwPatterns.Items[iteration].SubItems[1].Text + @"\b").Success)
                {
                    output = Regex.Replace(subject, @"\b" + lvwPatterns.Items[iteration].SubItems[1].Text + @"\b", lvwPatterns.Items[iteration].SubItems[2].Text);
                    subject = output;
                    lblLinesChanged.Text = (Convert.ToInt32(lblLinesChanged.Text) + 1).ToString();
                }

                
            }
            return subject;
        }


        private void butCompareFiles_Click(object sender, EventArgs e)
        {
            compareFiles();
        }

        private void butBrowseCompareFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPatternFile = new OpenFileDialog();
            ofdPatternFile.Filter = "All Files|*.*";
            ofdPatternFile.Title = "Select First File";

            if (ofdPatternFile.ShowDialog() == DialogResult.OK)
            {
                txtCompareFile1.Text = ofdPatternFile.FileName;
            }
        }

        private void butBrowseCompareFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPatternFile = new OpenFileDialog();
            ofdPatternFile.Filter = "All Files|*.*";
            ofdPatternFile.Title = "Select First File";

            if (ofdPatternFile.ShowDialog() == DialogResult.OK)
            {
                txtCompareFile2.Text = ofdPatternFile.FileName;
            }
        }

        private void compareFiles()
        {
            string[] File1Lines = File.ReadAllLines(txtCompareFile1.Text);
            string[] File2Lines = File.ReadAllLines(txtCompareFile2.Text);
            bool matchFound;
            int matchedLineNo;
            int lineNo1, lineNo2;


            //compare file 1 first
            matchedLineNo = 0;
            for (lineNo1 = 0; lineNo1 < File1Lines.Length; lineNo1++)
            {
                matchFound = false;

                for (lineNo2 = matchedLineNo; lineNo2 < File2Lines.Length; lineNo2++)
                {

                    if (String.Compare(File1Lines[lineNo1], File2Lines[lineNo2]) == 0)
                    {
                        matchFound = true;
                        matchedLineNo = lineNo2;
                        break;
                    }

                }
                if (matchFound)
                {
                    lvwFile1.Items.Add(new ListViewItem(new string[] { (lineNo1 + 1).ToString(), File1Lines[lineNo1], (matchedLineNo + 1).ToString() }, lineNo1));
                }
                else
                {
                    lvwFile1.Items.Add(new ListViewItem(new string[] { (lineNo1 + 1).ToString(), File1Lines[lineNo1], "<>" }, lineNo1));
                }

            }


            //compare file 2 next
            matchedLineNo = 0;
            for (lineNo2 = 0; lineNo2 < File2Lines.Length; lineNo2++)
            {
                matchFound = false;
                for (lineNo1 = matchedLineNo; lineNo1 < File1Lines.Length; lineNo1++)
                {

                    if (String.Compare(File2Lines[lineNo2], File1Lines[lineNo1]) == 0)
                    {
                        matchFound = true;
                        matchedLineNo = lineNo1;
                        break;
                    }

                }
                if (matchFound)
                {
                    lvwFile2.Items.Add(new ListViewItem(new string[] { (lineNo2 + 1).ToString(), File2Lines[lineNo2], (matchedLineNo + 1).ToString() }, lineNo2));
                }
                else
                {
                    lvwFile2.Items.Add(new ListViewItem(new string[] { (lineNo2 + 1).ToString(), File2Lines[lineNo2], "<>" }, lineNo2));
                }

            }


        }


        private void lvwFile1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(lvwFile1);
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                CheckAllItems(lvwFile1);
            }
        }


        private void lvwFile2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(lvwFile2);
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                CheckAllItems(lvwFile2);
            }
        }

        public void CopyListBox(ListView list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in list.SelectedItems)
            {
                sb.AppendLine(item.SubItems[0].Text + item.SubItems[1].Text + item.SubItems[2].Text);
            }
            
            Clipboard.SetText(sb.ToString());

        }

        public void CheckAllItems(ListView lvw)
        {
            foreach (ListViewItem item in lvw.Items)
            {
                item.Selected = true;
            }
        }

    }
}
