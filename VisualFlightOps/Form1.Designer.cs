using System.Drawing;
using System.Windows.Forms;

namespace VisualFlightOps.Framework
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFlights = new ListBox();
            lstFlightInfo = new ListBox();
            btnCreateFlight = new Button();
            btnUpdateFlight = new Button();
            SuspendLayout();
            // 
            // lstFlights
            // 
            lstFlights.FormattingEnabled = true;
            lstFlights.Location = new Point(12, 12);
            lstFlights.Name = "lstFlights";
            lstFlights.Size = new Size(239, 260);
            lstFlights.TabIndex = 0;
            lstFlights.SelectedIndexChanged += lstFlights_SelectedIndexChanged;
            // 
            // lstFlightInfo
            // 
            lstFlightInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFlightInfo.FormattingEnabled = true;
            lstFlightInfo.Location = new Point(278, 12);
            lstFlightInfo.Name = "lstFlightInfo";
            lstFlightInfo.Size = new Size(360, 260);
            lstFlightInfo.TabIndex = 1;
            // 
            // btnCreateFlight
            // 
            btnCreateFlight.Location = new Point(12, 278);
            btnCreateFlight.Name = "btnCreateFlight";
            btnCreateFlight.Size = new Size(240, 76);
            btnCreateFlight.TabIndex = 2;
            btnCreateFlight.Text = "Create New Flight";
            btnCreateFlight.UseVisualStyleBackColor = true;
            btnCreateFlight.Click += btnCreateFlight_Click;
            // 
            // btnUpdateFlight
            // 
            btnUpdateFlight.Location = new Point(278, 278);
            btnUpdateFlight.Name = "btnUpdateFlight";
            btnUpdateFlight.Size = new Size(360, 76);
            btnUpdateFlight.TabIndex = 3;
            btnUpdateFlight.Text = "Update Flight Information";
            btnUpdateFlight.UseVisualStyleBackColor = true;
            btnUpdateFlight.Click += btnUpdateFlight_Click;
            // 
            // Form1
            // 
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 361);
            Controls.Add(btnUpdateFlight);
            Controls.Add(btnCreateFlight);
            Controls.Add(lstFlightInfo);
            Controls.Add(lstFlights);
            Name = "Form1";
            Text = "Flight Operations";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstFlights;
        private System.Windows.Forms.ListBox lstFlightInfo;
        private System.Windows.Forms.Button btnCreateFlight;
        private System.Windows.Forms.Button btnUpdateFlight;
    }
}

