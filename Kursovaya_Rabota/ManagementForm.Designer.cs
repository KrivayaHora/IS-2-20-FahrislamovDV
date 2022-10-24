
namespace Kursovaya_Rabota
{
    partial class ManagementForm
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
            this.RegComponent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManageEmp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManageClientBox = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // RegComponent
            // 
            this.RegComponent.Depth = 0;
            this.RegComponent.Location = new System.Drawing.Point(-1, 290);
            this.RegComponent.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegComponent.Name = "RegComponent";
            this.RegComponent.Primary = true;
            this.RegComponent.Size = new System.Drawing.Size(183, 79);
            this.RegComponent.TabIndex = 1;
            this.RegComponent.Text = "Регистрация комплектующего";
            this.RegComponent.UseVisualStyleBackColor = true;
            this.RegComponent.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // ManageEmp
            // 
            this.ManageEmp.Depth = 0;
            this.ManageEmp.Location = new System.Drawing.Point(-1, 375);
            this.ManageEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageEmp.Name = "ManageEmp";
            this.ManageEmp.Primary = true;
            this.ManageEmp.Size = new System.Drawing.Size(183, 77);
            this.ManageEmp.TabIndex = 3;
            this.ManageEmp.Text = "Сотрудники";
            this.ManageEmp.UseVisualStyleBackColor = true;
            this.ManageEmp.Click += new System.EventHandler(this.ManageEmp_Click);
            // 
            // ManageClientBox
            // 
            this.ManageClientBox.Depth = 0;
            this.ManageClientBox.Location = new System.Drawing.Point(-1, 120);
            this.ManageClientBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageClientBox.Name = "ManageClientBox";
            this.ManageClientBox.Primary = true;
            this.ManageClientBox.Size = new System.Drawing.Size(183, 79);
            this.ManageClientBox.TabIndex = 4;
            this.ManageClientBox.Text = "Клиенты";
            this.ManageClientBox.UseVisualStyleBackColor = true;
            this.ManageClientBox.Click += new System.EventHandler(this.ManageClientBox_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(-1, 205);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(183, 79);
            this.materialRaisedButton5.TabIndex = 5;
            this.materialRaisedButton5.Text = "Конфиругатор ПК";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 477);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.ManageClientBox);
            this.Controls.Add(this.ManageEmp);
            this.Controls.Add(this.RegComponent);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManagementForm";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Text = "Управление";
            this.TransparencyKey = System.Drawing.Color.SpringGreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton RegComponent;
        private MaterialSkin.Controls.MaterialRaisedButton ManageEmp;
        private MaterialSkin.Controls.MaterialRaisedButton ManageClientBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
    }
}