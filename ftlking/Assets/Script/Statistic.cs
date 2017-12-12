using UnityEngine;

namespace Script
{
    public class Statistic
    {
        public int Strengh { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Widsom { get; set; }
        public int Charisma { get; set; }
        public int Protection { get; set; }
        
        //Stats protection must be equals to 0 if you are creating a character, it must remain only for item utilisation
        public Statistic()
        {
            Strengh = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Widsom = 0;
            Charisma = 0;
            Protection = 0;
        }

        public Statistic(int newStrengh, int newDexterity, int newConstitution, int newIntelligence, int newWidsom,
            int newCharisma, int newProtection)
        {
            Strengh = newCharisma;
            Dexterity = newDexterity;
            Constitution = newConstitution;
            Intelligence = newIntelligence;
            Widsom = newWidsom;
            Charisma = newCharisma;
            Protection = newProtection;
        }
        public void DebugStats()
        {
            Debug.Log("--- All the stats ---");
            Debug.Log("Strengh : " + Strengh);
            Debug.Log("Dexterity : " + Dexterity);
            Debug.Log("Constitution : " + Constitution);
            Debug.Log("Intelligence : " + Intelligence);
            Debug.Log("Widsom : " + Widsom);
            Debug.Log("Charisma : " + Charisma);
            Debug.Log("Protection : " + Protection);
            Debug.Log("--- --- --- --- --- ---");
        }
    }
}