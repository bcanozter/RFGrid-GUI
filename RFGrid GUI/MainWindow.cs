using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tag_Scanner
{
    public partial class MainWindow : Form
    {
  
        public MainWindow()
        {
            //this.BackgroundImage = Properties.Resources.im; #disable until we find a better background image
            InitializeComponent();
        }


        private void ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select an image file",
                Filter = "Image files (*.png)|*.png",
                Title = "Choose Image file"
            };
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = openFileDialog1.FileName;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string data = "";
            bool flag = false;
            bool duplicate_id = false;
      
            if (!(String.IsNullOrEmpty((string)tagBox.Text)) && (!(String.IsNullOrEmpty((string)imageTextBox.Text))))
            {
                if (((String.IsNullOrEmpty((string)soundTextBox.Text))))
                    soundTextBox.Text = "none";
                string new_image_path = "./images/objects/" + Path.GetFileName(imageTextBox.Text);
                string new_sound_path = "./sounds/" + Path.GetFileName(soundTextBox.Text);
                data = "\n" + tagBox.Text + "," + new_image_path + "," + new_sound_path;
                flag = true;
            }
            else System.Windows.Forms.MessageBox.Show("Tag ID or Image cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            if (flag)
            {
                //Need to agree on where to copy. but this works right now.
                string configs_path = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\configs\\";
                string objects_path = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\images\\objects\\";
                string sounds_path = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\sounds\\";
                string path = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\configs\\tags.rfgridtag";
                if (Directory.Exists(configs_path))
                {
                    if (File.Exists(path))
                    {
                        //Really ugly way of checking if the id was already in the tags.rfgridtag.
                        //Have to go through the file and read every line.
                        //Then if it exists, edit that line and re-write the file.
                        //Otherwise, it is a new ID and just append it to the file.
                        string[] arrLine = System.IO.File.ReadAllLines(path);
                        string[] IDs = new string[] { };
                        for (var i = 0; i < arrLine.Length; i += 1)
                        {
                            string line = arrLine[i];
                            IDs = line.Split(',');
                            if (IDs[0] == tagBox.Text)
                            {
                                arrLine[i] = data;
                                duplicate_id = true;
                            }
                            
                        }
                        if(!duplicate_id)
                            System.IO.File.AppendAllText(path, data + Environment.NewLine);
                        else System.IO.File.WriteAllLines(path, arrLine);

                    }
                    else
                    {

                        System.IO.File.WriteAllText(path, data + Environment.NewLine);

                    }
                    if (soundTextBox.Text != "none")
                        System.IO.File.Copy(soundTextBox.Text, sounds_path + Path.GetFileName(soundTextBox.Text), true);
                    System.IO.File.Copy(imageTextBox.Text, objects_path + Path.GetFileName(imageTextBox.Text), true);
                    System.Windows.Forms.MessageBox.Show("Tag is sucessfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else System.Windows.Forms.MessageBox.Show("Make sure this executable is located in the rfgrid folder.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tagBox.Text = null;
            imageTextBox.Text = null;
            soundTextBox.Text = null;
        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a sound file",
                Filter = "Sound files (*.wav)|*.wav",
                Title = "Choose Sound file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                soundTextBox.Text = openFileDialog1.FileName;
            }
        }

        static void replaceLine(string ID,string newText,string fileName, int lineIndex)
        {
            string[] arrLine = System.IO.File.ReadAllLines(fileName);
            string[] IDs = new string[] { };
            for(var i = 0; i< arrLine.Length; i += 1)
            {
                var line = arrLine[i];
  
                IDs = line.Split(',');
                if(IDs[0] == ID)
                {
                    arrLine[i] = ID;
                }
                System.IO.File.AppendAllText(Directory.GetCurrentDirectory() + "\\debug.txt", IDs[0] + Environment.NewLine);

            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ChooseCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailablePorts to = new AvailablePorts(this);
            to.Show();

        }

        public string LabelText
        {
            get { return portTextLabel.Text; }
            set { portTextLabel.Text = value; }
        }

        private void DisplayInfoButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("rfgrid device dimensions.\nExample: 4x4, 8x8, 12x12,16x16.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DispCalibrateButton_Click(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\rfgridDispCalib.py";
            string args = dispCalibXBox.Text + "x" + dispCalibYBox.Text;
            run_cmd(filePath, args);
        }


        private void InstallModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\python\python-3.7.6\Scripts\pip.exe"))
            {
                filePath = Directory.GetCurrentDirectory() + @"\python\setup\get-pip.py";
                run_cmd(filePath, null);


                filePath = Directory.GetCurrentDirectory() + @"\python\python-3.7.6\Scripts\Lib\site-packages" + ";" + Directory.GetCurrentDirectory() + @"\python\python-3.7.6\Scripts" + ";" + Directory.GetCurrentDirectory() + @"\python\python-3.7.6";
                System.Environment.SetEnvironmentVariable("PATH", filePath, EnvironmentVariableTarget.Machine);
            }
            else
            {
                filePath = Directory.GetCurrentDirectory() + @"\python\setup\modules.py";
                run_cmd(filePath, null);
            }
        }


        private void run_cmd(string cmd, string args)
        {

            string result;

            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            start.FileName = System.AppDomain.CurrentDomain.BaseDirectory + @"python\python-3.7.6\python.exe";
            //@"C:\python27\python.exe";

            start.Arguments = string.Format(@"""{0}"" {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;
            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd();
                    debugTextBox.AppendText(">" + stderr + "\n");
                    result = reader.ReadToEnd();
                    debugTextBox.AppendText(">" + result + "\n");
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BackgroundImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select an image file",
                Filter = "Image files (*.png)|*.png",
                Title = "Choose image file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundImgTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void BackgroundCalibButton_Click(object sender, EventArgs e)
        {
            if ((backgroundImgTextBox.Text != null) && (File.Exists(backgroundImgTextBox.Text)))
            {
                string backgrounds_path = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\images\\backgrounds\\";
                string filePath = Directory.GetCurrentDirectory() + "\\python\\rfgridTools\\rfgridCalibration\\rfgridBackgroundCalib.py";
                System.IO.File.Copy(backgroundImgTextBox.Text, backgrounds_path + Path.GetFileName(backgroundImgTextBox.Text), true);
                run_cmd(filePath, Path.GetFileName(backgroundImgTextBox.Text));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select an image.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "ECED 4900-4901 Senior Year Project 2019-2020\n\n" +
                          "Project: rfgrid\n\n" +
                          "Members\n" +
                          "\n" +
                          "- Burak Ozter\n" +
                          "- Mark Hooper\n" +
                          "- Cathy Song   ";
            System.Windows.Forms.MessageBox.Show(info, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void TagGetIdButton_Click(object sender, EventArgs e)
        {
            //string data = "";
            int data = 0x00;
            if (portTextLabel.Text == "NA")
            {

                var getid = new byte[] { 0x01, 0x02,0x03};
                string[] arr = portTextLabel.Text.Split(' ');
                int index = arr.Length;
                SerialPort serialPort = new SerialPort();
                serialPort.PortName = "COM3";
                    //arr[index - 1];
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
               // serialPort.ReadTimeout = 10000;
                serialPort.Open();
                serialPort.Write(getid,0,3);
                data = (serialPort.ReadByte());
                debugTextBox.AppendText(serialPort.ReadByte().ToString());
                serialPort.DataReceived += new
     SerialDataReceivedEventHandler(port_DataReceived);
                

            }

        }

        private void port_DataReceived(object sender,
                                 SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            this.Invoke((MethodInvoker)delegate
            {
                tagBox.Text = sp.ReadExisting();
                //debugTextBox.Text = ((sp.ReadExisting()).ToString());
        
            });
            sp.Close();
        }



    }

}
