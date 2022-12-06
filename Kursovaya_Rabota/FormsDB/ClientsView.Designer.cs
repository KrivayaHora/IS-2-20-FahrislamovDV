
namespace Kursovaya_Rabota
{
    partial class ClientsV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegB = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.RegB);
            this.panel1.Controls.Add(this.Reload);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 697);
            this.panel1.TabIndex = 0;
            // 
            // RegB
            // 
            this.RegB.Cursor = System.Windows.Forms.Cursors.Default;
            this.RegB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegB.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__29_;
            this.RegB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegB.Location = new System.Drawing.Point(1487, 32);
            this.RegB.Name = "RegB";
            this.RegB.Size = new System.Drawing.Size(132, 40);
            this.RegB.TabIndex = 40;
            this.RegB.Text = "Регистрация";
            this.RegB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegB.UseVisualStyleBackColor = true;
            this.RegB.Click += new System.EventHandler(this.RegB_Click);
            // 
            // Reload
            // 
            this.Reload.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__30_;
            this.Reload.Location = new System.Drawing.Point(1441, 32);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(40, 40);
            this.Reload.TabIndex = 39;
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Kursovaya_Rabota.Properties.Resources.pngegg__28_;
            this.button1.Location = new System.Drawing.Point(295, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(18, 39);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(271, 26);
            this.Search.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 685);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1631, 12);
            this.panel2.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDClient,
            this.FullNameClient,
            this.AdressClient,
            this.PhoneClient,
            this.EmailClient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1602, 587);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDClient
            // 
            this.IDClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDClient.Frozen = true;
            this.IDClient.HeaderText = "Код";
            this.IDClient.Name = "IDClient";
            this.IDClient.ReadOnly = true;
            this.IDClient.Visible = false;
            // 
            // FullNameClient
            // 
            this.FullNameClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullNameClient.Frozen = true;
            this.FullNameClient.HeaderText = "Полное имя";
            this.FullNameClient.Name = "FullNameClient";
            this.FullNameClient.ReadOnly = true;
            this.FullNameClient.Width = 355;
            // 
            // AdressClient
            // 
            this.AdressClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdressClient.HeaderText = "Адрес проживания";
            this.AdressClient.Name = "AdressClient";
            this.AdressClient.ReadOnly = true;
            // 
            // PhoneClient
            // 
            this.PhoneClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneClient.HeaderText = "Номер телефона";
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.ReadOnly = true;
            // 
            // EmailClient
            // 
            this.EmailClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailClient.HeaderText = "Электронная почта";
            this.EmailClient.Name = "EmailClient";
            this.EmailClient.ReadOnly = true;
            // 
            // ClientsV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 697);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsV";
            this.Load += new System.EventHandler(this.ClientsView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button RegB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailClient;
    }
}