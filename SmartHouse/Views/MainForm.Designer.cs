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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MnsMain = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            MniSave = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            TstMain = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            StsMain = new StatusStrip();
            StlMain = new ToolStripStatusLabel();
            ImlAppliances = new ImageList(components);
            TbcMain = new TabControl();
            TbpData = new TabPage();
            LsvAppliances = new ListView();
            ClhImage = new ColumnHeader();
            ClhIdentifier = new ColumnHeader();
            ClhName = new ColumnHeader();
            ClhPower = new ColumnHeader();
            ClhState = new ColumnHeader();
            ClhPrice = new ColumnHeader();
            TbpOrdered = new TabPage();
            TbpSelected = new TabPage();
            MnsMain.SuspendLayout();
            TstMain.SuspendLayout();
            StsMain.SuspendLayout();
            TbcMain.SuspendLayout();
            TbpData.SuspendLayout();
            SuspendLayout();
            // 
            // MnsMain
            // 
            MnsMain.Font = new Font("Segoe UI", 12F);
            MnsMain.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            MnsMain.Location = new Point(0, 0);
            MnsMain.Name = "MnsMain";
            MnsMain.Size = new Size(927, 29);
            MnsMain.TabIndex = 0;
            MnsMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйToolStripMenuItem, toolStripMenuItem1, загрузитьToolStripMenuItem, MniSave, сохранитьКакToolStripMenuItem, toolStripMenuItem2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 25);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            новыйToolStripMenuItem.Size = new Size(209, 38);
            новыйToolStripMenuItem.Text = "Новый";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(206, 6);
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(209, 38);
            загрузитьToolStripMenuItem.Text = "Загрузить...";
            // 
            // MniSave
            // 
            MniSave.Enabled = false;
            MniSave.Name = "MniSave";
            MniSave.Size = new Size(209, 38);
            MniSave.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(209, 38);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(206, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Image = (Image)resources.GetObject("выходToolStripMenuItem.Image");
            выходToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(209, 38);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += ApplicationExit_Action;
            // 
            // TstMain
            // 
            TstMain.Font = new Font("Segoe UI", 12F);
            TstMain.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator1 });
            TstMain.Location = new Point(0, 29);
            TstMain.Name = "TstMain";
            TstMain.Size = new Size(927, 39);
            TstMain.TabIndex = 1;
            TstMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(0, 1, 8, 2);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Выход из приложения";
            toolStripButton1.Click += ApplicationExit_Action;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(62, 36);
            toolStripButton2.Text = "Новый";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(94, 36);
            toolStripButton3.Text = "Загрузить...";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(90, 36);
            toolStripButton4.Text = "Сохранить";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // StsMain
            // 
            StsMain.Font = new Font("Segoe UI", 12F);
            StsMain.Items.AddRange(new ToolStripItem[] { StlMain });
            StsMain.Location = new Point(0, 589);
            StsMain.Name = "StsMain";
            StsMain.Size = new Size(927, 26);
            StsMain.TabIndex = 2;
            StsMain.Text = "statusStrip1";
            // 
            // StlMain
            // 
            StlMain.Name = "StlMain";
            StlMain.Size = new Size(912, 21);
            StlMain.Spring = true;
            StlMain.Text = "Готов";
            StlMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImlAppliances
            // 
            ImlAppliances.ColorDepth = ColorDepth.Depth32Bit;
            ImlAppliances.ImageStream = (ImageListStreamer)resources.GetObject("ImlAppliances.ImageStream");
            ImlAppliances.TransparentColor = Color.Transparent;
            ImlAppliances.Images.SetKeyName(0, "air_cleaner.png");
            ImlAppliances.Images.SetKeyName(1, "air_conditioner.png");
            ImlAppliances.Images.SetKeyName(2, "boiler.png");
            ImlAppliances.Images.SetKeyName(3, "chandelier.png");
            ImlAppliances.Images.SetKeyName(4, "control_panel.png");
            ImlAppliances.Images.SetKeyName(5, "desk_lamp.png");
            ImlAppliances.Images.SetKeyName(6, "dishwasher.png");
            ImlAppliances.Images.SetKeyName(7, "floor_lamp.png");
            ImlAppliances.Images.SetKeyName(8, "freezer.png");
            ImlAppliances.Images.SetKeyName(9, "fridge.png");
            ImlAppliances.Images.SetKeyName(10, "microwave_oven.png");
            ImlAppliances.Images.SetKeyName(11, "radio_station.png");
            ImlAppliances.Images.SetKeyName(12, "tv.png");
            ImlAppliances.Images.SetKeyName(13, "vacuum_cleaner.png");
            ImlAppliances.Images.SetKeyName(14, "washing_machine.png");
            // 
            // TbcMain
            // 
            TbcMain.Controls.Add(TbpData);
            TbcMain.Controls.Add(TbpOrdered);
            TbcMain.Controls.Add(TbpSelected);
            TbcMain.Dock = DockStyle.Fill;
            TbcMain.Font = new Font("Segoe UI", 12F);
            TbcMain.Location = new Point(0, 68);
            TbcMain.Name = "TbcMain";
            TbcMain.SelectedIndex = 0;
            TbcMain.Size = new Size(927, 521);
            TbcMain.TabIndex = 3;
            // 
            // TbpData
            // 
            TbpData.BorderStyle = BorderStyle.FixedSingle;
            TbpData.Controls.Add(LsvAppliances);
            TbpData.Location = new Point(4, 30);
            TbpData.Name = "TbpData";
            TbpData.Padding = new Padding(3);
            TbpData.Size = new Size(919, 487);
            TbpData.TabIndex = 0;
            TbpData.Text = "Приборы квартиры";
            TbpData.UseVisualStyleBackColor = true;
            // 
            // LsvAppliances
            // 
            LsvAppliances.Columns.AddRange(new ColumnHeader[] { ClhImage, ClhIdentifier, ClhName, ClhPower, ClhState, ClhPrice });
            LsvAppliances.Dock = DockStyle.Fill;
            LsvAppliances.FullRowSelect = true;
            LsvAppliances.GridLines = true;
            LsvAppliances.LargeImageList = ImlAppliances;
            LsvAppliances.Location = new Point(3, 3);
            LsvAppliances.Margin = new Padding(8, 3, 8, 3);
            LsvAppliances.MultiSelect = false;
            LsvAppliances.Name = "LsvAppliances";
            LsvAppliances.Size = new Size(911, 479);
            LsvAppliances.SmallImageList = ImlAppliances;
            LsvAppliances.TabIndex = 0;
            LsvAppliances.UseCompatibleStateImageBehavior = false;
            LsvAppliances.View = View.Details;
            // 
            // ClhImage
            // 
            ClhImage.Text = "Усл. изобр.";
            ClhImage.Width = 100;
            // 
            // ClhIdentifier
            // 
            ClhIdentifier.Text = "Ид.";
            ClhIdentifier.Width = 100;
            // 
            // ClhName
            // 
            ClhName.Text = "Наименование";
            ClhName.Width = 240;
            // 
            // ClhPower
            // 
            ClhPower.Text = "Мощность, Вт";
            ClhPower.Width = 180;
            // 
            // ClhState
            // 
            ClhState.Text = "Состояние";
            ClhState.Width = 140;
            // 
            // ClhPrice
            // 
            ClhPrice.Text = "Цена, руб.";
            ClhPrice.Width = 160;
            // 
            // TbpOrdered
            // 
            TbpOrdered.BorderStyle = BorderStyle.FixedSingle;
            TbpOrdered.Location = new Point(4, 30);
            TbpOrdered.Name = "TbpOrdered";
            TbpOrdered.Padding = new Padding(3);
            TbpOrdered.Size = new Size(919, 487);
            TbpOrdered.TabIndex = 1;
            TbpOrdered.Text = "Упорядоченные по ...";
            TbpOrdered.UseVisualStyleBackColor = true;
            // 
            // TbpSelected
            // 
            TbpSelected.BorderStyle = BorderStyle.FixedSingle;
            TbpSelected.Location = new Point(4, 30);
            TbpSelected.Name = "TbpSelected";
            TbpSelected.Padding = new Padding(3);
            TbpSelected.Size = new Size(919, 487);
            TbpSelected.TabIndex = 2;
            TbpSelected.Text = "Выборка по ...";
            TbpSelected.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 615);
            Controls.Add(TbcMain);
            Controls.Add(StsMain);
            Controls.Add(TstMain);
            Controls.Add(MnsMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MnsMain;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задание на 08.02.2025";
            MnsMain.ResumeLayout(false);
            MnsMain.PerformLayout();
            TstMain.ResumeLayout(false);
            TstMain.PerformLayout();
            StsMain.ResumeLayout(false);
            StsMain.PerformLayout();
            TbcMain.ResumeLayout(false);
            TbpData.ResumeLayout(false);
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
        private ImageList ImlAppliances;
        private ToolStripMenuItem новыйToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem MniSave;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private TabControl TbcMain;
        private TabPage TbpData;
        private TabPage TbpOrdered;
        private TabPage TbpSelected;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ListView LsvAppliances;
        private ColumnHeader ClhImage;
        private ColumnHeader ClhIdentifier;
        private ColumnHeader ClhName;
        private ColumnHeader ClhPower;
        private ColumnHeader ClhState;
        private ColumnHeader ClhPrice;
    }
}
