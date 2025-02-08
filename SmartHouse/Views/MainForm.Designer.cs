namespace SmartHouse
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MnsMain = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            TstMain = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            StsMain = new StatusStrip();
            StlMain = new ToolStripStatusLabel();
            MnsMain.SuspendLayout();
            TstMain.SuspendLayout();
            StsMain.SuspendLayout();
            SuspendLayout();
            // 
            // MnsMain
            // 
            MnsMain.Font = new Font("Segoe UI", 12F);
            MnsMain.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            MnsMain.Location = new Point(0, 0);
            MnsMain.Name = "MnsMain";
            MnsMain.Size = new Size(1205, 29);
            MnsMain.TabIndex = 0;
            MnsMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 25);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Image = (Image)resources.GetObject("выходToolStripMenuItem.Image");
            выходToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(196, 38);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += ApplicationExit_Action;
            // 
            // TstMain
            // 
            TstMain.Font = new Font("Segoe UI", 12F);
            TstMain.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            TstMain.Location = new Point(0, 29);
            TstMain.Name = "TstMain";
            TstMain.Size = new Size(1205, 39);
            TstMain.TabIndex = 1;
            TstMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += ApplicationExit_Action;
            // 
            // StsMain
            // 
            StsMain.Font = new Font("Segoe UI", 12F);
            StsMain.Items.AddRange(new ToolStripItem[] { StlMain });
            StsMain.Location = new Point(0, 589);
            StsMain.Name = "StsMain";
            StsMain.Size = new Size(1205, 26);
            StsMain.TabIndex = 2;
            StsMain.Text = "statusStrip1";
            // 
            // StlMain
            // 
            StlMain.Name = "StlMain";
            StlMain.Size = new Size(1190, 21);
            StlMain.Spring = true;
            StlMain.Text = "Готов";
            StlMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 615);
            Controls.Add(StsMain);
            Controls.Add(TstMain);
            Controls.Add(MnsMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MnsMain;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задание на 08.02.2025";
            WindowState = FormWindowState.Minimized;
            MnsMain.ResumeLayout(false);
            MnsMain.PerformLayout();
            TstMain.ResumeLayout(false);
            TstMain.PerformLayout();
            StsMain.ResumeLayout(false);
            StsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnsMain;
        private ToolStrip TstMain;
        private StatusStrip StsMain;
        private ToolStripStatusLabel StlMain;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripButton toolStripButton1;
    }
}
