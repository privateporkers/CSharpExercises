using System;
namespace GolfGame
{
    public class Golfer
    {
        public IClub CurrentClub { get; set; }

        public void Play()
        {
            CurrentClub = new Driver();
            CurrentClub.HitBall();

            CurrentClub = new Iron();
            CurrentClub.HitBall();

            CurrentClub = new Wedge();
            CurrentClub.HitBall();

            CurrentClub = new Putter();
            CurrentClub.HitBall();
        }
    }
}
