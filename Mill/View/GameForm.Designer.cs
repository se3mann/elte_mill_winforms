namespace Mill
{
    partial class GameForm
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
        private void InitializeComponent()
        {
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._saveGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._closeGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.circularButton2 = new Mill.View.CircularButton();
            this.circularButton1 = new Mill.View.CircularButton();
            this.circularButton3 = new Mill.View.CircularButton();
            this.circularButton4 = new Mill.View.CircularButton();
            this.circularButton5 = new Mill.View.CircularButton();
            this.circularButton6 = new Mill.View.CircularButton();
            this.circularButton7 = new Mill.View.CircularButton();
            this.circularButton8 = new Mill.View.CircularButton();
            this.circularButton9 = new Mill.View.CircularButton();
            this.circularButton10 = new Mill.View.CircularButton();
            this.circularButton11 = new Mill.View.CircularButton();
            this.circularButton12 = new Mill.View.CircularButton();
            this.circularButton13 = new Mill.View.CircularButton();
            this.circularButton14 = new Mill.View.CircularButton();
            this.circularButton15 = new Mill.View.CircularButton();
            this.circularButton16 = new Mill.View.CircularButton();
            this.circularButton17 = new Mill.View.CircularButton();
            this.circularButton18 = new Mill.View.CircularButton();
            this.circularButton19 = new Mill.View.CircularButton();
            this.circularButton20 = new Mill.View.CircularButton();
            this.circularButton21 = new Mill.View.CircularButton();
            this.circularButton22 = new Mill.View.CircularButton();
            this.circularButton23 = new Mill.View.CircularButton();
            this.circularButton24 = new Mill.View.CircularButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._talonNumberPlayer1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this._talonNumberPlayer2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this._currentPlayerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._currentPlayerText = new System.Windows.Forms.ToolStripStatusLabel();
            this._nextStepLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._nextStepLabelText = new System.Windows.Forms.ToolStripStatusLabel();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(700, 28);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newGameMenuItem,
            this.toolStripSeparator1,
            this._saveGameMenuItem,
            this._loadGameMenuItem,
            this.toolStripSeparator2,
            this._closeGameMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this._fileToolStripMenuItem.Text = "Fájl";
            // 
            // _newGameMenuItem
            // 
            this._newGameMenuItem.Name = "_newGameMenuItem";
            this._newGameMenuItem.Size = new System.Drawing.Size(191, 26);
            this._newGameMenuItem.Text = "Új játék";
            this._newGameMenuItem.Click += new System.EventHandler(this._newGameMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // _saveGameMenuItem
            // 
            this._saveGameMenuItem.Name = "_saveGameMenuItem";
            this._saveGameMenuItem.Size = new System.Drawing.Size(191, 26);
            this._saveGameMenuItem.Text = "Játék mentése";
            this._saveGameMenuItem.Click += new System.EventHandler(this.SaveGameMenuItem_Click);
            // 
            // _loadGameMenuItem
            // 
            this._loadGameMenuItem.Name = "_loadGameMenuItem";
            this._loadGameMenuItem.Size = new System.Drawing.Size(191, 26);
            this._loadGameMenuItem.Text = "Játék betöltése";
            this._loadGameMenuItem.Click += new System.EventHandler(this.LoadGameMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // _closeGameMenuItem
            // 
            this._closeGameMenuItem.Name = "_closeGameMenuItem";
            this._closeGameMenuItem.Size = new System.Drawing.Size(191, 26);
            this._closeGameMenuItem.Text = "Kilépés";
            this._closeGameMenuItem.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.circularButton2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.circularButton3, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.circularButton4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.circularButton5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.circularButton6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.circularButton8, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.circularButton9, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.circularButton10, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.circularButton11, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton12, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.circularButton13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.circularButton14, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.circularButton15, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton16, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.circularButton17, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.circularButton18, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.circularButton19, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton20, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.circularButton21, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.circularButton22, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.circularButton23, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.circularButton24, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 700);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // circularButton2
            // 
            this.circularButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton2.Location = new System.Drawing.Point(435, 335);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(30, 30);
            this.circularButton2.TabIndex = 12;
            this.circularButton2.UseVisualStyleBackColor = true;
            this.circularButton2.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton1
            // 
            this.circularButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton1.Location = new System.Drawing.Point(435, 235);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(30, 30);
            this.circularButton1.TabIndex = 8;
            this.circularButton1.UseVisualStyleBackColor = true;
            this.circularButton1.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton3
            // 
            this.circularButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton3.Location = new System.Drawing.Point(435, 435);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(30, 30);
            this.circularButton3.TabIndex = 17;
            this.circularButton3.UseVisualStyleBackColor = true;
            this.circularButton3.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton4
            // 
            this.circularButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton4.Location = new System.Drawing.Point(335, 235);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(30, 30);
            this.circularButton4.TabIndex = 7;
            this.circularButton4.UseVisualStyleBackColor = true;
            this.circularButton4.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton5
            // 
            this.circularButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton5.Location = new System.Drawing.Point(235, 235);
            this.circularButton5.Name = "circularButton5";
            this.circularButton5.Size = new System.Drawing.Size(30, 30);
            this.circularButton5.TabIndex = 6;
            this.circularButton5.UseVisualStyleBackColor = true;
            this.circularButton5.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton6
            // 
            this.circularButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton6.Location = new System.Drawing.Point(235, 335);
            this.circularButton6.Name = "circularButton6";
            this.circularButton6.Size = new System.Drawing.Size(30, 30);
            this.circularButton6.TabIndex = 11;
            this.circularButton6.UseVisualStyleBackColor = true;
            this.circularButton6.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton7
            // 
            this.circularButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton7.Location = new System.Drawing.Point(235, 435);
            this.circularButton7.Name = "circularButton7";
            this.circularButton7.Size = new System.Drawing.Size(30, 30);
            this.circularButton7.TabIndex = 15;
            this.circularButton7.UseVisualStyleBackColor = true;
            this.circularButton7.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton8
            // 
            this.circularButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton8.Location = new System.Drawing.Point(335, 435);
            this.circularButton8.Name = "circularButton8";
            this.circularButton8.Size = new System.Drawing.Size(30, 30);
            this.circularButton8.TabIndex = 16;
            this.circularButton8.UseVisualStyleBackColor = true;
            this.circularButton8.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton9
            // 
            this.circularButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton9.Location = new System.Drawing.Point(335, 535);
            this.circularButton9.Name = "circularButton9";
            this.circularButton9.Size = new System.Drawing.Size(30, 30);
            this.circularButton9.TabIndex = 19;
            this.circularButton9.UseVisualStyleBackColor = true;
            this.circularButton9.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton10
            // 
            this.circularButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton10.Location = new System.Drawing.Point(535, 535);
            this.circularButton10.Name = "circularButton10";
            this.circularButton10.Size = new System.Drawing.Size(30, 30);
            this.circularButton10.TabIndex = 20;
            this.circularButton10.UseVisualStyleBackColor = true;
            this.circularButton10.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton11
            // 
            this.circularButton11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton11.Location = new System.Drawing.Point(535, 335);
            this.circularButton11.Name = "circularButton11";
            this.circularButton11.Size = new System.Drawing.Size(30, 30);
            this.circularButton11.TabIndex = 13;
            this.circularButton11.UseVisualStyleBackColor = true;
            this.circularButton11.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton12
            // 
            this.circularButton12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton12.Location = new System.Drawing.Point(535, 135);
            this.circularButton12.Name = "circularButton12";
            this.circularButton12.Size = new System.Drawing.Size(30, 30);
            this.circularButton12.TabIndex = 5;
            this.circularButton12.UseVisualStyleBackColor = true;
            this.circularButton12.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton13
            // 
            this.circularButton13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton13.Location = new System.Drawing.Point(335, 135);
            this.circularButton13.Name = "circularButton13";
            this.circularButton13.Size = new System.Drawing.Size(30, 30);
            this.circularButton13.TabIndex = 4;
            this.circularButton13.UseVisualStyleBackColor = true;
            this.circularButton13.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton14
            // 
            this.circularButton14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton14.Location = new System.Drawing.Point(135, 135);
            this.circularButton14.Name = "circularButton14";
            this.circularButton14.Size = new System.Drawing.Size(30, 30);
            this.circularButton14.TabIndex = 3;
            this.circularButton14.UseVisualStyleBackColor = true;
            this.circularButton14.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton15
            // 
            this.circularButton15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton15.Location = new System.Drawing.Point(135, 335);
            this.circularButton15.Name = "circularButton15";
            this.circularButton15.Size = new System.Drawing.Size(30, 30);
            this.circularButton15.TabIndex = 10;
            this.circularButton15.UseVisualStyleBackColor = true;
            this.circularButton15.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton16
            // 
            this.circularButton16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton16.Location = new System.Drawing.Point(135, 535);
            this.circularButton16.Name = "circularButton16";
            this.circularButton16.Size = new System.Drawing.Size(30, 30);
            this.circularButton16.TabIndex = 18;
            this.circularButton16.UseVisualStyleBackColor = true;
            this.circularButton16.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton17
            // 
            this.circularButton17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton17.Location = new System.Drawing.Point(335, 635);
            this.circularButton17.Name = "circularButton17";
            this.circularButton17.Size = new System.Drawing.Size(30, 30);
            this.circularButton17.TabIndex = 22;
            this.circularButton17.UseVisualStyleBackColor = true;
            this.circularButton17.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton18
            // 
            this.circularButton18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton18.Location = new System.Drawing.Point(635, 635);
            this.circularButton18.Name = "circularButton18";
            this.circularButton18.Size = new System.Drawing.Size(30, 30);
            this.circularButton18.TabIndex = 23;
            this.circularButton18.UseVisualStyleBackColor = true;
            this.circularButton18.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton19
            // 
            this.circularButton19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton19.Location = new System.Drawing.Point(635, 335);
            this.circularButton19.Name = "circularButton19";
            this.circularButton19.Size = new System.Drawing.Size(30, 30);
            this.circularButton19.TabIndex = 14;
            this.circularButton19.UseVisualStyleBackColor = true;
            this.circularButton19.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton20
            // 
            this.circularButton20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton20.Location = new System.Drawing.Point(635, 35);
            this.circularButton20.Name = "circularButton20";
            this.circularButton20.Size = new System.Drawing.Size(30, 30);
            this.circularButton20.TabIndex = 2;
            this.circularButton20.UseVisualStyleBackColor = true;
            this.circularButton20.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton21
            // 
            this.circularButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton21.Location = new System.Drawing.Point(335, 35);
            this.circularButton21.Name = "circularButton21";
            this.circularButton21.Size = new System.Drawing.Size(30, 30);
            this.circularButton21.TabIndex = 1;
            this.circularButton21.UseVisualStyleBackColor = true;
            this.circularButton21.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton22
            // 
            this.circularButton22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton22.Location = new System.Drawing.Point(35, 35);
            this.circularButton22.Name = "circularButton22";
            this.circularButton22.Size = new System.Drawing.Size(30, 30);
            this.circularButton22.TabIndex = 0;
            this.circularButton22.UseVisualStyleBackColor = true;
            this.circularButton22.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton23
            // 
            this.circularButton23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton23.Location = new System.Drawing.Point(35, 335);
            this.circularButton23.Name = "circularButton23";
            this.circularButton23.Size = new System.Drawing.Size(30, 30);
            this.circularButton23.TabIndex = 9;
            this.circularButton23.UseVisualStyleBackColor = true;
            this.circularButton23.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // circularButton24
            // 
            this.circularButton24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularButton24.Location = new System.Drawing.Point(35, 635);
            this.circularButton24.Name = "circularButton24";
            this.circularButton24.Size = new System.Drawing.Size(30, 30);
            this.circularButton24.TabIndex = 21;
            this.circularButton24.UseVisualStyleBackColor = true;
            this.circularButton24.Click += new System.EventHandler(this.FieldButtonClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._talonNumberPlayer1,
            this.toolStripStatusLabel3,
            this._talonNumberPlayer2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 24);
            this.toolStripStatusLabel1.Text = "Játékos 1 talon: ";
            // 
            // _talonNumberPlayer1
            // 
            this._talonNumberPlayer1.Name = "_talonNumberPlayer1";
            this._talonNumberPlayer1.Size = new System.Drawing.Size(17, 24);
            this._talonNumberPlayer1.Text = "9";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(114, 24);
            this.toolStripStatusLabel3.Text = "Játékos 2 talon: ";
            // 
            // _talonNumberPlayer2
            // 
            this._talonNumberPlayer2.Name = "_talonNumberPlayer2";
            this._talonNumberPlayer2.Size = new System.Drawing.Size(17, 24);
            this._talonNumberPlayer2.Text = "9";
            // 
            // statusStrip2
            // 
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._currentPlayerLabel,
            this._currentPlayerText,
            this._nextStepLabel,
            this._nextStepLabelText});
            this.statusStrip2.Location = new System.Drawing.Point(0, 738);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(700, 30);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // _currentPlayerLabel
            // 
            this._currentPlayerLabel.Name = "_currentPlayerLabel";
            this._currentPlayerLabel.Size = new System.Drawing.Size(115, 24);
            this._currentPlayerLabel.Text = "Aktuális játékos:";
            // 
            // _currentPlayerText
            // 
            this._currentPlayerText.Name = "_currentPlayerText";
            this._currentPlayerText.Size = new System.Drawing.Size(69, 24);
            this._currentPlayerText.Text = "Játékos 1";
            // 
            // _nextStepLabel
            // 
            this._nextStepLabel.Name = "_nextStepLabel";
            this._nextStepLabel.Size = new System.Drawing.Size(120, 24);
            this._nextStepLabel.Text = "Következő lépés:";
            // 
            // _nextStepLabelText
            // 
            this._nextStepLabelText.Name = "_nextStepLabelText";
            this._nextStepLabelText.Size = new System.Drawing.Size(121, 24);
            this._nextStepLabelText.Text = "A játékos lépése!";
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.Filter = "Malom tábla (*.mtl)|*.mtl";
            this._saveFileDialog.Title = "Malom játék mentése";
            // 
            // _openFileDialog
            // 
            this._openFileDialog.Filter = "Malom tábla (*.mtl)|*.mtl";
            this._openFileDialog.Title = "Malom játék betöltése";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 798);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "GameForm";
            this.Text = "Malom";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip _menuStrip;
        private ToolStripMenuItem _fileToolStripMenuItem;
        private ToolStripMenuItem _newGameMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem _saveGameMenuItem;
        private ToolStripMenuItem _loadGameMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem _closeGameMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private View.CircularButton circularButton1;
        private View.CircularButton circularButton2;
        private View.CircularButton circularButton3;
        private View.CircularButton circularButton4;
        private View.CircularButton circularButton5;
        private View.CircularButton circularButton6;
        private View.CircularButton circularButton7;
        private View.CircularButton circularButton8;
        private View.CircularButton circularButton9;
        private View.CircularButton circularButton10;
        private View.CircularButton circularButton11;
        private View.CircularButton circularButton12;
        private View.CircularButton circularButton13;
        private View.CircularButton circularButton14;
        private View.CircularButton circularButton15;
        private View.CircularButton circularButton16;
        private View.CircularButton circularButton17;
        private View.CircularButton circularButton18;
        private View.CircularButton circularButton19;
        private View.CircularButton circularButton20;
        private View.CircularButton circularButton21;
        private View.CircularButton circularButton22;
        private View.CircularButton circularButton23;
        private View.CircularButton circularButton24;
        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel _currentPlayerLabel;
        private ToolStripStatusLabel _currentPlayerText;
        private ToolStripStatusLabel _nextStepLabel;
        private ToolStripStatusLabel _nextStepLabelText;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel _talonNumberPlayer1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel _talonNumberPlayer2;
        private SaveFileDialog _saveFileDialog;
        private OpenFileDialog _openFileDialog;
    }
}