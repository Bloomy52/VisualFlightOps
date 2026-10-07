/*!
 * Visual Flight Operations Management System
 * Copyrignt (c) 2026 Louie Bloomberg.
 * SPDX-License-Identifier: MIT
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace VisualFlightOps.Framework
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
            cbxFlightStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            form1 = mainForm;
        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            int number;
            int crew;
            if (!int.TryParse(txtFlightNumber.Text, out number) || !int.TryParse(txtCrewId.Text, out crew))
            {
                MessageBox.Show(this, "Please enter a valid flight number and crew ID.");
                return;
            }
            if (cbxFlightStatus.SelectedItem == null)
            {
                MessageBox.Show(this, "Please select a flight status.");
                return;
            }
            flightNumber = number;
            depCode = txtDepCode.Text;
            arrCode = txtArrCode.Text;
            crewId = crew;
            status = cbxFlightStatus.SelectedItem.ToString();

            Flight newFlight = new Flight(flightNumber, depCode, arrCode, crewId, status);


            form1.flightInfo[form1.Index] = newFlight;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}


