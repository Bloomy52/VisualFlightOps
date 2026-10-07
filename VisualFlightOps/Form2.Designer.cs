namespace VisualFlightOps
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFlightNumber = new Label();
            lblDepCode = new Label();
            lblArrCode = new Label();
            lblCrewId = new Label();
            lblFlightStatus = new Label();
            cbxFlightStatus = new ComboBox();
            btnSaveFlight = new Button();
            txtFlightNumber = new MaskedTextBox();
            txtCrewId = new MaskedTextBox();
            txtDepCode = new TextBox();
            txtArrCode = new TextBox();
            SuspendLayout();
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightNumber.Location = new Point(12, 6);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new Size(188, 37);
            lblFlightNumber.TabIndex = 0;
            lblFlightNumber.Text = "Flight Number";
            // 
            // lblDepCode
            // 
            lblDepCode.AutoSize = true;
            lblDepCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepCode.Location = new Point(12, 58);
            lblDepCode.Name = "lblDepCode";
            lblDepCode.Size = new Size(296, 37);
            lblDepCode.TabIndex = 2;
            lblDepCode.Text = "Departure Airport Code";
            // 
            // lblArrCode
            // 
            lblArrCode.AutoSize = true;
            lblArrCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrCode.Location = new Point(12, 107);
            lblArrCode.Name = "lblArrCode";
            lblArrCode.Size = new Size(253, 37);
            lblArrCode.TabIndex = 4;
            lblArrCode.Text = "Arrival Airport Code";
            // 
            // lblCrewId
            // 
            lblCrewId.AutoSize = true;
            lblCrewId.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrewId.Location = new Point(12, 156);
            lblCrewId.Name = "lblCrewId";
            lblCrewId.Size = new Size(110, 37);
            lblCrewId.TabIndex = 6;
            lblCrewId.Text = "Crew ID";
            // 
            // lblFlightStatus
            // 
            lblFlightStatus.AutoSize = true;
            lblFlightStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightStatus.Location = new Point(12, 205);
            lblFlightStatus.Name = "lblFlightStatus";
            lblFlightStatus.Size = new Size(162, 37);
            lblFlightStatus.TabIndex = 8;
            lblFlightStatus.Text = "Flight Status";
            // 
            // cbxFlightStatus
            // 
            cbxFlightStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxFlightStatus.FormattingEnabled = true;
            cbxFlightStatus.Items.AddRange(new object[] { "Scheduled", "On Time", "In Air", "Arrived", "Delayed", "Canceled" });
            cbxFlightStatus.Location = new Point(404, 202);
            cbxFlightStatus.Name = "cbxFlightStatus";
            cbxFlightStatus.Size = new Size(261, 45);
            cbxFlightStatus.TabIndex = 9;
            // 
            // btnSaveFlight
            // 
            btnSaveFlight.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveFlight.Location = new Point(12, 286);
            btnSaveFlight.Name = "btnSaveFlight";
            btnSaveFlight.Size = new Size(653, 87);
            btnSaveFlight.TabIndex = 10;
            btnSaveFlight.Text = "Create Flight";
            btnSaveFlight.UseVisualStyleBackColor = true;
            btnSaveFlight.Click += btnSaveFlight_Click;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(404, 10);
            txtFlightNumber.Mask = "0000";
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(261, 39);
            txtFlightNumber.TabIndex = 11;
            txtFlightNumber.ValidatingType = typeof(int);
            // 
            // txtCrewId
            // 
            txtCrewId.Location = new Point(404, 157);
            txtCrewId.Mask = "000";
            txtCrewId.Name = "txtCrewId";
            txtCrewId.Size = new Size(261, 39);
            txtCrewId.TabIndex = 14;
            txtCrewId.ValidatingType = typeof(int);
            // 
            // txtDepCode
            // 
            txtDepCode.Location = new Point(404, 59);
            txtDepCode.Name = "txtDepCode";
            txtDepCode.Size = new Size(261, 39);
            txtDepCode.TabIndex = 15;
            // 
            // txtArrCode
            // 
            txtArrCode.Location = new Point(404, 108);
            txtArrCode.Name = "txtArrCode";
            txtArrCode.Size = new Size(261, 39);
            txtArrCode.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 387);
            Controls.Add(txtArrCode);
            Controls.Add(txtDepCode);
            Controls.Add(txtCrewId);
            Controls.Add(txtFlightNumber);
            Controls.Add(btnSaveFlight);
            Controls.Add(cbxFlightStatus);
            Controls.Add(lblFlightStatus);
            Controls.Add(lblCrewId);
            Controls.Add(lblArrCode);
            Controls.Add(lblDepCode);
            Controls.Add(lblFlightNumber);
            Name = "Form2";
            Text = "Create Flight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFlightNumber;
        private Label lblDepCode;
        private Label lblArrCode;
        private Label lblCrewId;
        private Label lblFlightStatus;
        private ComboBox cbxFlightStatus;
        private Button btnSaveFlight;
        private MaskedTextBox txtFlightNumber;
        private MaskedTextBox txtCrewId;
        private TextBox txtDepCode;
        private TextBox txtArrCode;
    }
}