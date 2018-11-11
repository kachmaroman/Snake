using System;

namespace Snake
{
    public class HitEventArgs : EventArgs
    {
        public int Score { get; }

        public HitEventArgs(int score)
        {
            Score = score;
        }
    }
}