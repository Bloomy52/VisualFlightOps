/*!
 * Visual Flight Operations Management System
 * Copyrignt (c) 2026 Louie Bloomberg.
 * SPDX-License-Identifier: MIT
 */

using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualFlightOps
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

            using (Form3 updateFlight = new Form3(flightInfo[SelectedIndex]))
            {
                if (updateFlight.ShowDialog(this) == DialogResult.OK)
                {
                    lstFlights.Items[SelectedIndex] = "Flight " + flightInfo[SelectedIndex].Number;
                    RefreshFlightInformation();
                }
            }
        }

        private void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = lstFlights.SelectedIndex;
            RefreshFlightInformation();
        }

        private void RefreshFlightInformation()
        {
            lstFlightInfo.Items.Clear();
            if (!flightInfo.TryGetValue(SelectedIndex, out Flight? flight))
                return;

            lstFlightInfo.Items.Add("Flight Number: " + flight.Number);
            lstFlightInfo.Items.Add("Departure Code: " + flight.DepCode);
            lstFlightInfo.Items.Add("Arrival Code: " + flight.ArrCode);
            lstFlightInfo.Items.Add("Crew ID: " + flight.CrewId);
            lstFlightInfo.Items.Add("Status: " + flight.Status);
        }
        private void btnCreateFlight_Click(object sender, EventArgs e)
        {
            using Form2 createFlight = new Form2(this);
            if (createFlight.ShowDialog(this) == DialogResult.OK)
            {
                lstFlights.Items.Add("Flight " + createFlight.flightNumber);
                Index += 1;
            }

        }
    }
}
