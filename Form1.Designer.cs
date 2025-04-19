namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(200, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(180, 180);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(168, 57);
            this.lblCurrentPlayer.TabIndex = 2;
            this.lblCurrentPlayer.Text = "Player1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(175, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(140, 300);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(251, 57);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(145, 360);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(241, 60);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(843, 100);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(222, 177);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(1549, 100);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(222, 177);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb3.TabIndex = 9;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(1196, 100);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(222, 177);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb2.TabIndex = 10;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb5
            // 
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(1196, 310);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(222, 177);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb5.TabIndex = 13;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb6
            // 
            this.pb6.Image = ((System.Drawing.Image)(resources.GetObject("pb6.Image")));
            this.pb6.Location = new System.Drawing.Point(1549, 310);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(222, 177);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb6.TabIndex = 12;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(843, 310);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(222, 177);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb8
            // 
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(1196, 519);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(222, 177);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb8.TabIndex = 16;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb9
            // 
            this.pb9.Image = ((System.Drawing.Image)(resources.GetObject("pb9.Image")));
            this.pb9.Location = new System.Drawing.Point(1549, 519);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(222, 177);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb9.TabIndex = 15;
            this.pb9.TabStop = false;
            this.pb9.Tag = "9";
            this.pb9.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb7
            // 
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(843, 519);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(222, 177);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb7.TabIndex = 14;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1815, 835);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb7;
    }
}

