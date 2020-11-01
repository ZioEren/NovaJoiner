partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.firefoxMainTabControl1 = new FirefoxMainTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firefoxButton13 = new FirefoxButton();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.firefoxH1 = new FirefoxH1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.firefoxCheckBox5 = new FirefoxCheckBox();
            this.firefoxCheckBox4 = new FirefoxCheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.firefoxCheckBox3 = new FirefoxCheckBox();
            this.firefoxCheckBox2 = new FirefoxCheckBox();
            this.firefoxCheckBox1 = new FirefoxCheckBox();
            this.firefoxButton11 = new FirefoxButton();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firefoxRadioButton5 = new FirefoxRadioButton();
            this.firefoxRadioButton6 = new FirefoxRadioButton();
            this.firefoxCheckBox20 = new FirefoxCheckBox();
            this.firefoxCheckBox19 = new FirefoxCheckBox();
            this.firefoxCheckBox18 = new FirefoxCheckBox();
            this.firefoxButton14 = new FirefoxButton();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firefoxRadioButton3 = new FirefoxRadioButton();
            this.firefoxRadioButton4 = new FirefoxRadioButton();
            this.firefoxCheckBox11 = new FirefoxCheckBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.firefoxRadioButton2 = new FirefoxRadioButton();
            this.firefoxRadioButton1 = new FirefoxRadioButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.firefoxH19 = new FirefoxH1();
            this.firefoxMainTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_Home_132621.png");
            this.imageList1.Images.SetKeyName(1, "Google-Voice-Search-icon.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.Title = "Load your tokens here...";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Mp3 audio file (*.mp3)|*.mp3";
            this.openFileDialog2.Title = "Load your Mp3 audio file here...";
            // 
            // firefoxMainTabControl1
            // 
            this.firefoxMainTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.firefoxMainTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firefoxMainTabControl1.Controls.Add(this.tabPage1);
            this.firefoxMainTabControl1.Controls.Add(this.tabPage2);
            this.firefoxMainTabControl1.ImageList = this.imageList1;
            this.firefoxMainTabControl1.ItemSize = new System.Drawing.Size(43, 152);
            this.firefoxMainTabControl1.Location = new System.Drawing.Point(0, 2);
            this.firefoxMainTabControl1.Multiline = true;
            this.firefoxMainTabControl1.Name = "firefoxMainTabControl1";
            this.firefoxMainTabControl1.SelectedIndex = 0;
            this.firefoxMainTabControl1.Size = new System.Drawing.Size(1067, 648);
            this.firefoxMainTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.firefoxMainTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.firefoxButton13);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.firefoxH1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(156, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Homepage";
            // 
            // firefoxButton13
            // 
            this.firefoxButton13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxButton13.EnabledCalc = true;
            this.firefoxButton13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxButton13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.firefoxButton13.Location = new System.Drawing.Point(294, 549);
            this.firefoxButton13.Name = "firefoxButton13";
            this.firefoxButton13.Size = new System.Drawing.Size(353, 31);
            this.firefoxButton13.TabIndex = 77;
            this.firefoxButton13.Text = "Load all tokens from a file";
            this.firefoxButton13.Click += new System.EventHandler(this.firefoxButton13_Click);
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(294, 217);
            this.textBox14.MaxLength = 2147483647;
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox14.Size = new System.Drawing.Size(353, 322);
            this.textBox14.TabIndex = 52;
            this.textBox14.Text = "Insert tokens here...";
            // 
            // firefoxH1
            // 
            this.firefoxH1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxH1.AutoSize = true;
            this.firefoxH1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.firefoxH1.ForeColor = System.Drawing.Color.White;
            this.firefoxH1.Location = new System.Drawing.Point(294, 12);
            this.firefoxH1.Name = "firefoxH1";
            this.firefoxH1.Size = new System.Drawing.Size(360, 37);
            this.firefoxH1.TabIndex = 4;
            this.firefoxH1.Text = "WELCOME TO NOVAJOINER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(402, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.firefoxCheckBox5);
            this.tabPage2.Controls.Add(this.firefoxCheckBox4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.firefoxCheckBox3);
            this.tabPage2.Controls.Add(this.firefoxCheckBox2);
            this.tabPage2.Controls.Add(this.firefoxCheckBox1);
            this.tabPage2.Controls.Add(this.firefoxButton11);
            this.tabPage2.Controls.Add(this.numericUpDown12);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.firefoxCheckBox20);
            this.tabPage2.Controls.Add(this.firefoxCheckBox19);
            this.tabPage2.Controls.Add(this.firefoxCheckBox18);
            this.tabPage2.Controls.Add(this.firefoxButton14);
            this.tabPage2.Controls.Add(this.textBox16);
            this.tabPage2.Controls.Add(this.trackBar4);
            this.tabPage2.Controls.Add(this.trackBar5);
            this.tabPage2.Controls.Add(this.trackBar6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.firefoxCheckBox11);
            this.tabPage2.Controls.Add(this.trackBar2);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.trackBar3);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.firefoxRadioButton2);
            this.tabPage2.Controls.Add(this.firefoxRadioButton1);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.firefoxH19);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(156, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 640);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vocal Joiner";
            // 
            // firefoxCheckBox5
            // 
            this.firefoxCheckBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox5.Bold = false;
            this.firefoxCheckBox5.Checked = false;
            this.firefoxCheckBox5.EnabledCalc = true;
            this.firefoxCheckBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox5.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox5.Location = new System.Drawing.Point(635, 138);
            this.firefoxCheckBox5.Name = "firefoxCheckBox5";
            this.firefoxCheckBox5.Size = new System.Drawing.Size(94, 27);
            this.firefoxCheckBox5.TabIndex = 84;
            this.firefoxCheckBox5.Text = "Anti Kick";
            // 
            // firefoxCheckBox4
            // 
            this.firefoxCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox4.Bold = false;
            this.firefoxCheckBox4.Checked = false;
            this.firefoxCheckBox4.EnabledCalc = true;
            this.firefoxCheckBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox4.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox4.Location = new System.Drawing.Point(668, 524);
            this.firefoxCheckBox4.Name = "firefoxCheckBox4";
            this.firefoxCheckBox4.Size = new System.Drawing.Size(132, 27);
            this.firefoxCheckBox4.TabIndex = 83;
            this.firefoxCheckBox4.Text = "Anti Disconnect";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(180, 557);
            this.textBox2.MaxLength = 18;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(549, 25);
            this.textBox2.TabIndex = 82;
            this.textBox2.Text = "Insert here the user id of screenshare join...";
            // 
            // firefoxCheckBox3
            // 
            this.firefoxCheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox3.Bold = false;
            this.firefoxCheckBox3.Checked = false;
            this.firefoxCheckBox3.EnabledCalc = true;
            this.firefoxCheckBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox3.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox3.Location = new System.Drawing.Point(493, 524);
            this.firefoxCheckBox3.Name = "firefoxCheckBox3";
            this.firefoxCheckBox3.Size = new System.Drawing.Size(169, 27);
            this.firefoxCheckBox3.TabIndex = 81;
            this.firefoxCheckBox3.Text = "Join User Screenshare";
            // 
            // firefoxCheckBox2
            // 
            this.firefoxCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox2.Bold = false;
            this.firefoxCheckBox2.Checked = false;
            this.firefoxCheckBox2.EnabledCalc = true;
            this.firefoxCheckBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox2.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox2.Location = new System.Drawing.Point(343, 524);
            this.firefoxCheckBox2.Name = "firefoxCheckBox2";
            this.firefoxCheckBox2.Size = new System.Drawing.Size(144, 27);
            this.firefoxCheckBox2.TabIndex = 80;
            this.firefoxCheckBox2.Text = "Start Screenshare";
            // 
            // firefoxCheckBox1
            // 
            this.firefoxCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox1.Bold = false;
            this.firefoxCheckBox1.Checked = false;
            this.firefoxCheckBox1.EnabledCalc = true;
            this.firefoxCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox1.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox1.Location = new System.Drawing.Point(180, 524);
            this.firefoxCheckBox1.Name = "firefoxCheckBox1";
            this.firefoxCheckBox1.Size = new System.Drawing.Size(157, 27);
            this.firefoxCheckBox1.TabIndex = 79;
            this.firefoxCheckBox1.Text = "Crash voice channel";
            // 
            // firefoxButton11
            // 
            this.firefoxButton11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxButton11.EnabledCalc = true;
            this.firefoxButton11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxButton11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.firefoxButton11.Location = new System.Drawing.Point(180, 588);
            this.firefoxButton11.Name = "firefoxButton11";
            this.firefoxButton11.Size = new System.Drawing.Size(549, 31);
            this.firefoxButton11.TabIndex = 78;
            this.firefoxButton11.Text = "Join on this voice channel";
            this.firefoxButton11.Click += new System.EventHandler(this.firefoxButton11_Click);
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.numericUpDown12.ForeColor = System.Drawing.Color.White;
            this.numericUpDown12.Location = new System.Drawing.Point(507, 485);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(177, 25);
            this.numericUpDown12.TabIndex = 77;
            this.numericUpDown12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown12.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.firefoxRadioButton5);
            this.groupBox2.Controls.Add(this.firefoxRadioButton6);
            this.groupBox2.Location = new System.Drawing.Point(223, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 49);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // firefoxRadioButton5
            // 
            this.firefoxRadioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton5.Bold = false;
            this.firefoxRadioButton5.Checked = false;
            this.firefoxRadioButton5.EnabledCalc = true;
            this.firefoxRadioButton5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton5.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton5.Location = new System.Drawing.Point(135, 14);
            this.firefoxRadioButton5.Name = "firefoxRadioButton5";
            this.firefoxRadioButton5.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton5.TabIndex = 62;
            this.firefoxRadioButton5.Text = "Unlimited times";
            // 
            // firefoxRadioButton6
            // 
            this.firefoxRadioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton6.Bold = false;
            this.firefoxRadioButton6.Checked = true;
            this.firefoxRadioButton6.EnabledCalc = true;
            this.firefoxRadioButton6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton6.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton6.Location = new System.Drawing.Point(6, 14);
            this.firefoxRadioButton6.Name = "firefoxRadioButton6";
            this.firefoxRadioButton6.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton6.TabIndex = 61;
            this.firefoxRadioButton6.Text = "Specific times";
            // 
            // firefoxCheckBox20
            // 
            this.firefoxCheckBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox20.Bold = false;
            this.firefoxCheckBox20.Checked = false;
            this.firefoxCheckBox20.EnabledCalc = true;
            this.firefoxCheckBox20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox20.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox20.Location = new System.Drawing.Point(584, 398);
            this.firefoxCheckBox20.Name = "firefoxCheckBox20";
            this.firefoxCheckBox20.Size = new System.Drawing.Size(194, 27);
            this.firefoxCheckBox20.TabIndex = 75;
            this.firefoxCheckBox20.Text = "Join as headphones muted";
            // 
            // firefoxCheckBox19
            // 
            this.firefoxCheckBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox19.Bold = false;
            this.firefoxCheckBox19.Checked = false;
            this.firefoxCheckBox19.EnabledCalc = true;
            this.firefoxCheckBox19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox19.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox19.Location = new System.Drawing.Point(384, 398);
            this.firefoxCheckBox19.Name = "firefoxCheckBox19";
            this.firefoxCheckBox19.Size = new System.Drawing.Size(194, 27);
            this.firefoxCheckBox19.TabIndex = 74;
            this.firefoxCheckBox19.Text = "Join as microphone muted";
            // 
            // firefoxCheckBox18
            // 
            this.firefoxCheckBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox18.Bold = false;
            this.firefoxCheckBox18.Checked = false;
            this.firefoxCheckBox18.EnabledCalc = true;
            this.firefoxCheckBox18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox18.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox18.Location = new System.Drawing.Point(180, 398);
            this.firefoxCheckBox18.Name = "firefoxCheckBox18";
            this.firefoxCheckBox18.Size = new System.Drawing.Size(198, 27);
            this.firefoxCheckBox18.TabIndex = 73;
            this.firefoxCheckBox18.Text = "Play audio in voice channel";
            // 
            // firefoxButton14
            // 
            this.firefoxButton14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxButton14.EnabledCalc = true;
            this.firefoxButton14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxButton14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.firefoxButton14.Location = new System.Drawing.Point(735, 438);
            this.firefoxButton14.Name = "firefoxButton14";
            this.firefoxButton14.Size = new System.Drawing.Size(39, 25);
            this.firefoxButton14.TabIndex = 72;
            this.firefoxButton14.Text = "...";
            this.firefoxButton14.Click += new System.EventHandler(this.firefoxButton14_Click);
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(180, 438);
            this.textBox16.MaxLength = 1200;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(549, 25);
            this.textBox16.TabIndex = 71;
            this.textBox16.Text = "Insert here the path of the audio to play....";
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar4.Location = new System.Drawing.Point(458, 354);
            this.trackBar4.Maximum = 5000;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(271, 45);
            this.trackBar4.TabIndex = 70;
            this.trackBar4.Value = 1000;
            this.trackBar4.Visible = false;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar5.Location = new System.Drawing.Point(180, 354);
            this.trackBar5.Maximum = 5000;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(271, 45);
            this.trackBar5.TabIndex = 69;
            this.trackBar5.Value = 250;
            this.trackBar5.Visible = false;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar6.Location = new System.Drawing.Point(180, 354);
            this.trackBar6.Maximum = 5000;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(549, 45);
            this.trackBar6.TabIndex = 68;
            this.trackBar6.Value = 250;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Delay: 250ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.firefoxRadioButton3);
            this.groupBox1.Controls.Add(this.firefoxRadioButton4);
            this.groupBox1.Location = new System.Drawing.Point(180, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 49);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // firefoxRadioButton3
            // 
            this.firefoxRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton3.Bold = false;
            this.firefoxRadioButton3.Checked = false;
            this.firefoxRadioButton3.EnabledCalc = true;
            this.firefoxRadioButton3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton3.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton3.Location = new System.Drawing.Point(135, 14);
            this.firefoxRadioButton3.Name = "firefoxRadioButton3";
            this.firefoxRadioButton3.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton3.TabIndex = 62;
            this.firefoxRadioButton3.Text = "Random delay";
            this.firefoxRadioButton3.CheckedChanged += new FirefoxRadioButton.CheckedChangedEventHandler(this.firefoxRadioButton3_CheckedChanged);
            // 
            // firefoxRadioButton4
            // 
            this.firefoxRadioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton4.Bold = false;
            this.firefoxRadioButton4.Checked = true;
            this.firefoxRadioButton4.EnabledCalc = true;
            this.firefoxRadioButton4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton4.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton4.Location = new System.Drawing.Point(6, 14);
            this.firefoxRadioButton4.Name = "firefoxRadioButton4";
            this.firefoxRadioButton4.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton4.TabIndex = 61;
            this.firefoxRadioButton4.Text = "Specific delay";
            this.firefoxRadioButton4.CheckedChanged += new FirefoxRadioButton.CheckedChangedEventHandler(this.firefoxRadioButton4_CheckedChanged);
            // 
            // firefoxCheckBox11
            // 
            this.firefoxCheckBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxCheckBox11.Bold = false;
            this.firefoxCheckBox11.Checked = false;
            this.firefoxCheckBox11.EnabledCalc = true;
            this.firefoxCheckBox11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox11.ForeColor = System.Drawing.Color.White;
            this.firefoxCheckBox11.Location = new System.Drawing.Point(180, 244);
            this.firefoxCheckBox11.Name = "firefoxCheckBox11";
            this.firefoxCheckBox11.Size = new System.Drawing.Size(220, 27);
            this.firefoxCheckBox11.TabIndex = 65;
            this.firefoxCheckBox11.Text = "Auto leave from voice channel";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar2.Location = new System.Drawing.Point(458, 193);
            this.trackBar2.Maximum = 5000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(271, 45);
            this.trackBar2.TabIndex = 64;
            this.trackBar2.Value = 1000;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(180, 193);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(271, 45);
            this.trackBar1.TabIndex = 63;
            this.trackBar1.Value = 250;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar3.Location = new System.Drawing.Point(180, 193);
            this.trackBar3.Maximum = 5000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(549, 45);
            this.trackBar3.TabIndex = 62;
            this.trackBar3.Value = 250;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(176, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 19);
            this.label16.TabIndex = 61;
            this.label16.Text = "Delay: 250ms";
            // 
            // firefoxRadioButton2
            // 
            this.firefoxRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton2.Bold = false;
            this.firefoxRadioButton2.Checked = false;
            this.firefoxRadioButton2.EnabledCalc = true;
            this.firefoxRadioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton2.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton2.Location = new System.Drawing.Point(309, 138);
            this.firefoxRadioButton2.Name = "firefoxRadioButton2";
            this.firefoxRadioButton2.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton2.TabIndex = 60;
            this.firefoxRadioButton2.Text = "Random delay";
            this.firefoxRadioButton2.CheckedChanged += new FirefoxRadioButton.CheckedChangedEventHandler(this.firefoxRadioButton2_CheckedChanged);
            // 
            // firefoxRadioButton1
            // 
            this.firefoxRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxRadioButton1.Bold = false;
            this.firefoxRadioButton1.Checked = true;
            this.firefoxRadioButton1.EnabledCalc = true;
            this.firefoxRadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxRadioButton1.ForeColor = System.Drawing.Color.White;
            this.firefoxRadioButton1.Location = new System.Drawing.Point(180, 138);
            this.firefoxRadioButton1.Name = "firefoxRadioButton1";
            this.firefoxRadioButton1.Size = new System.Drawing.Size(123, 27);
            this.firefoxRadioButton1.TabIndex = 59;
            this.firefoxRadioButton1.Text = "Specific delay";
            this.firefoxRadioButton1.CheckedChanged += new FirefoxRadioButton.CheckedChangedEventHandler(this.firefoxRadioButton1_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(180, 107);
            this.textBox11.MaxLength = 18;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(549, 25);
            this.textBox11.TabIndex = 58;
            this.textBox11.Text = "Insert here the id of the voice channel...";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(180, 76);
            this.textBox1.MaxLength = 18;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 25);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "Insert here the guild id...";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(180, 45);
            this.textBox12.MaxLength = 2000;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(549, 25);
            this.textBox12.TabIndex = 56;
            this.textBox12.Text = "Insert here the guild invite code...";
            // 
            // firefoxH19
            // 
            this.firefoxH19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firefoxH19.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.firefoxH19.ForeColor = System.Drawing.Color.White;
            this.firefoxH19.Location = new System.Drawing.Point(0, 4);
            this.firefoxH19.Name = "firefoxH19";
            this.firefoxH19.Size = new System.Drawing.Size(907, 37);
            this.firefoxH19.TabIndex = 4;
            this.firefoxH19.Text = "Vocal Joiner";
            this.firefoxH19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.firefoxMainTabControl1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaJoiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.firefoxMainTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.ImageList imageList1;
    private FirefoxMainTabControl firefoxMainTabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private FirefoxH1 firefoxH1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private FirefoxH1 firefoxH19;
    private System.Windows.Forms.TextBox textBox14;
    private FirefoxButton firefoxButton13;
    private System.Windows.Forms.TextBox textBox12;
    private System.Windows.Forms.TextBox textBox11;
    private System.Windows.Forms.TextBox textBox1;
    private FirefoxRadioButton firefoxRadioButton2;
    private FirefoxRadioButton firefoxRadioButton1;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.GroupBox groupBox1;
    private FirefoxRadioButton firefoxRadioButton3;
    private FirefoxRadioButton firefoxRadioButton4;
    private FirefoxCheckBox firefoxCheckBox11;
    private FirefoxCheckBox firefoxCheckBox1;
    private FirefoxButton firefoxButton11;
    private System.Windows.Forms.NumericUpDown numericUpDown12;
    private System.Windows.Forms.GroupBox groupBox2;
    private FirefoxRadioButton firefoxRadioButton5;
    private FirefoxRadioButton firefoxRadioButton6;
    private FirefoxCheckBox firefoxCheckBox20;
    private FirefoxCheckBox firefoxCheckBox19;
    private FirefoxCheckBox firefoxCheckBox18;
    private FirefoxButton firefoxButton14;
    private System.Windows.Forms.TextBox textBox16;
    private System.Windows.Forms.TrackBar trackBar4;
    private System.Windows.Forms.TrackBar trackBar5;
    private System.Windows.Forms.TrackBar trackBar6;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog2;
    private FirefoxCheckBox firefoxCheckBox2;
    private System.Windows.Forms.TextBox textBox2;
    private FirefoxCheckBox firefoxCheckBox3;
    private FirefoxCheckBox firefoxCheckBox4;
    private FirefoxCheckBox firefoxCheckBox5;
}