using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace Tag_Scanner
{
    public partial class AvailablePorts : Form
    {
        
        public AvailablePorts()
        {
            
            InitializeComponent();

        }
        private MainWindow mainForm = null;
        public AvailablePorts(Form callingForm)
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }



        private void getAvailablePorts()
        {
            PortList.Items.Clear();
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();


                    PortList.Items.Add(desc + " " + deviceId);
                    

                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void SaveButtonPorts_Click(object sender, EventArgs e)
        {

            this.mainForm.LabelText = (PortList.GetItemText(PortList.SelectedItem));

            this.Close();

        }

    }


}
 

