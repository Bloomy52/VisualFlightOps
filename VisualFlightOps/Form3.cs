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
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualFlightOps
{
    public partial class Form3 : Form
    {
        private Flight flight;
        public Form3(Flight flight)
        {
            InitializeComponent();
            cbxFlightStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.flight = flight;
            txtFlightNumber.Text = flight.Number.ToString();
            txtDepCode.Text = flight.DepCode;
            txtArrCode.Text = flight.ArrCode;
            txtCrewId.Text = flight.CrewId.ToString();
            cbxFlightStatus.SelectedItem = flight.Status;

        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFlightNumber.Text, out int number) ||
                !int.TryParse(txtCrewId.Text, out int crew))
            {
                MessageBox.Show(this, "Please enter a valid flight number and crew ID.");
                return;
            }
            if (cbxFlightStatus.SelectedItem is not string selectedStatus)
            {
                MessageBox.Show(this, "Please select a flight status.");
                return;
            }
            flight.Number = number;
            flight.DepCode = txtDepCode.Text;
            flight.ArrCode = txtArrCode.Text;
            flight.CrewId = crew;
            flight.Status = selectedStatus;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
