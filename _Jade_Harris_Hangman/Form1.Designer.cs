namespace _Jade_Harris_Hangman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nextButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.placeholderDisplay = new System.Windows.Forms.TextBox();
            this.letterGuessed = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.loadingScreen = new System.Windows.Forms.TextBox();
            this.chosenWord = new System.Windows.Forms.TextBox();
            this.correctWord = new System.Windows.Forms.TextBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.titleScreen = new System.Windows.Forms.PictureBox();
            this.animatedImage = new System.Windows.Forms.PictureBox();
            this.guessedLetterBackground = new System.Windows.Forms.PictureBox();
            this.staticImage = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.Button();
            this.o = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.j = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.keyboardBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessedLetterBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.GhostWhite;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.Purple;
            this.nextButton.Location = new System.Drawing.Point(861, 332);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(121, 41);
            this.nextButton.TabIndex = 127;
            this.nextButton.TabStop = false;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(457, 530);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(254, 52);
            this.startButton.TabIndex = 124;
            this.startButton.TabStop = false;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // placeholderDisplay
            // 
            this.placeholderDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeholderDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.placeholderDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderDisplay.Location = new System.Drawing.Point(-1, 34);
            this.placeholderDisplay.Name = "placeholderDisplay";
            this.placeholderDisplay.ReadOnly = true;
            this.placeholderDisplay.Size = new System.Drawing.Size(1091, 53);
            this.placeholderDisplay.TabIndex = 123;
            this.placeholderDisplay.TabStop = false;
            this.placeholderDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterGuessed
            // 
            this.letterGuessed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.letterGuessed.Cursor = System.Windows.Forms.Cursors.Default;
            this.letterGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterGuessed.Location = new System.Drawing.Point(-1, 488);
            this.letterGuessed.MaxLength = 1;
            this.letterGuessed.Name = "letterGuessed";
            this.letterGuessed.ReadOnly = true;
            this.letterGuessed.Size = new System.Drawing.Size(923, 34);
            this.letterGuessed.TabIndex = 121;
            this.letterGuessed.TabStop = false;
            this.letterGuessed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkGray;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(1007, 486);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 39);
            this.resetButton.TabIndex = 111;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // loadingScreen
            // 
            this.loadingScreen.BackColor = System.Drawing.SystemColors.MenuText;
            this.loadingScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadingScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.loadingScreen.Location = new System.Drawing.Point(503, 282);
            this.loadingScreen.Name = "loadingScreen";
            this.loadingScreen.Size = new System.Drawing.Size(180, 91);
            this.loadingScreen.TabIndex = 132;
            this.loadingScreen.TabStop = false;
            // 
            // chosenWord
            // 
            this.chosenWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.chosenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenWord.Location = new System.Drawing.Point(335, 136);
            this.chosenWord.Name = "chosenWord";
            this.chosenWord.ReadOnly = true;
            this.chosenWord.Size = new System.Drawing.Size(503, 53);
            this.chosenWord.TabIndex = 122;
            this.chosenWord.TabStop = false;
            this.chosenWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chosenWord.Visible = false;
            // 
            // correctWord
            // 
            this.correctWord.BackColor = System.Drawing.Color.Purple;
            this.correctWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correctWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctWord.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.correctWord.Location = new System.Drawing.Point(-1, 90);
            this.correctWord.Name = "correctWord";
            this.correctWord.Size = new System.Drawing.Size(1091, 23);
            this.correctWord.TabIndex = 137;
            this.correctWord.TabStop = false;
            this.correctWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correctWord.Visible = false;
            // 
            // icon
            // 
            this.icon.Image = global::_Jade_Harris_Hangman.Properties.Resources.Icon0;
            this.icon.Location = new System.Drawing.Point(936, 1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(140, 133);
            this.icon.TabIndex = 136;
            this.icon.TabStop = false;
            // 
            // titleScreen
            // 
            this.titleScreen.Image = ((System.Drawing.Image)(resources.GetObject("titleScreen.Image")));
            this.titleScreen.Location = new System.Drawing.Point(-1, 84);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(1091, 507);
            this.titleScreen.TabIndex = 133;
            this.titleScreen.TabStop = false;
            // 
            // animatedImage
            // 
            this.animatedImage.Image = global::_Jade_Harris_Hangman.Properties.Resources.Static0;
            this.animatedImage.Location = new System.Drawing.Point(359, 90);
            this.animatedImage.Name = "animatedImage";
            this.animatedImage.Size = new System.Drawing.Size(431, 473);
            this.animatedImage.TabIndex = 130;
            this.animatedImage.TabStop = false;
            this.animatedImage.Visible = false;
            // 
            // guessedLetterBackground
            // 
            this.guessedLetterBackground.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessedLetterBackground.Location = new System.Drawing.Point(-1, 487);
            this.guessedLetterBackground.Name = "guessedLetterBackground";
            this.guessedLetterBackground.Size = new System.Drawing.Size(923, 38);
            this.guessedLetterBackground.TabIndex = 135;
            this.guessedLetterBackground.TabStop = false;
            // 
            // staticImage
            // 
            this.staticImage.Image = global::_Jade_Harris_Hangman.Properties.Resources.Static0;
            this.staticImage.Location = new System.Drawing.Point(457, 136);
            this.staticImage.Name = "staticImage";
            this.staticImage.Size = new System.Drawing.Size(226, 248);
            this.staticImage.TabIndex = 129;
            this.staticImage.TabStop = false;
            this.staticImage.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitButton.BackgroundImage")));
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Enabled = false;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.DarkMagenta;
            this.submitButton.Location = new System.Drawing.Point(502, 427);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 58);
            this.submitButton.TabIndex = 90;
            this.submitButton.TabStop = false;
            this.submitButton.Text = "⮞ SUBMIT GUESS";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(923, 486);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 39);
            this.deleteButton.TabIndex = 112;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "DEL";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // l
            // 
            this.l.AccessibleName = "";
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("l.BackgroundImage")));
            this.l.Cursor = System.Windows.Forms.Cursors.Default;
            this.l.Enabled = false;
            this.l.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.l.FlatAppearance.BorderSize = 0;
            this.l.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.l.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(923, 526);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(83, 84);
            this.l.TabIndex = 109;
            this.l.TabStop = false;
            this.l.Text = "L";
            this.l.UseVisualStyleBackColor = false;
            this.l.Click += new System.EventHandler(this.Letter_Click);
            // 
            // i
            // 
            this.i.AccessibleName = "";
            this.i.BackColor = System.Drawing.Color.Transparent;
            this.i.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("i.BackgroundImage")));
            this.i.Cursor = System.Windows.Forms.Cursors.Default;
            this.i.Enabled = false;
            this.i.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.i.FlatAppearance.BorderSize = 0;
            this.i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.ForeColor = System.Drawing.Color.White;
            this.i.Location = new System.Drawing.Point(671, 526);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(83, 84);
            this.i.TabIndex = 110;
            this.i.TabStop = false;
            this.i.Text = "I";
            this.i.UseVisualStyleBackColor = false;
            this.i.Click += new System.EventHandler(this.Letter_Click);
            // 
            // o
            // 
            this.o.AccessibleName = "";
            this.o.BackColor = System.Drawing.Color.Transparent;
            this.o.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("o.BackgroundImage")));
            this.o.Cursor = System.Windows.Forms.Cursors.Default;
            this.o.Enabled = false;
            this.o.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.o.FlatAppearance.BorderSize = 0;
            this.o.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.o.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.o.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.ForeColor = System.Drawing.Color.White;
            this.o.Location = new System.Drawing.Point(83, 611);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(83, 84);
            this.o.TabIndex = 108;
            this.o.TabStop = false;
            this.o.Text = "O";
            this.o.UseVisualStyleBackColor = false;
            this.o.Click += new System.EventHandler(this.Letter_Click);
            // 
            // x
            // 
            this.x.AccessibleName = "";
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x.BackgroundImage")));
            this.x.Cursor = System.Windows.Forms.Cursors.Default;
            this.x.Enabled = false;
            this.x.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.x.FlatAppearance.BorderSize = 0;
            this.x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.White;
            this.x.Location = new System.Drawing.Point(839, 611);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(83, 84);
            this.x.TabIndex = 106;
            this.x.TabStop = false;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.Letter_Click);
            // 
            // u
            // 
            this.u.AccessibleName = "";
            this.u.BackColor = System.Drawing.Color.Transparent;
            this.u.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("u.BackgroundImage")));
            this.u.Cursor = System.Windows.Forms.Cursors.Default;
            this.u.Enabled = false;
            this.u.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.u.FlatAppearance.BorderSize = 0;
            this.u.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.u.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.u.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u.ForeColor = System.Drawing.Color.White;
            this.u.Location = new System.Drawing.Point(587, 611);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(83, 84);
            this.u.TabIndex = 107;
            this.u.TabStop = false;
            this.u.Text = "U";
            this.u.UseVisualStyleBackColor = false;
            this.u.Click += new System.EventHandler(this.Letter_Click);
            // 
            // k
            // 
            this.k.AccessibleName = "";
            this.k.BackColor = System.Drawing.Color.Transparent;
            this.k.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("k.BackgroundImage")));
            this.k.Cursor = System.Windows.Forms.Cursors.Default;
            this.k.Enabled = false;
            this.k.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.k.FlatAppearance.BorderSize = 0;
            this.k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.k.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k.ForeColor = System.Drawing.Color.White;
            this.k.Location = new System.Drawing.Point(839, 526);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(83, 84);
            this.k.TabIndex = 104;
            this.k.TabStop = false;
            this.k.Text = "K";
            this.k.UseVisualStyleBackColor = false;
            this.k.Click += new System.EventHandler(this.Letter_Click);
            // 
            // h
            // 
            this.h.AccessibleName = "";
            this.h.BackColor = System.Drawing.Color.Transparent;
            this.h.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("h.BackgroundImage")));
            this.h.Cursor = System.Windows.Forms.Cursors.Default;
            this.h.Enabled = false;
            this.h.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.h.FlatAppearance.BorderSize = 0;
            this.h.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.h.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.ForeColor = System.Drawing.Color.White;
            this.h.Location = new System.Drawing.Point(587, 526);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(83, 84);
            this.h.TabIndex = 105;
            this.h.TabStop = false;
            this.h.Text = "H";
            this.h.UseVisualStyleBackColor = false;
            this.h.Click += new System.EventHandler(this.Letter_Click);
            // 
            // r
            // 
            this.r.AccessibleName = "";
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("r.BackgroundImage")));
            this.r.Cursor = System.Windows.Forms.Cursors.Default;
            this.r.Enabled = false;
            this.r.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.r.FlatAppearance.BorderSize = 0;
            this.r.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.r.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.ForeColor = System.Drawing.Color.White;
            this.r.Location = new System.Drawing.Point(335, 611);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(83, 84);
            this.r.TabIndex = 103;
            this.r.TabStop = false;
            this.r.Text = "R";
            this.r.UseVisualStyleBackColor = false;
            this.r.Click += new System.EventHandler(this.Letter_Click);
            // 
            // q
            // 
            this.q.AccessibleName = "";
            this.q.BackColor = System.Drawing.Color.Transparent;
            this.q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q.BackgroundImage")));
            this.q.Cursor = System.Windows.Forms.Cursors.Default;
            this.q.Enabled = false;
            this.q.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.q.FlatAppearance.BorderSize = 0;
            this.q.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.q.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.ForeColor = System.Drawing.Color.White;
            this.q.Location = new System.Drawing.Point(251, 611);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(83, 84);
            this.q.TabIndex = 102;
            this.q.TabStop = false;
            this.q.Text = "Q";
            this.q.UseVisualStyleBackColor = false;
            this.q.Click += new System.EventHandler(this.Letter_Click);
            // 
            // f
            // 
            this.f.AccessibleName = "";
            this.f.BackColor = System.Drawing.Color.Transparent;
            this.f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f.BackgroundImage")));
            this.f.Cursor = System.Windows.Forms.Cursors.Default;
            this.f.Enabled = false;
            this.f.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.f.FlatAppearance.BorderSize = 0;
            this.f.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.f.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.Color.White;
            this.f.Location = new System.Drawing.Point(419, 526);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(83, 84);
            this.f.TabIndex = 101;
            this.f.TabStop = false;
            this.f.Text = "F";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.Letter_Click);
            // 
            // c
            // 
            this.c.AccessibleName = "";
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c.BackgroundImage")));
            this.c.Cursor = System.Windows.Forms.Cursors.Default;
            this.c.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c.Enabled = false;
            this.c.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.c.FlatAppearance.BorderSize = 0;
            this.c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(167, 526);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(83, 84);
            this.c.TabIndex = 100;
            this.c.TabStop = false;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.Letter_Click);
            // 
            // m
            // 
            this.m.AccessibleName = "";
            this.m.BackColor = System.Drawing.Color.Transparent;
            this.m.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m.BackgroundImage")));
            this.m.Cursor = System.Windows.Forms.Cursors.Default;
            this.m.Enabled = false;
            this.m.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.m.FlatAppearance.BorderSize = 0;
            this.m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.ForeColor = System.Drawing.Color.White;
            this.m.Location = new System.Drawing.Point(1007, 526);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(83, 85);
            this.m.TabIndex = 99;
            this.m.TabStop = false;
            this.m.Text = "M";
            this.m.UseVisualStyleBackColor = false;
            this.m.Click += new System.EventHandler(this.Letter_Click);
            // 
            // j
            // 
            this.j.AccessibleName = "";
            this.j.BackColor = System.Drawing.Color.Transparent;
            this.j.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j.BackgroundImage")));
            this.j.Cursor = System.Windows.Forms.Cursors.Default;
            this.j.Enabled = false;
            this.j.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.j.FlatAppearance.BorderSize = 0;
            this.j.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.j.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.j.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.j.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j.ForeColor = System.Drawing.Color.White;
            this.j.Location = new System.Drawing.Point(755, 526);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(83, 84);
            this.j.TabIndex = 98;
            this.j.TabStop = false;
            this.j.Text = "J";
            this.j.UseVisualStyleBackColor = false;
            this.j.Click += new System.EventHandler(this.Letter_Click);
            // 
            // z
            // 
            this.z.AccessibleName = "";
            this.z.BackColor = System.Drawing.Color.Transparent;
            this.z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z.BackgroundImage")));
            this.z.Cursor = System.Windows.Forms.Cursors.Default;
            this.z.Enabled = false;
            this.z.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.z.FlatAppearance.BorderSize = 0;
            this.z.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.z.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.ForeColor = System.Drawing.Color.White;
            this.z.Location = new System.Drawing.Point(1007, 612);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(83, 84);
            this.z.TabIndex = 97;
            this.z.TabStop = false;
            this.z.Text = "Z";
            this.z.UseVisualStyleBackColor = false;
            this.z.Click += new System.EventHandler(this.Letter_Click);
            // 
            // n
            // 
            this.n.AccessibleName = "";
            this.n.BackColor = System.Drawing.Color.Transparent;
            this.n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n.BackgroundImage")));
            this.n.Cursor = System.Windows.Forms.Cursors.Default;
            this.n.Enabled = false;
            this.n.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.n.FlatAppearance.BorderSize = 0;
            this.n.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.n.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.White;
            this.n.Location = new System.Drawing.Point(-1, 611);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(83, 84);
            this.n.TabIndex = 96;
            this.n.TabStop = false;
            this.n.Text = "N";
            this.n.UseVisualStyleBackColor = false;
            this.n.Click += new System.EventHandler(this.Letter_Click);
            // 
            // w
            // 
            this.w.AccessibleName = "";
            this.w.BackColor = System.Drawing.Color.Transparent;
            this.w.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w.BackgroundImage")));
            this.w.Cursor = System.Windows.Forms.Cursors.Default;
            this.w.Enabled = false;
            this.w.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.w.FlatAppearance.BorderSize = 0;
            this.w.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.w.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.w.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w.ForeColor = System.Drawing.Color.White;
            this.w.Location = new System.Drawing.Point(755, 611);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(83, 84);
            this.w.TabIndex = 94;
            this.w.TabStop = false;
            this.w.Text = "W";
            this.w.UseVisualStyleBackColor = false;
            this.w.Click += new System.EventHandler(this.Letter_Click);
            // 
            // t
            // 
            this.t.AccessibleName = "";
            this.t.BackColor = System.Drawing.Color.Transparent;
            this.t.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("t.BackgroundImage")));
            this.t.Cursor = System.Windows.Forms.Cursors.Default;
            this.t.Enabled = false;
            this.t.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.t.FlatAppearance.BorderSize = 0;
            this.t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ForeColor = System.Drawing.Color.White;
            this.t.Location = new System.Drawing.Point(503, 611);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(83, 84);
            this.t.TabIndex = 95;
            this.t.TabStop = false;
            this.t.Text = "T";
            this.t.UseVisualStyleBackColor = false;
            this.t.Click += new System.EventHandler(this.Letter_Click);
            // 
            // y
            // 
            this.y.AccessibleName = "";
            this.y.BackColor = System.Drawing.Color.Transparent;
            this.y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("y.BackgroundImage")));
            this.y.Cursor = System.Windows.Forms.Cursors.Default;
            this.y.Enabled = false;
            this.y.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.y.FlatAppearance.BorderSize = 0;
            this.y.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.Color.White;
            this.y.Location = new System.Drawing.Point(923, 611);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(83, 84);
            this.y.TabIndex = 93;
            this.y.TabStop = false;
            this.y.Text = "Y";
            this.y.UseVisualStyleBackColor = false;
            this.y.Click += new System.EventHandler(this.Letter_Click);
            // 
            // v
            // 
            this.v.AccessibleName = "";
            this.v.BackColor = System.Drawing.Color.Transparent;
            this.v.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("v.BackgroundImage")));
            this.v.Cursor = System.Windows.Forms.Cursors.Default;
            this.v.Enabled = false;
            this.v.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.v.FlatAppearance.BorderSize = 0;
            this.v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.ForeColor = System.Drawing.Color.White;
            this.v.Location = new System.Drawing.Point(671, 611);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(83, 84);
            this.v.TabIndex = 92;
            this.v.TabStop = false;
            this.v.Text = "V";
            this.v.UseVisualStyleBackColor = false;
            this.v.Click += new System.EventHandler(this.Letter_Click);
            // 
            // s
            // 
            this.s.AccessibleName = "";
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("s.BackgroundImage")));
            this.s.Cursor = System.Windows.Forms.Cursors.Default;
            this.s.Enabled = false;
            this.s.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.s.FlatAppearance.BorderSize = 0;
            this.s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.White;
            this.s.Location = new System.Drawing.Point(419, 611);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(83, 84);
            this.s.TabIndex = 91;
            this.s.TabStop = false;
            this.s.Text = "S";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.Letter_Click);
            // 
            // p
            // 
            this.p.AccessibleName = "";
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p.BackgroundImage")));
            this.p.Cursor = System.Windows.Forms.Cursors.Default;
            this.p.Enabled = false;
            this.p.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.p.FlatAppearance.BorderSize = 0;
            this.p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.ForeColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(167, 611);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(83, 84);
            this.p.TabIndex = 115;
            this.p.TabStop = false;
            this.p.Text = "P";
            this.p.UseVisualStyleBackColor = false;
            this.p.Click += new System.EventHandler(this.Letter_Click);
            // 
            // e
            // 
            this.e.AccessibleName = "";
            this.e.BackColor = System.Drawing.Color.Transparent;
            this.e.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("e.BackgroundImage")));
            this.e.Cursor = System.Windows.Forms.Cursors.Default;
            this.e.Enabled = false;
            this.e.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.e.FlatAppearance.BorderSize = 0;
            this.e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.ForeColor = System.Drawing.Color.White;
            this.e.Location = new System.Drawing.Point(335, 526);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(83, 84);
            this.e.TabIndex = 116;
            this.e.TabStop = false;
            this.e.Text = "E";
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.Letter_Click);
            // 
            // b
            // 
            this.b.AccessibleName = "";
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b.BackgroundImage")));
            this.b.Cursor = System.Windows.Forms.Cursors.Default;
            this.b.Enabled = false;
            this.b.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.b.FlatAppearance.BorderSize = 0;
            this.b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.White;
            this.b.Location = new System.Drawing.Point(83, 526);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(83, 84);
            this.b.TabIndex = 117;
            this.b.TabStop = false;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.Letter_Click);
            // 
            // g
            // 
            this.g.AccessibleName = "";
            this.g.BackColor = System.Drawing.Color.Transparent;
            this.g.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("g.BackgroundImage")));
            this.g.Cursor = System.Windows.Forms.Cursors.Default;
            this.g.Enabled = false;
            this.g.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.g.FlatAppearance.BorderSize = 0;
            this.g.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.g.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.White;
            this.g.Location = new System.Drawing.Point(503, 526);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(83, 84);
            this.g.TabIndex = 118;
            this.g.TabStop = false;
            this.g.Text = "G";
            this.g.UseVisualStyleBackColor = false;
            this.g.Click += new System.EventHandler(this.Letter_Click);
            // 
            // d
            // 
            this.d.AccessibleName = "";
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d.BackgroundImage")));
            this.d.Cursor = System.Windows.Forms.Cursors.Default;
            this.d.Enabled = false;
            this.d.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.d.FlatAppearance.BorderSize = 0;
            this.d.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.Color.White;
            this.d.Location = new System.Drawing.Point(251, 526);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(83, 84);
            this.d.TabIndex = 120;
            this.d.TabStop = false;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.Letter_Click);
            // 
            // a
            // 
            this.a.AccessibleName = "";
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a.BackgroundImage")));
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a.Cursor = System.Windows.Forms.Cursors.Default;
            this.a.Enabled = false;
            this.a.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.a.FlatAppearance.BorderSize = 0;
            this.a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(-1, 526);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(83, 84);
            this.a.TabIndex = 119;
            this.a.TabStop = false;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.Letter_Click);
            // 
            // keyboardBackground
            // 
            this.keyboardBackground.Image = ((System.Drawing.Image)(resources.GetObject("keyboardBackground.Image")));
            this.keyboardBackground.Location = new System.Drawing.Point(-11, 500);
            this.keyboardBackground.Name = "keyboardBackground";
            this.keyboardBackground.Size = new System.Drawing.Size(1151, 205);
            this.keyboardBackground.TabIndex = 134;
            this.keyboardBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1088, 696);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.titleScreen);
            this.Controls.Add(this.animatedImage);
            this.Controls.Add(this.letterGuessed);
            this.Controls.Add(this.guessedLetterBackground);
            this.Controls.Add(this.loadingScreen);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.staticImage);
            this.Controls.Add(this.placeholderDisplay);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.l);
            this.Controls.Add(this.i);
            this.Controls.Add(this.o);
            this.Controls.Add(this.x);
            this.Controls.Add(this.u);
            this.Controls.Add(this.k);
            this.Controls.Add(this.h);
            this.Controls.Add(this.r);
            this.Controls.Add(this.q);
            this.Controls.Add(this.f);
            this.Controls.Add(this.c);
            this.Controls.Add(this.m);
            this.Controls.Add(this.j);
            this.Controls.Add(this.z);
            this.Controls.Add(this.n);
            this.Controls.Add(this.w);
            this.Controls.Add(this.t);
            this.Controls.Add(this.y);
            this.Controls.Add(this.v);
            this.Controls.Add(this.s);
            this.Controls.Add(this.p);
            this.Controls.Add(this.e);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.d);
            this.Controls.Add(this.a);
            this.Controls.Add(this.keyboardBackground);
            this.Controls.Add(this.correctWord);
            this.Controls.Add(this.chosenWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hangman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessedLetterBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox staticImage;
        private System.Windows.Forms.TextBox placeholderDisplay;
        private System.Windows.Forms.TextBox letterGuessed;
        internal System.Windows.Forms.Button submitButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button resetButton;
        internal System.Windows.Forms.Button l;
        internal System.Windows.Forms.Button i;
        internal System.Windows.Forms.Button o;
        internal System.Windows.Forms.Button x;
        internal System.Windows.Forms.Button u;
        internal System.Windows.Forms.Button k;
        internal System.Windows.Forms.Button h;
        internal System.Windows.Forms.Button r;
        internal System.Windows.Forms.Button q;
        internal System.Windows.Forms.Button f;
        internal System.Windows.Forms.Button c;
        internal System.Windows.Forms.Button m;
        internal System.Windows.Forms.Button j;
        internal System.Windows.Forms.Button z;
        internal System.Windows.Forms.Button n;
        internal System.Windows.Forms.Button w;
        internal System.Windows.Forms.Button t;
        internal System.Windows.Forms.Button y;
        internal System.Windows.Forms.Button v;
        internal System.Windows.Forms.Button s;
        internal System.Windows.Forms.Button p;
        internal System.Windows.Forms.Button e;
        internal System.Windows.Forms.Button b;
        internal System.Windows.Forms.Button g;
        internal System.Windows.Forms.Button d;
        internal System.Windows.Forms.Button a;
        private System.Windows.Forms.PictureBox animatedImage;
        private System.Windows.Forms.TextBox loadingScreen;
        private System.Windows.Forms.PictureBox titleScreen;
        private System.Windows.Forms.TextBox chosenWord;
        private System.Windows.Forms.PictureBox keyboardBackground;
        private System.Windows.Forms.PictureBox guessedLetterBackground;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.TextBox correctWord;
    }
}

