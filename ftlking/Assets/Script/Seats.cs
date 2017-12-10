using System.Collections.Generic;

namespace Script
{
    public class Seats
    {
        public Dictionary<int, Item> RowerSeat;
        public Dictionary<int, Item> PilotSeat;
        public Dictionary<int, Item> MusicianSeat;
        public Dictionary<int, Item> FightSeat;

        public Seats()
        {
            RowerSeat = new Dictionary<int, Item>();
            PilotSeat = new Dictionary<int, Item>();
            MusicianSeat = new Dictionary<int, Item>();
            FightSeat = new Dictionary<int, Item>();
        }

        public Seats(int NbRower, int NbPilot, int NbMusicianSeat, int NbFightSeat)
        {
            RowerSeat = new Dictionary<int, Item>(NbRower);
            PilotSeat = new Dictionary<int, Item>(NbPilot);
            MusicianSeat = new Dictionary<int, Item>(NbMusicianSeat);
            FightSeat = new Dictionary<int, Item>(NbFightSeat);
        }
    }
}