
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
            this.Selector = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.SystemColors.Window;
            this.Selector.FormattingEnabled = true;
            this.Selector.ItemHeight = 23;
            this.Selector.Items.AddRange(new object[] {
            "Процессор ",
            "Видеокарта",
            "Материнская плата",
            "Блок питания",
            "Корпус",
            "Оперативная память",
            "Кулер для процессора ",
            "Вентиляторы для корпуса"});
            this.Selector.Location = new System.Drawing.Point(23, 77);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(440, 29);
            this.Selector.TabIndex = 0;
            this.Selector.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NewComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Selector);
            this.Name = "NewComponent";
            this.Text = "Добавление комплектующих в базу";
            this.Load += new System.EventHandler(this.NewComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox Selector;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}