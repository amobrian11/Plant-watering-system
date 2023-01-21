namespace PRJ_Auto_Watering
{
    partial class Main
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
            this.lbxPlantName = new System.Windows.Forms.ListBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblMoisture = new System.Windows.Forms.Label();
            this.pbxPlant = new System.Windows.Forms.PictureBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addEditPlantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlImage.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlant)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPlantName
            // 
            this.lbxPlantName.FormattingEnabled = true;
            this.lbxPlantName.Location = new System.Drawing.Point(341, 264);
            this.lbxPlantName.Name = "lbxPlantName";
            this.lbxPlantName.Size = new System.Drawing.Size(124, 17);
            this.lbxPlantName.TabIndex = 0;
            this.lbxPlantName.SelectedIndexChanged += new System.EventHandler(this.lbxPlantName_SelectedIndexChanged);
            this.lbxPlantName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbxPlantName_KeyPress);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbxPlant);
            this.pnlImage.Location = new System.Drawing.Point(276, 64);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(250, 194);
            this.pnlImage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plant Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.rtxtDescription);
            this.pnlDescription.Location = new System.Drawing.Point(137, 325);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(543, 114);
            this.pnlDescription.TabIndex = 3;
            // 
            // lblMoisture
            // 
            this.lblMoisture.AutoSize = true;
            this.lblMoisture.Location = new System.Drawing.Point(304, 297);
            this.lblMoisture.Name = "lblMoisture";
            this.lblMoisture.Size = new System.Drawing.Size(120, 13);
            this.lblMoisture.TabIndex = 4;
            this.lblMoisture.Text = "Optimal Moisture Level: ";
            // 
            // pbxPlant
            // 
            this.pbxPlant.Location = new System.Drawing.Point(11, 12);
            this.pbxPlant.Name = "pbxPlant";
            this.pbxPlant.Size = new System.Drawing.Size(229, 170);
            this.pbxPlant.TabIndex = 0;
            this.pbxPlant.TabStop = false;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(18, 12);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(509, 87);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditPlantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEditPlantsToolStripMenuItem
            // 
            this.addEditPlantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.addEditPlantsToolStripMenuItem.Name = "addEditPlantsToolStripMenuItem";
            this.addEditPlantsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.addEditPlantsToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Add/Edit Plants";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "AI Statistics";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoisture);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.lbxPlantName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.pnlImage.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlant)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPlantName;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblMoisture;
        private System.Windows.Forms.PictureBox pbxPlant;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEditPlantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}