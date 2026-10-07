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
            this.flight = flight;
            txtFlightNumber.Text = flight.Number.ToString();
            txtDepCode.Text = flight.DepCode;
            txtArrCode.Text = flight.ArrCode;
            txtCrewId.Text = flight.CrewId.ToString();
            cbxFlightStatus.SelectedItem = flight.Status;

        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            flight.Number = int.Parse(txtFlightNumber.Text);
            flight.DepCode = txtDepCode.Text;
            flight.ArrCode = txtArrCode.Text;
            flight.CrewId = int.Parse(txtCrewId.Text);
            flight.Status = cbxFlightStatus.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
