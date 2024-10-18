namespace ReservationSystem
{
    partial class AddReservation
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_service = new System.Windows.Forms.Label();
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_name.Location = new System.Drawing.Point(78, 87);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(160, 24);
            this.tb_name.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(75, 68);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 16);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_surname.Location = new System.Drawing.Point(78, 151);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(160, 24);
            this.tb_surname.TabIndex = 7;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_surname.Location = new System.Drawing.Point(75, 132);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(71, 16);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "Surname";
            // 
            // label_service
            // 
            this.label_service.AutoSize = true;
            this.label_service.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_service.Location = new System.Drawing.Point(75, 198);
            this.label_service.Name = "label_service";
            this.label_service.Size = new System.Drawing.Size(60, 16);
            this.label_service.TabIndex = 8;
            this.label_service.Text = "Service";
            // 
            // cb_service
            // 
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(78, 226);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(121, 20);
            this.cb_service.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_save.Location = new System.Drawing.Point(96, 274);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 35);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 392);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_service);
            this.Controls.Add(this.label_service);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_name);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_service;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.Button btn_save;
    }
}