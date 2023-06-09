using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BallBouncer
{
    public interface IBallManager
    {
        void AddBall();
        void AddBall(IBall ball);
        void AddBall(Vector2 position);
        IBall GetBall(int index);
        void ClearBalls();
        void UpdateBalls();
        void UpdateSize(int width, int height);
    }
}
