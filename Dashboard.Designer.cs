namespace ReservationSystem
{
    partial class Dashboard
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
            this.btn_add_service = new System.Windows.Forms.Button();
            this.btn_add_reservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_service
            // 
            this.btn_add_service.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_add_service.Location = new System.Drawing.Point(41, 29);
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.Size = new System.Drawing.Size(211, 36);
            this.btn_add_service.TabIndex = 0;
            this.btn_add_service.Text = "Add Service";
            this.btn_add_service.UseVisualStyleBackColor = false;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // btn_add_reservation
            // 
            this.btn_add_reservation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add_reservation.Location = new System.Drawing.Point(278, 29);
            this.btn_add_reservation.Name = "btn_add_reservation";
            this.btn_add_reservation.Size = new System.Drawing.Size(211, 36);
            this.btn_add_reservation.TabIndex = 1;
            this.btn_add_reservation.Text = "Add Reservation";
            this.btn_add_reservation.UseVisualStyleBackColor = false;
            this.btn_add_reservation.Click += new System.EventHandler(this.btn_add_reservation_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_reservation);
            this.Controls.Add(this.btn_add_service);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_service;
        private System.Windows.Forms.Button btn_add_reservation;
    }
}