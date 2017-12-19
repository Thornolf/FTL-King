namespace Script
{
    public class Seat
    {
        public int Id { get; set; }
        public Character SeatedCharacter { get; set; }

        public Seat()
        {
            Character c = new Character("Empty", new WeightStat(0f));
            SeatedCharacter = c;
        }

        public Seat(int newId, Character newSeatedCharacter)
        {
            Id = newId;
            SeatedCharacter = newSeatedCharacter;
        }
    }
}