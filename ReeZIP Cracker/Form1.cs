using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using System.Threading;

namespace ReeZIP_Cracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenZIP_Click(object sender, EventArgs e)
        {
            ofdZIP.InitialDirectory = Application.StartupPath;
            DialogResult theResult = ofdZIP.ShowDialog();
            if (theResult == DialogResult.OK)
            {
                string thePath = ofdZIP.FileName;
                txtZIP.Text = thePath;
            }
        }

        private void btnOpenDictionary_Click(object sender, EventArgs e)
        {
            ofdDictionary.InitialDirectory = Application.StartupPath;
            DialogResult theResult = ofdDictionary.ShowDialog();
            if (theResult == DialogResult.OK)
            {
                string thePath = ofdDictionary.FileName;
                txtDictionary.Text = thePath;
            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            // Make sure the files exist (They can be entered manually)
            if (!File.Exists(txtZIP.Text))
            {
                MessageBox.Show("ZIP file does not exist!");
                return;
            }

            if (!File.Exists(txtDictionary.Text))
            {
                MessageBox.Show("Dictionary file does not exist!");
                return;
            }

            // Disable the buttons
            btnOpenZIP.Enabled = false;
            btnOpenDictionary.Enabled = false;
            btnGo.Enabled = false;

            // Initialise UI
            txtPassword.Text = "Cracking...";
            txtPassword.Refresh();

            // And go!
            Thread crackingThread = new Thread(doCracking);
            crackingThread.IsBackground = true; // So it closes when the app does
            crackingThread.Start();
        }

        void doCracking()
        {
            DateTime startTime = DateTime.Now;
            string zipPath = txtZIP.Text;
            string dictionaryPath = txtDictionary.Text;
            addListboxItem("Loading Dictionary...");
            List<string> passList = File.ReadLines(dictionaryPath).ToList();
            addListboxItem("Starting cracking...");
            bool finished = false;
            using (ZipFile archive = ZipFile.Read(zipPath))
            {
                int tryPass = 0;

                foreach (ZipEntry file in archive)
                {
                    while (!finished)
                    {
                        string password = passList[tryPass];
                        tryPass++;
                        try
                        {
                            file.ExtractWithPassword(Application.StartupPath, password);
                            // If it passes this - It's cracked :D
                            DateTime endTime = DateTime.Now;
                            TimeSpan timeDiff = endTime - startTime;
                            addListboxItem("Success With: " + password + " (" + tryPass + " attempts after " + Math.Truncate(timeDiff.TotalSeconds) + " seconds)");
                            txtPassword.Text = password;
                            MessageBox.Show("Password: " + password, "Password Found!");
                            // Clean up
                            File.Delete(Application.StartupPath + file.FileName);
                            finished = true;
                        }
                        catch (Ionic.Zlib.ZlibException)
                        {
                            // We don't care about these
                        }
                        catch (Ionic.Zip.BadReadException)
                        {
                            // Or these
                        }
                        catch (Ionic.Zip.BadCrcException)
                        {
                            // Or these....
                        }
                        catch (Ionic.Zip.BadPasswordException)
                        {
                            // We do care about this one though!
                            if (tryPass % 1000 == 0)
                            {
                                addListboxItem("Failed With: " + password + " (" + tryPass + " attempts...)");
                            }
                        }
                        catch (Exception ex)
                        {
                            // A variation of the BadPasswordException - Weird....
                            if (ex.Message == "The password did not match.")
                            {
                                if (tryPass % 1000 == 0)
                                {
                                    addListboxItem("Failed With: " + password + " (" + tryPass + " attempts...)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: " + ex.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void addListboxItem(string item)
        {
            // Threading issues with the UI
            lbResults.Invoke(new Action(() => lbResults.Items.Insert(0, item)));
            lbResults.Invoke(new Action(() => lbResults.Refresh()));
        }
    }
}
