using System;
using System.IO;
using System.Windows.Forms;

namespace FilesIOProject
{
    public partial class Form1 : Form
    {

        private string mainPath = @"C:\Users\Sattar\Desktop\Test";

        public Form1()
        {
            InitializeComponent();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Logger.Write("folderBrowserDialog opening", "Success");
            folderBrowserDialog.ShowDialog();

            string selectedPath = folderBrowserDialog.SelectedPath;

            //DirectoryInfo di = new DirectoryInfo(Path.Combine(mainPath, "P210"));
            //di.Create();

            //DirectoryInfo di = new DirectoryInfo(selectedPath);
            //di.Delete(true);

            lbFF.Items.Clear();
            foreach (var item in Directory.GetDirectories(selectedPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                //lbFF.Items.Add(Path.GetDirectoryName(item));
                lbFF.Items.Add(directoryInfo.Name);
            }

            foreach (var item in Directory.GetFiles(selectedPath))
            {
                FileInfo fileInfo = new FileInfo(item);
                lbFF.Items.Add(fileInfo.Name);

            }
            Logger.Write("list box filled", "Success");

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string selected = (string)lbFF.SelectedItem;
            string newFolderName = txtFFName.Text;

            DirectoryInfo directory = new DirectoryInfo(Path.Combine(mainPath, selected, newFolderName));
            directory.Create();

            Logger.Write(newFolderName + " folder created", "Success");

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string selected = (string)lbFF.SelectedItem;
            string newFileName = txtFFName.Text;
            FileInfo file = new FileInfo(Path.Combine(mainPath, selected, newFileName));
            if (File.Exists(file.FullName))
            {
                MessageBox.Show("Bu fayl movcuddur");
                return;
            } 

            file.Create();
        }

       

        private void lbFF_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Logger.Write("Item selected from list", "Success");

            rtbFileContent.Clear();

            string fPath = Path.Combine( mainPath, lbFF.SelectedItem.ToString());

            using (FileStream fileStream = File.Open(fPath, FileMode.Open))
            {
                StreamReader reader = new StreamReader(fileStream);

                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    rtbFileContent.Text += line + "\n";
                }
            }
            

         
        }

        private void btnSaveFileContent_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fPath = saveFileDialog1.FileName;

            FileInfo file = new FileInfo(fPath);

            if (File.Exists(fPath))
            {
                file.Delete();
            }
            else
            {
                Logger.Write("File already exist", "Error");

            }


            using (FileStream fileStream = file.Open(FileMode.OpenOrCreate))
                fileStream.Close();

            using (StreamWriter writer = new StreamWriter(fPath, append:true))
            {
                foreach (var line in rtbFileContent.Lines)
                {
                    writer.WriteLine(line);
                }
            }

            Logger.Write("File content readed", "Success");





        }
    }
}
