using System;
using System.Drawing;
using System.Windows.Forms;

namespace NIM_v1._0
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Point mousedownpoint = Point.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            GameTimer.Start();
            this.Size = new Size(498, 421);
            exitlbl.Location = new Point(464, 0);
            hodnoty.sirky = rnd.Next(11, 25);
            sirkynum.Text = hodnoty.sirky.ToString();
            startgamebtn.Visible = false;
            exitgamebtn.Visible = false;
            sirka1btn.Visible = true;
            sirka2btn.Visible = true;
            sirka3btn.Visible = true;
            sirkyhodnotalbl.Visible = true;
            sirka1pb.Visible = true;
            sirka2pb.Visible = true;
            sirka3pb.Visible = true;
            sirkymaxpb.Visible = true;
            sirkynum.Visible = true;
            Easybtn.Visible = false;
            Mediumbtn.Visible = false;
            hardbtn.Visible = false;
        }
        private void EndGame()
        {
            GameTimer.Stop();
            this.Size = new Size(140, 130);
            exitlbl.Location = new Point(106, 0);
            startgamebtn.Visible = true;
            exitgamebtn.Visible = true; 
            sirka1btn.Visible = false;
            sirka2btn.Visible = false;
            sirka3btn.Visible = false;
            sirkyhodnotalbl.Visible = false;
            sirka1pb.Visible = false;
            sirka2pb.Visible = false;
            sirka3pb.Visible = false;
            sirkymaxpb.Visible = false;
            sirkynum.Visible = false;
            Easybtn.Visible = false;
            Mediumbtn.Visible = false;
            hardbtn.Visible = false;
        }
        private void startgamebtn_Click(object sender, EventArgs e)
        {
            SelectDiff();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EndGame();
        }

        private void sirka1btn_Click(object sender, EventArgs e)
        {
            hodnoty.sirky -= 1;
            sirkynum.Text = hodnoty.sirky.ToString();
            sirka1btn.Enabled = false;
            sirka2btn.Enabled = false;
            sirka3btn.Enabled = false;
            EnemyTurn();
        }

        private void sirka2btn_Click(object sender, EventArgs e)
        {
            hodnoty.sirky -= 2;
            sirkynum.Text = hodnoty.sirky.ToString();
            sirka1btn.Enabled = false;
            sirka2btn.Enabled = false;
            sirka3btn.Enabled = false;
            EnemyTurn();
        }

        private void sirka3btn_Click(object sender, EventArgs e)
        {
            hodnoty.sirky -= 3;
            sirkynum.Text = hodnoty.sirky.ToString();
            sirka1btn.Enabled = false;
            sirka2btn.Enabled = false;
            sirka3btn.Enabled = false;
            EnemyTurn();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(hodnoty.sirky < 1)
            {
                gameoverlbl.Text = "You Lost !";
                gameoverlbl.Visible = true;
                GameTimer.Stop();
                sirkynum.Text = "0";
                hodnoty.Wait(1500);
                EndGame();
            }
        }

        private void exitgamebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void EnemyTurn()
        {
            if(hodnoty.sirky >= 1) GameTimer.Stop();
            else
            {
                gameoverlbl.Text = "You Lost !";
                gameoverlbl.Visible = true;
                GameTimer.Stop();
                sirkynum.Text = "0";
                hodnoty.Wait(1500);
                EndGame();
            }
            hodnoty.Wait(300);
            if (hodnoty.Easy)
            {
                hodnoty.sirky -= rnd.Next(1, 3);
                if(hodnoty.sirky < 1)
                {
                    gameoverlbl.Text = "You Win !";
                    gameoverlbl.Visible = true;
                    sirkynum.Text = "0";
                    hodnoty.Wait(1500);
                    EndGame();
                }
            }    
            else if(hodnoty.Medium)
            {
                int selectvar = 0;
                selectvar = rnd.Next(0, 1);
                if(selectvar == 1)
                {
                    if (hodnoty.sirky == 4) hodnoty.sirky -= 3;
                    else if (hodnoty.sirky == 3) hodnoty.sirky -= 2;
                    else if (hodnoty.sirky == 2) hodnoty.sirky -= 1;
                    else
                    {
                        hodnoty.sirky -= rnd.Next(1, 3);
                        if (hodnoty.sirky < 1)
                        {
                            gameoverlbl.Text = "You Win !";
                            gameoverlbl.Visible = true;
                            sirkynum.Text = "0";
                            hodnoty.Wait(1500);
                            EndGame();
                        }
                    }
                }
                else
                {
                    hodnoty.sirky -= rnd.Next(1, 3);
                    if (hodnoty.sirky < 1)
                    {
                        gameoverlbl.Text = "You Win !";
                        gameoverlbl.Visible = true;
                        sirkynum.Text = "0";
                        hodnoty.Wait(1500);
                        EndGame();
                    }

                }
            }
            else if(hodnoty.Hard)
            {
                if (hodnoty.sirky == 4) hodnoty.sirky -= 3;
                else if (hodnoty.sirky == 3) hodnoty.sirky -= 2;
                else if(hodnoty.sirky == 2) hodnoty.sirky -= 1;
                else
                {
                    hodnoty.sirky -= rnd.Next(1, 3);
                    if (hodnoty.sirky <= 1)
                    {
                        gameoverlbl.Text = "You Win !";
                        gameoverlbl.Visible = true;
                        sirkynum.Text = "0";
                        hodnoty.Wait(1500);
                        EndGame();
                    }
                }
            }
            hodnoty.Wait(400);
            sirkynum.Text = hodnoty.sirky.ToString();
            sirka1btn.Enabled = true;
            sirka2btn.Enabled = true;
            sirka3btn.Enabled = true;
            if(hodnoty.sirky > 1) GameTimer.Start();
        }
        private void SelectDiff()
        {
            this.Size = new Size(498, 421);
            exitlbl.Location = new Point(464, 0);
            startgamebtn.Visible = false;
            exitgamebtn.Visible = false;
            sirka1btn.Visible = false;
            sirka2btn.Visible = false;
            sirka3btn.Visible = false;
            sirkyhodnotalbl.Visible = false;
            sirka1pb.Visible = false;
            sirka2pb.Visible = false;
            sirka3pb.Visible = false;
            sirkymaxpb.Visible = false;
            sirkynum.Visible = false;
            Easybtn.Visible = false;
            Mediumbtn.Visible = false;
            hardbtn.Visible = false;
            Easybtn.Visible = true;
            Mediumbtn.Visible = true;
            hardbtn.Visible = true;
            gameoverlbl.Visible = false;
        }

        private void Easybtn_Click(object sender, EventArgs e)
        {
            hodnoty.Easy = true;
            hodnoty.Medium = false;
            hodnoty.Hard = false;
            StartGame();
        }

        private void Mediumbtn_Click(object sender, EventArgs e)
        {
            hodnoty.Easy = false;
            hodnoty.Medium = true;
            hodnoty.Hard = false;
            StartGame();
        }

        private void hardbtn_Click(object sender, EventArgs e)
        {
            hodnoty.Easy = false;
            hodnoty.Medium = false;
            hodnoty.Hard = true;
            StartGame();
        }
    }
}
