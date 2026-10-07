using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace VisualFlightOps
{
    public partial class Form2 : Form
    {
        public int flightNumber;
        public string depCode;
        public string arrCode;
        public int crewId;
        public string status;

        private Form1 form1;
        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            form1 = mainForm;
        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            flightNumber = int.Parse(txtFlightNumber.Text);
            depCode = txtDepCode.Text;
            arrCode = txtArrCode.Text;
            crewId = int.Parse(txtCrewId.Text);
            status = cbxFlightStatus.SelectedItem.ToString();

            Flight newFlight = new Flight(flightNumber, depCode, arrCode, crewId, status);


            form1.flightInfo[form1.Index] = newFlight;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
