using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA2_PropProp
{
    public class PropBall
    {
        private PointF _center;
        private BallColor _bColor;

        public enum BallColor
        {
            Orange = 0, Purple = 1,
        };

        public PropBall(PointF center, BallColor aColor)
        {
            _center = center;
            _bColor = aColor;
        }

        public Color GetColor
        {
            get
            {
                Color ballColor;
                if (_bColor == 0)
                {
                    ballColor = Color.Orange;
                }
                else
                {
                    ballColor = Color.Purple;
                }
                return ballColor;
            }
        }

        public PointF Pos
        {
            private set
            {
                _center = value;
            }
            get
            {
                return _center;
            }
        }

        public PropBall Love
        {
            set
            {
                _center.X += (value._center.X - _center.X) / 250;
                _center.Y += (value._center.Y - _center.Y) / 250;
            }
        }

        public PropBall Hate
        {
            set
            {
                _center.X -= (value._center.X - _center.X) / 250;
                _center.Y -= (value._center.Y - _center.Y) / 250;
            }
        }

        public void Render(CDrawer canvas)
        {
            canvas.AddCenteredEllipse((int)_center.X, (int)_center.Y, 25, 25, GetColor);
        }
    }
}
