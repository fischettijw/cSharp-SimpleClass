namespace cSharp_SimpleClass
{
    partial class FrmClass
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
            this.BtnAddAnimal = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.LbxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAddAnimal
            // 
            this.BtnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAnimal.Location = new System.Drawing.Point(49, 58);
            this.BtnAddAnimal.Name = "BtnAddAnimal";
            this.BtnAddAnimal.Size = new System.Drawing.Size(161, 44);
            this.BtnAddAnimal.TabIndex = 0;
            this.BtnAddAnimal.Text = "Add Animals";
            this.BtnAddAnimal.UseVisualStyleBackColor = true;
            this.BtnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(256, 65);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(153, 29);
            this.TxtName.TabIndex = 1;
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(473, 65);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(153, 29);
            this.TxtAge.TabIndex = 2;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplay.Location = new System.Drawing.Point(49, 143);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(161, 44);
            this.BtnDisplay.TabIndex = 3;
            this.BtnDisplay.Text = "Display Animal";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // LbxDisplay
            // 
            this.LbxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxDisplay.FormattingEnabled = true;
            this.LbxDisplay.ItemHeight = 24;
            this.LbxDisplay.Location = new System.Drawing.Point(256, 143);
            this.LbxDisplay.Name = "LbxDisplay";
            this.LbxDisplay.Size = new System.Drawing.Size(370, 196);
            this.LbxDisplay.TabIndex = 4;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbxDisplay);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnAddAnimal);
            this.Name = "FrmClass";
            this.Text = "Simple Class in C#";
            this.Load += new System.EventHandler(this.FrmClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAnimal;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.ListBox LbxDisplay;
    }
}

