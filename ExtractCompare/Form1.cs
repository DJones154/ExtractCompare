using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ExtractCompare
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

        private void vFy_Click(object sender, EventArgs e)
        {
            //change parameters as needed for testing
                        
                        string pBox = Pathbox.Text;
                        string mfgBox = mfgCode.Text;
                        string zipPathraw = @"" + pBox;
                        string zipPath = zipPathraw.Replace('"', ' ').Trim();
                        string extractPath = Path.GetDirectoryName(pBox);
                        string finalPath = extractPath + "\\TMP\\";
                        string searchPattern = "*.*";
                        string prodImages = @"F:\TESTENV\compare";

                        DataTable FilesTable = new DataTable();
                        DataTable FilesTable2 = new DataTable();
                        DataRow dRow;
                        DataRow dRow2;

                        FilesTable.Clear();
                        FilesTable2.Clear();

                        resultBox.Items.Clear();
                        uzipBox.Items.Clear();
                        existBox.Items.Clear();
                        label4.Text = null;
                        label5.Text = null;
                        label6.Text = null;

                        label4.Text = finalPath;

                        FilesTable.Columns.Add("FileName");
                        FilesTable2.Columns.Add("FileName");

            try
            {

                ZipFile.ExtractToDirectory(zipPath, finalPath);

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }

            try
            {

                var resultData2 = Directory.GetFiles(finalPath, searchPattern, SearchOption.AllDirectories)
                .Select(x => new { FileName2 = Path.GetFileName(x) });

                    if (!Directory.Exists(extractPath + "\\" + mfgBox))
                    {
                        Directory.CreateDirectory(extractPath + "\\" + mfgBox);
                    }


                foreach (var item2 in resultData2)
                {
                    
                    dRow = FilesTable2.NewRow();
                    dRow["FileName"] = item2.FileName2;
                    FilesTable2.Rows.Add(dRow);

                    File.Move(finalPath+item2.FileName2, extractPath+"\\"+mfgBox+"\\"+item2.FileName2
                            .Replace(".jpeg", ".jpg")
                            .Replace(".bmp", ".jpg")
                            .Replace(".png", ".jpg")
                            .Replace(".webp", ".jpg")
                            .Replace(".tiff", ".jpg")
                            .Replace(".tif", ".jpg")
                            .Replace(".gif", ".jpg")
                            .Replace(".exe", ".jpg")
                            .Replace(" ", "")
                            .Trim());

                }


                progressBar1.Maximum = FilesTable2.Rows.Count;

                int i = 0;

                    foreach (var item2 in resultData2)
                    {
                        i++;

                        string rep = item2.FileName2
                            .Replace(".jpeg", ".jpg")
                            .Replace(".bmp", ".jpg")
                            .Replace(".png", ".jpg")
                            .Replace(".webp", ".jpg")
                            .Replace(".tiff", ".jpg")
                            .Replace(".tif", ".jpg")
                            .Replace(".gif", ".jpg")
                            .Replace(".exe", ".jpg")
                            .Replace(" ", "")
                            .Trim();

                        uzipBox.Items.Add(rep);

                        progressBar1.Value = i;
                    }



            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            label5.Text = uzipBox.Items.Count.ToString();

            try
            {

                var resultData = Directory.GetFiles(prodImages, searchPattern, SearchOption.AllDirectories)
                 .Select(x => new { FileName = Path.GetFileName(x) });

                    foreach (var item in resultData)
                    {
                   
                        dRow2 = FilesTable.NewRow();
                        dRow2["FileName"] = item.FileName;
                        FilesTable.Rows.Add(dRow2);                  
                   
                    }

                 progressBar2.Maximum = FilesTable.Rows.Count;

                    int i = 0;

                    foreach (var item in resultData)
                    {

                        i++;

                        existBox.Items.Add(item.FileName);

                      
                            if (dupClean.Checked == true)
                            {
                               File.Delete(Path.Combine(extractPath + "\\" + mfgBox + "\\", item.FileName));
                            }

                        progressBar2.Value = i;

                    }

                 label6.Text = existBox.Items.Count.ToString();

                progressBar3.Maximum = existBox.Items.Count;

                    int i2 = 0;

                    foreach (var dupe in uzipBox.Items)
                    {
                        i2++;

                        if (existBox.Items.Contains(dupe))
                            resultBox.Items.Add("Duplicate: " + dupe);

                        progressBar3.Value = i2;
                    }

                    if (resultBox.Items.Count == 0)
                    {
                        resultBox.Items.Add("No Duplicates Detected!");
                    }

                    if (Directory.Exists(finalPath))
                    {
                        Directory.Delete(finalPath);
                    }
               

                resultBox.Items.Add("Process Complete...");

                progressBar3.Value = existBox.Items.Count;

            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)

        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Pathbox.Text = openFileDialog1.FileName;
            }

        }

    }
}
