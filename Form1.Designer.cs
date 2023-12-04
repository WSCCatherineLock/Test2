namespace Classic_Snake_Game
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            btnSnap = new Button();
            lblScore = new Label();
            lblHighScore = new Label();
            picCanvas = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SkyBlue;
            btnStart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(605, 22);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 63);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += StartGame;
            // 
            // btnSnap
            // 
            btnSnap.BackColor = Color.LightGreen;
            btnSnap.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnap.Location = new Point(605, 91);
            btnSnap.Name = "btnSnap";
            btnSnap.Size = new Size(100, 53);
            btnSnap.TabIndex = 1;
            btnSnap.Text = "Snap";
            btnSnap.UseVisualStyleBackColor = false;
            btnSnap.Click += TakeSnapShot;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(605, 158);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(69, 21);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHighScore.Location = new Point(605, 191);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(110, 21);
            lblHighScore.TabIndex = 3;
            lblHighScore.Text = "High Score: 0";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(12, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(580, 680);
            picCanvas.TabIndex = 4;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 40;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 707);
            Controls.Add(picCanvas);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(btnSnap);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Classic snake game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnSnap;
        private Label lblScore;
        private Label lblHighScore;
        private PictureBox picCanvas;
        private System.Windows.Forms.Timer gameTimer;
    }
}