using System.Collections.Generic;

namespace Script
{
    public class Seats
    {
        public Dictionary<int, Seat> RowerSeat;
        public Dictionary<int, Seat> PilotSeat;
        public Dictionary<int, Seat> MusicianSeat;
        public Dictionary<int, Seat> FightSeat;

        public Seats()
        {
            RowerSeat = new Dictionary<int, Seat>();
            PilotSeat = new Dictionary<int, Seat>();
            MusicianSeat = new Dictionary<int, Seat>();
            FightSeat = new Dictionary<int, Seat>();
        }

        public Seats(int NbRower, int NbPilot, int NbMusicianSeat, int NbFightSeat)
        {
            RowerSeat = new Dictionary<int, Seat>(NbRower);
            PilotSeat = new Dictionary<int, Seat>(NbPilot);
            MusicianSeat = new Dictionary<int, Seat>(NbMusicianSeat);
            FightSeat = new Dictionary<int, Seat>(NbFightSeat);
        }
    }
}