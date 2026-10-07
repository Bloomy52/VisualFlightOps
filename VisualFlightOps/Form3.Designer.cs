namespace VisualFlightOps
{
    partial class Form3
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
            btnSaveFlight = new Button();
            cbxFlightStatus = new ComboBox();
            lblFlightStatus = new Label();
            lblCrewId = new Label();
            txtArrCode = new TextBox();
            lblArrCode = new Label();
            txtDepCode = new TextBox();
            lblDepCode = new Label();
            lblFlightNumber = new Label();
            txtFlightNumber = new MaskedTextBox();
            txtCrewId = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnSaveFlight
            // 
            btnSaveFlight.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveFlight.Location = new Point(12, 285);
            btnSaveFlight.Name = "btnSaveFlight";
            btnSaveFlight.Size = new Size(653, 87);
            btnSaveFlight.TabIndex = 21;
            btnSaveFlight.Text = "Save Flight";
            btnSaveFlight.UseVisualStyleBackColor = true;
            btnSaveFlight.Click += btnSaveFlight_Click;
            // 
            // cbxFlightStatus
            // 
            cbxFlightStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxFlightStatus.FormattingEnabled = true;
            cbxFlightStatus.Items.AddRange(new object[] { "Scheduled", "On Time", "In Air", "Arrived", "Delayed", "Canceled" });
            cbxFlightStatus.Location = new Point(404, 201);
            cbxFlightStatus.Name = "cbxFlightStatus";
            cbxFlightStatus.Size = new Size(261, 45);
            cbxFlightStatus.TabIndex = 20;
            // 
            // lblFlightStatus
            // 
            lblFlightStatus.AutoSize = true;
            lblFlightStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightStatus.Location = new Point(12, 204);
            lblFlightStatus.Name = "lblFlightStatus";
            lblFlightStatus.Size = new Size(162, 37);
            lblFlightStatus.TabIndex = 19;
            lblFlightStatus.Text = "Flight Status";
            // 
            // lblCrewId
            // 
            lblCrewId.AutoSize = true;
            lblCrewId.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrewId.Location = new Point(12, 155);
            lblCrewId.Name = "lblCrewId";
            lblCrewId.Size = new Size(110, 37);
            lblCrewId.TabIndex = 17;
            lblCrewId.Text = "Crew ID";
            // 
            // txtArrCode
            // 
            txtArrCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArrCode.Location = new Point(404, 103);
            txtArrCode.Name = "txtArrCode";
            txtArrCode.Size = new Size(261, 43);
            txtArrCode.TabIndex = 16;
            // 
            // lblArrCode
            // 
            lblArrCode.AutoSize = true;
            lblArrCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrCode.Location = new Point(12, 109);
            lblArrCode.Name = "lblArrCode";
            lblArrCode.Size = new Size(253, 37);
            lblArrCode.TabIndex = 15;
            lblArrCode.Text = "Arrival Airport Code";
            // 
            // txtDepCode
            // 
            txtDepCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepCode.Location = new Point(404, 54);
            txtDepCode.Name = "txtDepCode";
            txtDepCode.Size = new Size(261, 43);
            txtDepCode.TabIndex = 14;
            // 
            // lblDepCode
            // 
            lblDepCode.AutoSize = true;
            lblDepCode.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepCode.Location = new Point(12, 57);
            lblDepCode.Name = "lblDepCode";
            lblDepCode.Size = new Size(296, 37);
            lblDepCode.TabIndex = 13;
            lblDepCode.Text = "Departure Airport Code";
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightNumber.Location = new Point(12, 5);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new Size(188, 37);
            lblFlightNumber.TabIndex = 11;
            lblFlightNumber.Text = "Flight Number";
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(404, 6);
            txtFlightNumber.Mask = "0000";
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(259, 39);
            txtFlightNumber.TabIndex = 22;
            txtFlightNumber.ValidatingType = typeof(int);
            // 
            // txtCrewId
            // 
            txtCrewId.Location = new Point(404, 156);
            txtCrewId.Mask = "000";
            txtCrewId.Name = "txtCrewId";
            txtCrewId.Size = new Size(261, 39);
            txtCrewId.TabIndex = 23;
            txtCrewId.ValidatingType = typeof(int);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 380);
            Controls.Add(txtCrewId);
            Controls.Add(txtFlightNumber);
            Controls.Add(btnSaveFlight);
            Controls.Add(cbxFlightStatus);
            Controls.Add(lblFlightStatus);
            Controls.Add(lblCrewId);
            Controls.Add(txtArrCode);
            Controls.Add(lblArrCode);
            Controls.Add(txtDepCode);
            Controls.Add(lblDepCode);
            Controls.Add(lblFlightNumber);
            Name = "Form3";
            Text = "Update Flight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveFlight;
        private ComboBox cbxFlightStatus;
        private Label lblFlightStatus;
        private Label lblCrewId;
        private TextBox txtArrCode;
        private Label lblArrCode;
        private TextBox txtDepCode;
        private Label lblDepCode;
        private Label lblFlightNumber;
        private MaskedTextBox txtFlightNumber;
        private MaskedTextBox txtCrewId;
    }
}