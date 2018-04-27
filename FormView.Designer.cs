namespace ObjectMoving
{
    partial class FormView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.red1 = new System.Windows.Forms.PictureBox();
            this.red2 = new System.Windows.Forms.PictureBox();
            this.yellow2 = new System.Windows.Forms.PictureBox();
            this.yellow1 = new System.Windows.Forms.PictureBox();
            this.green2 = new System.Windows.Forms.PictureBox();
            this.green1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.boomBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 20;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // red1
            // 
            this.red1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("red1.BackgroundImage")));
            this.red1.Location = new System.Drawing.Point(162, 1);
            this.red1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(33, 76);
            this.red1.TabIndex = 0;
            this.red1.TabStop = false;
            // 
            // red2
            // 
            this.red2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("red2.BackgroundImage")));
            this.red2.Location = new System.Drawing.Point(118, 282);
            this.red2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(76, 42);
            this.red2.TabIndex = 1;
            this.red2.TabStop = false;
            this.red2.Click += new System.EventHandler(this.red2_Click);
            // 
            // yellow2
            // 
            this.yellow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow2.BackgroundImage")));
            this.yellow2.Location = new System.Drawing.Point(118, 282);
            this.yellow2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(76, 42);
            this.yellow2.TabIndex = 2;
            this.yellow2.TabStop = false;
            // 
            // yellow1
            // 
            this.yellow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellow1.BackgroundImage")));
            this.yellow1.Location = new System.Drawing.Point(160, 1);
            this.yellow1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(34, 76);
            this.yellow1.TabIndex = 3;
            this.yellow1.TabStop = false;
            // 
            // green2
            // 
            this.green2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green2.BackgroundImage")));
            this.green2.Location = new System.Drawing.Point(118, 282);
            this.green2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(76, 42);
            this.green2.TabIndex = 4;
            this.green2.TabStop = false;
            // 
            // green1
            // 
            this.green1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("green1.BackgroundImage")));
            this.green1.Location = new System.Drawing.Point(160, 1);
            this.green1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(34, 76);
            this.green1.TabIndex = 5;
            this.green1.TabStop = false;
            this.green1.Click += new System.EventHandler(this.green1_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(642, 1);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 28);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(642, 42);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(56, 24);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // boomBox
            // 
            this.boomBox.BackColor = System.Drawing.Color.Transparent;
            this.boomBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boomBox.BackgroundImage")));
            this.boomBox.Location = new System.Drawing.Point(127, 535);
            this.boomBox.Name = "boomBox";
            this.boomBox.Size = new System.Drawing.Size(126, 69);
            this.boomBox.TabIndex = 8;
            this.boomBox.TabStop = false;
            this.boomBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(891, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1135, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boomBox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.green1);
            this.Controls.Add(this.green2);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.red2);
            this.Controls.Add(this.red1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(746, 602);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Object Moving";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox red1;
        private System.Windows.Forms.PictureBox red2;
        private System.Windows.Forms.PictureBox yellow2;
        private System.Windows.Forms.PictureBox yellow1;
        private System.Windows.Forms.PictureBox green2;
        private System.Windows.Forms.PictureBox green1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.PictureBox boomBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

