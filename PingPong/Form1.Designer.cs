namespace PingPong
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
            playground = new Panel();
            gameover_lbl = new Label();
            points_lbl = new Label();
            score_lbl = new Label();
            ball = new PictureBox();
            racket = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)racket).BeginInit();
            SuspendLayout();
            // 
            // playground
            // 
            playground.Controls.Add(gameover_lbl);
            playground.Controls.Add(points_lbl);
            playground.Controls.Add(score_lbl);
            playground.Controls.Add(ball);
            playground.Controls.Add(racket);
            playground.Dock = DockStyle.Fill;
            playground.Location = new Point(0, 0);
            playground.Name = "playground";
            playground.Size = new Size(1530, 866);
            playground.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            gameover_lbl.Anchor = AnchorStyles.None;
            gameover_lbl.AutoSize = true;
            gameover_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gameover_lbl.Location = new Point(531, 233);
            gameover_lbl.Name = "gameover_lbl";
            gameover_lbl.Size = new Size(662, 384);
            gameover_lbl.TabIndex = 4;
            gameover_lbl.Text = "Game Over.\r\n\r\nF1 - Resatart Game.\r\nEsc - Exit.\r\n";
            gameover_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // points_lbl
            // 
            points_lbl.AutoSize = true;
            points_lbl.FlatStyle = FlatStyle.Flat;
            points_lbl.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            points_lbl.Location = new Point(261, 9);
            points_lbl.Margin = new Padding(0);
            points_lbl.Name = "points_lbl";
            points_lbl.Size = new Size(75, 82);
            points_lbl.TabIndex = 3;
            points_lbl.Text = "0";
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.FlatStyle = FlatStyle.Flat;
            score_lbl.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            score_lbl.Location = new Point(12, 9);
            score_lbl.Margin = new Padding(0);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(243, 82);
            score_lbl.TabIndex = 2;
            score_lbl.Text = "Score:";
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(184, 116);
            ball.Name = "ball";
            ball.Size = new Size(50, 50);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // racket
            // 
            racket.BackColor = Color.Black;
            racket.Location = new Point(626, 834);
            racket.Name = "racket";
            racket.Size = new Size(280, 20);
            racket.TabIndex = 0;
            racket.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 866);
            Controls.Add(playground);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            playground.ResumeLayout(false);
            playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)racket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playground;
        private PictureBox racket;
        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Label score_lbl;
        private Label points_lbl;
        private Label gameover_lbl;
    }
}
