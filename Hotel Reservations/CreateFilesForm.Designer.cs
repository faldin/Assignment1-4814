namespace Hotel_Reservations
{
    partial class CreateFilesForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildHotelsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildRoominventoryxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayHotelsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRoominventoryxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisplayHotels = new System.Windows.Forms.Button();
            this.btnLoadHotelsFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildHotelsxmlToolStripMenuItem,
            this.buildRoominventoryxmlToolStripMenuItem,
            this.displayHotelsxmlToolStripMenuItem,
            this.displayRoominventoryxmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // buildHotelsxmlToolStripMenuItem
            // 
            this.buildHotelsxmlToolStripMenuItem.Name = "buildHotelsxmlToolStripMenuItem";
            this.buildHotelsxmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.buildHotelsxmlToolStripMenuItem.Text = "Build Hotels.xml";
            this.buildHotelsxmlToolStripMenuItem.Click += new System.EventHandler(this.buildHotelsxmlToolStripMenuItem_Click);
            // 
            // buildRoominventoryxmlToolStripMenuItem
            // 
            this.buildRoominventoryxmlToolStripMenuItem.Name = "buildRoominventoryxmlToolStripMenuItem";
            this.buildRoominventoryxmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.buildRoominventoryxmlToolStripMenuItem.Text = "Build Roominventory.xml";
            this.buildRoominventoryxmlToolStripMenuItem.Click += new System.EventHandler(this.buildRoominventoryxmlToolStripMenuItem_Click);
            // 
            // displayHotelsxmlToolStripMenuItem
            // 
            this.displayHotelsxmlToolStripMenuItem.Name = "displayHotelsxmlToolStripMenuItem";
            this.displayHotelsxmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayHotelsxmlToolStripMenuItem.Text = "Display Hotels.xml";
            this.displayHotelsxmlToolStripMenuItem.Click += new System.EventHandler(this.displayHotelsxmlToolStripMenuItem_Click);
            // 
            // displayRoominventoryxmlToolStripMenuItem
            // 
            this.displayRoominventoryxmlToolStripMenuItem.Name = "displayRoominventoryxmlToolStripMenuItem";
            this.displayRoominventoryxmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayRoominventoryxmlToolStripMenuItem.Text = "Display Roominventory.xml";
            this.displayRoominventoryxmlToolStripMenuItem.Click += new System.EventHandler(this.displayRoominventoryxmlToolStripMenuItem_Click);
            // 
            // btnDisplayHotels
            // 
            this.btnDisplayHotels.Location = new System.Drawing.Point(12, 126);
            this.btnDisplayHotels.Name = "btnDisplayHotels";
            this.btnDisplayHotels.Size = new System.Drawing.Size(633, 70);
            this.btnDisplayHotels.TabIndex = 6;
            this.btnDisplayHotels.Text = "Create a list of all hotels, and display them in a browser window";
            this.btnDisplayHotels.UseVisualStyleBackColor = true;
            this.btnDisplayHotels.Click += new System.EventHandler(this.btnDisplayHotels_Click);
            // 
            // btnLoadHotelsFile
            // 
            this.btnLoadHotelsFile.Location = new System.Drawing.Point(12, 27);
            this.btnLoadHotelsFile.Name = "btnLoadHotelsFile";
            this.btnLoadHotelsFile.Size = new System.Drawing.Size(633, 70);
            this.btnLoadHotelsFile.TabIndex = 7;
            this.btnLoadHotelsFile.Text = "Load Hotels file (Click this before clicking any other buttons)";
            this.btnLoadHotelsFile.UseVisualStyleBackColor = true;
            this.btnLoadHotelsFile.Click += new System.EventHandler(this.btnLoadHotelsFile_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 286);
            this.Controls.Add(this.btnLoadHotelsFile);
            this.Controls.Add(this.btnDisplayHotels);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildHotelsxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildRoominventoryxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayHotelsxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRoominventoryxmlToolStripMenuItem;
        private System.Windows.Forms.Button btnDisplayHotels;
        private System.Windows.Forms.Button btnLoadHotelsFile;
    }
}

