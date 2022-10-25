
namespace Kursovaya_Rabota.Project.Forms
{
    partial class Managementform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StaffButton = new System.Windows.Forms.Button();
            this.ComponentButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.StaffButton);
            this.panel1.Controls.Add(this.ComponentButton);
            this.panel1.Controls.Add(this.ConfigButton);
            this.panel1.Controls.Add(this.ClientsButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC Configurator";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 80);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 499);
            this.panel4.TabIndex = 4;
            // 
            // StaffButton
            // 
            this.StaffButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffButton.FlatAppearance.BorderSize = 0;
            this.StaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffButton.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__4_;
            this.StaffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffButton.Location = new System.Drawing.Point(0, 221);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(200, 47);
            this.StaffButton.TabIndex = 6;
            this.StaffButton.Text = "Сотрудники";
            this.StaffButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffButton.UseVisualStyleBackColor = true;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // ComponentButton
            // 
            this.ComponentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComponentButton.FlatAppearance.BorderSize = 0;
            this.ComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComponentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComponentButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ComponentButton.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__6_;
            this.ComponentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComponentButton.Location = new System.Drawing.Point(0, 174);
            this.ComponentButton.Name = "ComponentButton";
            this.ComponentButton.Size = new System.Drawing.Size(200, 47);
            this.ComponentButton.TabIndex = 5;
            this.ComponentButton.Text = "Учёт комплектующих";
            this.ComponentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComponentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ComponentButton.UseVisualStyleBackColor = true;
            this.ComponentButton.Click += new System.EventHandler(this.ComponentButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfigButton.FlatAppearance.BorderSize = 0;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfigButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ConfigButton.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__5_;
            this.ConfigButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigButton.Location = new System.Drawing.Point(0, 127);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(200, 47);
            this.ConfigButton.TabIndex = 4;
            this.ConfigButton.Text = "Конфигуратор";
            this.ConfigButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientsButton.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__7_;
            this.ClientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.Location = new System.Drawing.Point(0, 80);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(200, 47);
            this.ClientsButton.TabIndex = 3;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // Managementform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 579);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Managementform";
            this.Load += new System.EventHandler(this.Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button StaffButton;
        private System.Windows.Forms.Button ComponentButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}