namespace ReservationSystem
{
    partial class AddService
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
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_title
            // 
            this.tb_title.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_title.Location = new System.Drawing.Point(58, 99);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(160, 24);
            this.tb_title.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(55, 80);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(36, 16);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Title";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_price.Location = new System.Drawing.Point(58, 179);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(160, 24);
            this.tb_price.TabIndex = 5;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_price.Location = new System.Drawing.Point(55, 160);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(91, 16);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "Price (AZN)";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Coral;
            this.btn_save.Location = new System.Drawing.Point(81, 236);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 320);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.label_title);
            this.Name = "AddService";
            this.Text = "AddService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button btn_save;
    }
}