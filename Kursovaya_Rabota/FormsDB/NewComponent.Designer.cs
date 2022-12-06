
namespace Kursovaya_Rabota
{
    partial class NewComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewComponent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Selector = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Selector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 697);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(406, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1213, 657);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 697);
            this.panel3.TabIndex = 26;
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.SystemColors.Window;
            this.Selector.FormattingEnabled = true;
            this.Selector.ItemHeight = 23;
            this.Selector.Items.AddRange(new object[] {
            "Процессор",
            "Видеокарта",
            "Материнская плата",
            "Блок питания",
            "Корпус",
            "Оперативная память",
            "Кулер для процессора",
            "Вентиляторы для корпуса",
            "Жесткий диск",
            "Твердотельный накопитель"});
            this.Selector.Location = new System.Drawing.Point(18, 28);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(371, 29);
            this.Selector.TabIndex = 1;
            this.Selector.UseSelectable = true;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1631, 12);
            this.panel2.TabIndex = 25;
            // 
            // NewComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1647, 736);
            this.MinimumSize = new System.Drawing.Size(1647, 736);
            this.Name = "NewComponent";
            this.Load += new System.EventHandler(this.NewComponent_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox Selector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}