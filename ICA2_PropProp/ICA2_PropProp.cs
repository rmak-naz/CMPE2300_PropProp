using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA2_PropProp
{
    public partial class ICA2_PropProp : Form
    {
        private CDrawer canvas;
        private List<PropBall> ballList = new List<PropBall>();
        private List<PropBall> outBound = new List<PropBall>();

        public ICA2_PropProp()
        {
            InitializeComponent();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            canvas = new CDrawer();
            canvas.ContinuousUpdate = false;
            BallTick.Enabled = true;
        }

        private void BallTick_Tick(object sender, EventArgs e)
        {
            Point rightClick = new Point(-1,-1);
            Point leftClick = new Point(-1,-1);
            PropBall ball;

            canvas.Clear();

            if (canvas.GetLastMouseRightClick(out rightClick))
            {
                ball = new PropBall(rightClick, PropBall.BallColor.Purple);
                ballList.Add(ball);
            }

            if (canvas.GetLastMouseLeftClick(out leftClick))
            {
                ball = new PropBall(leftClick, PropBall.BallColor.Orange);
                ballList.Add(ball);
            }

            for (int ballCount = 0; ballCount < ballList.Count(); ++ballCount)
            {
                foreach (PropBall ball2 in ballList)
                {
                    if (!ball2.Equals(ballList[ballCount]))
                    {
                        if (ball2.GetColor != ballList[ballCount].GetColor)
                        {
                            ballList[ballCount].Love = ball2;
                        }
                        else
                        {
                            ballList[ballCount].Hate = ball2;
                        }
                    }
                }
                if (ballList[ballCount].Pos.X < 0 || 
                    ballList[ballCount].Pos.X > 800 ||
                    ballList[ballCount].Pos.Y < 0 ||
                    ballList[ballCount].Pos.Y > 600)
                {
                    outBound.Add(ballList[ballCount]);
                }
            }

            foreach (PropBall outBall in outBound)
            {
                ballList.Remove(outBall);
            }


            foreach (PropBall mBall in ballList)
            {
                mBall.Render(canvas);
            }
            canvas.Render();

        }
    }
}
