using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.im;
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
            if (!(String.IsNullOrEmpty((string)tagBox.Text)) && (!(String.IsNullOrEmpty((string)imageTextBox.Text))))
            {
                if (((String.IsNullOrEmpty((string)soundTextBox.Text))))
                    soundTextBox.Text = "none";
                data = tagBox.Text + "," + imageTextBox.Text + "," + soundTextBox.Text;
                flag = true;
            }
            else System.Windows.Forms.MessageBox.Show("Tag ID or Image cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            if (flag)
            {
                //Need to agree on where to copy. but this works right now.
                string configs_path = Directory.GetCurrentDirectory() + "\\rfgridTools\\rfgridCalibration\\configs\\";
                string path = Directory.GetCurrentDirectory() + "\\rfgridTools\\rfgridCalibration\\configs\\tag.rfgridtag";
                if (Directory.Exists(path))
                {
                    if (File.Exists(path))
                    {
                        System.IO.File.AppendAllText(path, data + Environment.NewLine);

                    }
                    else
                    {

                        System.IO.File.WriteAllText(path, data + Environment.NewLine);

                    }
                    if (soundTextBox.Text != "none")
                        System.IO.File.Copy(soundTextBox.Text, configs_path + Path.GetFileName(soundTextBox.Text), true);
                    System.IO.File.Copy(imageTextBox.Text, configs_path + Path.GetFileName(imageTextBox.Text), true);
                    System.Windows.Forms.MessageBox.Show("Tag is sucessfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else System.Windows.Forms.MessageBox.Show("Make sure this executable is located in the rfgrid folder.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                Filter = "Image files (*.wav)|*.wav",
                Title = "Choose Sound file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                soundTextBox.Text = openFileDialog1.FileName;
            }
        }

    }

}
