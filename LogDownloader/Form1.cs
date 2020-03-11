using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogDownloader
{
    public partial class Form1 : Form
    {
        public Form1() //main program
        {
            InitializeComponent();

            sfBox.DropDownStyle = ComboBoxStyle.DropDownList;
            logtypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            logtypeBox.Text = "All";
            sfBox.Text = "1";
            DisableUI();
            loadingBox.Hide();
        }

        //might be needed
        bool validated = false;
        
        //validate the fields (i.e. make them have something in them)
        //working 11/26/19
        public void ValidateInput()
        {

            bool unameValid = false;
            bool pwordValid = false;
            bool destValid = false;
            bool typeValid = false;
            bool sfValid = false;          

            //tiered if to turn on boxes as they get input
           if (!string.IsNullOrEmpty(userBox.Text))
            {
                unameValid = true;

                if (unameValid == true)
                {
                    passBox.Enabled = true;

                    if (!string.IsNullOrEmpty(passBox.Text))
                    {
                        fileBtn.Enabled = true;

                        if (!string.IsNullOrEmpty(destBox.Text))
                        {
                            logtypeBox.Enabled = true;

                            if (!string.IsNullOrEmpty(logtypeBox.Text))
                            {
                                sfBox.Enabled = true;

                                if (!string.IsNullOrEmpty(logtypeBox.Text))
                                {
                                    validated = true;
                                }
                            }
                            else
                            {
                                sfBox.Enabled = false;
                                submitBtn.Enabled = false;
                            }
                        }
                        else
                        {
                            logtypeBox.Enabled = false;
                            sfBox.Enabled = false;
                            submitBtn.Enabled = false;
                        }
                    }
                    else
                    {
                        fileBtn.Enabled = false;
                        logtypeBox.Enabled = false;
                        sfBox.Enabled = false;
                        submitBtn.Enabled = false;
                    }
                }
                else
                {
                    passBox.Enabled = false;
                    fileBtn.Enabled = false;
                    logtypeBox.Enabled = false;
                    sfBox.Enabled = false;
                    submitBtn.Enabled = false;
                }
            }
            else
            {
                passBox.Enabled = false;
                destBox.Enabled = false;
                fileBtn.Enabled = false;
                logtypeBox.Enabled = false;
                sfBox.Enabled = false;
                submitBtn.Enabled = false;
            }

        } //end ValidateInput()

        //quick and dirty way to disable everything
        //working 11/26/19
        public void DisableUI()
        {
            passBox.Enabled = false;
            destBox.Enabled = false;
            sfBox.Enabled = false;
            logtypeBox.Enabled = false;
            submitBtn.Enabled = false;
        }

        //call a save dialog box and set the file dest box text
        //this will turn on other ui elements and create a save location for log download
        //which can be grabbeed by the download function
        public void SetDestination()
        {
            //make a folder browser dialog item
            using (var fbd = new FolderBrowserDialog())
            {
                //capture result
                DialogResult result = fbd.ShowDialog();

                //if valid
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    destBox.Text = fbd.SelectedPath;
                    submitBtn.Enabled = true;
                }
            } 

        }

        /// <summary>
        /// This sample will download a file on the remote system to your local machine.
        /// </summary>
        public async void DownloadFile()
        {
            string host = "";

            switch(sfBox.Text)
            {
                case "1":
                    host = "";
                    break;
                case "2":
                    host = "";
                    break;
                case "3":
                    host = "";
                    break;
                default:
                    host = "";
                    break;
            }

            string username = userBox.Text;
            string password = passBox.Text;
            string localFileName = System.IO.Path.GetFileName(destBox.Text);
            string remoteFileName = "";

            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();

                using (var file = File.OpenWrite(localFileName))
                {
                    sftp.DownloadFile(remoteFileName, file);
                }

                sftp.Disconnect();
            }
        }

        #region Events
        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void destinationBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void sfBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void logtypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void userBox_EnabledChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void passBox_EnabledChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void destBox_EnabledChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void logtypeBox_EnabledChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void sfBox_EnabledChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            SetDestination();
        }

        private async void submitBtn_ClickAsync(object sender, EventArgs e)
        {
            bool done = false;
            DisableUI();
            loadingBox.Show();

            do
            {
                await Task.Run(() => DownloadFile()).ContinueWith(t => done = true);
            } while (done == false);

            loadingBox.Hide();
        }
        #endregion

    }
}
