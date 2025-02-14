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
            упорядочитьToolStripMenuItem = new ToolStripMenuItem();
            поНазваниюЭлектроприбораToolStripMenuItem = new ToolStripMenuItem();
            поУбываниюМощностиToolStripMenuItem = new ToolStripMenuItem();
            поЦенеToolStripMenuItem = new ToolStripMenuItem();
            поСостояниюToolStripMenuItem = new ToolStripMenuItem();
            выборкмToolStripMenuItem = new ToolStripMenuItem();
            приборыСМинимальнойМтоимостьюToolStripMenuItem = new ToolStripMenuItem();
            приборыСЗаданнымНазваниемToolStripMenuItem = new ToolStripMenuItem();
            приборыСЗаданнымСостояниемToolStripMenuItem = new ToolStripMenuItem();
            приборыСЗаданнойМощностьюToolStripMenuItem = new ToolStripMenuItem();
            средстваToolStripMenuItem = new ToolStripMenuItem();
            шрифтИЦветВыводаToolStripMenuItem = new ToolStripMenuItem();
            цветФонаВыводаПриборовToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            сворачиватьАТрейToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
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
            LsvOrdered = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            TbpSelected = new TabPage();
            LsvSelected = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            MnsMain.SuspendLayout();
            TstMain.SuspendLayout();
            StsMain.SuspendLayout();
            TbcMain.SuspendLayout();
            TbpData.SuspendLayout();
            TbpOrdered.SuspendLayout();
            TbpSelected.SuspendLayout();
            SuspendLayout();
            // 
            // MnsMain
            // 
            MnsMain.Font = new Font("Segoe UI", 12F);
            MnsMain.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, упорядочитьToolStripMenuItem, выборкмToolStripMenuItem, средстваToolStripMenuItem, справкаToolStripMenuItem });
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
            // упорядочитьToolStripMenuItem
            // 
            упорядочитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поНазваниюЭлектроприбораToolStripMenuItem, поУбываниюМощностиToolStripMenuItem, поЦенеToolStripMenuItem, поСостояниюToolStripMenuItem });
            упорядочитьToolStripMenuItem.Name = "упорядочитьToolStripMenuItem";
            упорядочитьToolStripMenuItem.Size = new Size(117, 25);
            упорядочитьToolStripMenuItem.Text = "Упорядочить";
            // 
            // поНазваниюЭлектроприбораToolStripMenuItem
            // 
            поНазваниюЭлектроприбораToolStripMenuItem.Name = "поНазваниюЭлектроприбораToolStripMenuItem";
            поНазваниюЭлектроприбораToolStripMenuItem.Size = new Size(297, 26);
            поНазваниюЭлектроприбораToolStripMenuItem.Text = "По названию электроприбора";
            поНазваниюЭлектроприбораToolStripMenuItem.Click += OrderByName_Action;
            // 
            // поУбываниюМощностиToolStripMenuItem
            // 
            поУбываниюМощностиToolStripMenuItem.Name = "поУбываниюМощностиToolStripMenuItem";
            поУбываниюМощностиToolStripMenuItem.Size = new Size(297, 26);
            поУбываниюМощностиToolStripMenuItem.Text = "По убыванию мощности";
            поУбываниюМощностиToolStripMenuItem.Click += OrderByPowerDesc_Action;
            // 
            // поЦенеToolStripMenuItem
            // 
            поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            поЦенеToolStripMenuItem.Size = new Size(297, 26);
            поЦенеToolStripMenuItem.Text = "По цене";
            поЦенеToolStripMenuItem.Click += OrderByPrice_Action;
            // 
            // поСостояниюToolStripMenuItem
            // 
            поСостояниюToolStripMenuItem.Name = "поСостояниюToolStripMenuItem";
            поСостояниюToolStripMenuItem.Size = new Size(297, 26);
            поСостояниюToolStripMenuItem.Text = "По состоянию";
            поСостояниюToolStripMenuItem.Click += OrderByState_Action;
            // 
            // выборкмToolStripMenuItem
            // 
            выборкмToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { приборыСМинимальнойМтоимостьюToolStripMenuItem, приборыСЗаданнымНазваниемToolStripMenuItem, приборыСЗаданнымСостояниемToolStripMenuItem, приборыСЗаданнойМощностьюToolStripMenuItem });
            выборкмToolStripMenuItem.Name = "выборкмToolStripMenuItem";
            выборкмToolStripMenuItem.Size = new Size(86, 25);
            выборкмToolStripMenuItem.Text = "Выборки";
            // 
            // приборыСМинимальнойМтоимостьюToolStripMenuItem
            // 
            приборыСМинимальнойМтоимостьюToolStripMenuItem.Name = "приборыСМинимальнойМтоимостьюToolStripMenuItem";
            приборыСМинимальнойМтоимостьюToolStripMenuItem.Size = new Size(357, 26);
            приборыСМинимальнойМтоимостьюToolStripMenuItem.Text = "Приборы с минимальной мтоимостью";
            // 
            // приборыСЗаданнымНазваниемToolStripMenuItem
            // 
            приборыСЗаданнымНазваниемToolStripMenuItem.Name = "приборыСЗаданнымНазваниемToolStripMenuItem";
            приборыСЗаданнымНазваниемToolStripMenuItem.Size = new Size(357, 26);
            приборыСЗаданнымНазваниемToolStripMenuItem.Text = "Приборы с заданным названием";
            // 
            // приборыСЗаданнымСостояниемToolStripMenuItem
            // 
            приборыСЗаданнымСостояниемToolStripMenuItem.Name = "приборыСЗаданнымСостояниемToolStripMenuItem";
            приборыСЗаданнымСостояниемToolStripMenuItem.Size = new Size(357, 26);
            приборыСЗаданнымСостояниемToolStripMenuItem.Text = "Приборы с заданным состоянием";
            // 
            // приборыСЗаданнойМощностьюToolStripMenuItem
            // 
            приборыСЗаданнойМощностьюToolStripMenuItem.Name = "приборыСЗаданнойМощностьюToolStripMenuItem";
            приборыСЗаданнойМощностьюToolStripMenuItem.Size = new Size(357, 26);
            приборыСЗаданнойМощностьюToolStripMenuItem.Text = "Приборы с заданной мощностью";
            // 
            // средстваToolStripMenuItem
            // 
            средстваToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтИЦветВыводаToolStripMenuItem, цветФонаВыводаПриборовToolStripMenuItem, toolStripMenuItem3, сворачиватьАТрейToolStripMenuItem });
            средстваToolStripMenuItem.Name = "средстваToolStripMenuItem";
            средстваToolStripMenuItem.Size = new Size(88, 25);
            средстваToolStripMenuItem.Text = "Средства";
            // 
            // шрифтИЦветВыводаToolStripMenuItem
            // 
            шрифтИЦветВыводаToolStripMenuItem.Name = "шрифтИЦветВыводаToolStripMenuItem";
            шрифтИЦветВыводаToolStripMenuItem.Size = new Size(322, 26);
            шрифтИЦветВыводаToolStripMenuItem.Text = "Шрифт и цвет вывода приборов...";
            // 
            // цветФонаВыводаПриборовToolStripMenuItem
            // 
            цветФонаВыводаПриборовToolStripMenuItem.Name = "цветФонаВыводаПриборовToolStripMenuItem";
            цветФонаВыводаПриборовToolStripMenuItem.Size = new Size(322, 26);
            цветФонаВыводаПриборовToolStripMenuItem.Text = "Цвет фона вывода приборов...";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(319, 6);
            // 
            // сворачиватьАТрейToolStripMenuItem
            // 
            сворачиватьАТрейToolStripMenuItem.Name = "сворачиватьАТрейToolStripMenuItem";
            сворачиватьАТрейToolStripMenuItem.Size = new Size(322, 26);
            сворачиватьАТрейToolStripMenuItem.Text = "Сворачивать а трей";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(82, 25);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(185, 26);
            оПрограммеToolStripMenuItem.Text = "О программе...";
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
            toolStripButton2.Click += NewApartment_Action;
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
            TbpOrdered.Controls.Add(LsvOrdered);
            TbpOrdered.Location = new Point(4, 30);
            TbpOrdered.Name = "TbpOrdered";
            TbpOrdered.Padding = new Padding(3);
            TbpOrdered.Size = new Size(919, 487);
            TbpOrdered.TabIndex = 1;
            TbpOrdered.Text = "Упорядоченные по ...";
            TbpOrdered.UseVisualStyleBackColor = true;
            // 
            // LsvOrdered
            // 
            LsvOrdered.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            LsvOrdered.Dock = DockStyle.Fill;
            LsvOrdered.FullRowSelect = true;
            LsvOrdered.GridLines = true;
            LsvOrdered.LargeImageList = ImlAppliances;
            LsvOrdered.Location = new Point(3, 3);
            LsvOrdered.Margin = new Padding(8, 3, 8, 3);
            LsvOrdered.MultiSelect = false;
            LsvOrdered.Name = "LsvOrdered";
            LsvOrdered.Size = new Size(911, 479);
            LsvOrdered.SmallImageList = ImlAppliances;
            LsvOrdered.TabIndex = 1;
            LsvOrdered.UseCompatibleStateImageBehavior = false;
            LsvOrdered.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Усл. изобр.";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ид.";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Наименование";
            columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Мощность, Вт";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Состояние";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Цена, руб.";
            columnHeader6.Width = 160;
            // 
            // TbpSelected
            // 
            TbpSelected.BorderStyle = BorderStyle.FixedSingle;
            TbpSelected.Controls.Add(LsvSelected);
            TbpSelected.Location = new Point(4, 30);
            TbpSelected.Name = "TbpSelected";
            TbpSelected.Padding = new Padding(3);
            TbpSelected.Size = new Size(919, 487);
            TbpSelected.TabIndex = 2;
            TbpSelected.Text = "Выборка по ...";
            TbpSelected.UseVisualStyleBackColor = true;
            // 
            // LsvSelected
            // 
            LsvSelected.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            LsvSelected.Dock = DockStyle.Fill;
            LsvSelected.FullRowSelect = true;
            LsvSelected.GridLines = true;
            LsvSelected.LargeImageList = ImlAppliances;
            LsvSelected.Location = new Point(3, 3);
            LsvSelected.Margin = new Padding(8, 3, 8, 3);
            LsvSelected.MultiSelect = false;
            LsvSelected.Name = "LsvSelected";
            LsvSelected.Size = new Size(911, 479);
            LsvSelected.SmallImageList = ImlAppliances;
            LsvSelected.TabIndex = 1;
            LsvSelected.UseCompatibleStateImageBehavior = false;
            LsvSelected.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Усл. изобр.";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ид.";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Наименование";
            columnHeader9.Width = 240;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Мощность, Вт";
            columnHeader10.Width = 180;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Состояние";
            columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Цена, руб.";
            columnHeader12.Width = 160;
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
            TbpOrdered.ResumeLayout(false);
            TbpSelected.ResumeLayout(false);
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
        private ListView LsvOrdered;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView LsvSelected;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ToolStripMenuItem упорядочитьToolStripMenuItem;
        private ToolStripMenuItem выборкмToolStripMenuItem;
        private ToolStripMenuItem средстваToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem шрифтИЦветВыводаToolStripMenuItem;
        private ToolStripMenuItem цветФонаВыводаПриборовToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem поНазваниюЭлектроприбораToolStripMenuItem;
        private ToolStripMenuItem поУбываниюМощностиToolStripMenuItem;
        private ToolStripMenuItem поЦенеToolStripMenuItem;
        private ToolStripMenuItem поСостояниюToolStripMenuItem;
        private ToolStripMenuItem приборыСМинимальнойМтоимостьюToolStripMenuItem;
        private ToolStripMenuItem приборыСЗаданнымНазваниемToolStripMenuItem;
        private ToolStripMenuItem приборыСЗаданнымСостояниемToolStripMenuItem;
        private ToolStripMenuItem приборыСЗаданнойМощностьюToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem сворачиватьАТрейToolStripMenuItem;
    }
}
