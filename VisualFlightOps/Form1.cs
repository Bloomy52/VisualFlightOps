/*!
 * Visual Flight Operations Management System
 * Copyrignt (c) 2026 Louie Bloomberg.
 * SPDX-License-Identifier: MIT
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace VisualFlightOps.Framework
{
    public partial class Form1 : Form
    {
        public int Index = 0;
        public int SelectedIndex = -1;
        public Dictionary<int, Flight> flightInfo = new Dictionary<int, Flight>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (SelectedIndex < 0 || !flightInfo.ContainsKey(SelectedIndex))
            {
                MessageBox.Show("Please select a flight to update.");
                return;
            }

            Form3 updateFlight = new Form3(flightInfo[SelectedIndex]);
            updateFlight.ShowDialog(this);
            lstFlights.Items[SelectedIndex] = "Flight " + flightInfo[SelectedIndex].Number;
            lstFlightInfo.Items.Clear();
            if (SelectedIndex < 0 || !flightInfo.ContainsKey(SelectedIndex)) return;
            SelectedIndex = lstFlights.SelectedIndex;
            lstFlightInfo.Items.Add("Flight Number: " + flightInfo[SelectedIndex].Number);
            lstFlightInfo.Items.Add("Departure Code: " + flightInfo[SelectedIndex].DepCode);
            lstFlightInfo.Items.Add("Arrival Code: " + flightInfo[SelectedIndex].ArrCode);
            lstFlightInfo.Items.Add("Crew ID: " + flightInfo[SelectedIndex].CrewId);
            lstFlightInfo.Items.Add("Status: " + flightInfo[SelectedIndex].Status);
        }

        private void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = lstFlights.SelectedIndex;
            lstFlightInfo.Items.Clear();
            if (SelectedIndex < 0 || !flightInfo.ContainsKey(SelectedIndex)) return;
            lstFlightInfo.Items.Add("Flight Number: " + flightInfo[SelectedIndex].Number);
            lstFlightInfo.Items.Add("Departure Code: " + flightInfo[SelectedIndex].DepCode);
            lstFlightInfo.Items.Add("Arrival Code: " + flightInfo[SelectedIndex].ArrCode);
            lstFlightInfo.Items.Add("Crew ID: " + flightInfo[SelectedIndex].CrewId);
            lstFlightInfo.Items.Add("Status: " + flightInfo[SelectedIndex].Status);
        }

        private void btnCreateFlight_Click(object sender, EventArgs e)
        {
            Form2 createFlight = new Form2(this);
            if (createFlight.ShowDialog() == DialogResult.OK)
            {
                lstFlights.Items.Add("Flight " + createFlight.flightNumber);
                Index += 1;
            }

        }
    }
}

