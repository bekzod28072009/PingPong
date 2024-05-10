namespace PingPong
{
    public partial class Form1 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public Form1()
        {
            InitializeComponent();




            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - (playground.Bottom / 10);
            gameover_lbl.Left = (playground.Width/2) - (gameover_lbl.Width/2);
            gameover_lbl.Top = (playground.Height/2) - (gameover_lbl.Height/2);
            gameover_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if(ball.Bottom >= racket.Top && ball.Bottom  <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
                points_lbl.Text = point.ToString();

                Random random = new Random();
                playground.BackColor = Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255));
            }

            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover_lbl.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                ball.Left = 50;
                ball.Top = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                playground.BackColor = Color.White;

            }
        }
    }
}
