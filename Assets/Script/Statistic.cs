using System;
using UnityEngine;

namespace Script
{
	[System.Serializable]
	public class Statistic
	{
		public int Strengh;
		public int Dexterity;
		public int Constitution;
		public int Intelligence;
		public int Widsom;
		public int Charisma;
		public int Protection;
		public int Space;

		public int AllStats
		{
			get { return Strengh + Dexterity + Constitution + Intelligence + Widsom + Charisma + Protection + Space; }
			set { }
		}

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
	        Space = 0;
        }

        public Statistic(int newStrengh, int newDexterity, int newConstitution, int newIntelligence, int newWidsom,
            int newCharisma, int newProtection, int newSpace)
        {
            Strengh = newCharisma;
            Dexterity = newDexterity;
            Constitution = newConstitution;
            Intelligence = newIntelligence;
            Widsom = newWidsom;
            Charisma = newCharisma;
            Protection = newProtection;
	        Space = newSpace;
        }

        public Statistic GenerateRandomStatsForCharacter() //TODO Setup an algorithm which randomize every stats, you need to dispatch 34 points in 6 stats DO NOT TOUCH PROTECTION
        {
            Strengh = 2;
            Dexterity = 2;
            Constitution = 2;
            Intelligence = 2;
            Widsom = 2;
            Charisma = 2;
            Protection = 0;
	        Space = 0;
			while (AllStats < 34) {
				int charac = UnityEngine.Random.Range (0, 6);
				switch (charac) {
				case 0:
					{
						Strengh++;
						break;
					}
				case 1:
					{
						Dexterity++;
						break;
					}
				case 2:
					{
						Constitution++;
						break;
					}
				case 3:
					{
						Intelligence++;
						break;
					}
				case 4:
					{
						Widsom++;
						break;
					}
				case 5:
					{
						Charisma++;
						break;
					}
				}
			}
	        return (this);
        } 
        
        public void GenerateRandomStatsForItems() //TODO Setup an algorithm which randomize every stats, you need to dispatch 10 points in 7 stats 
        {
            Strengh = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Widsom = 0;
            Charisma = 0;
            Protection = 0;
	        Space = 0;
        } 
        
        public void Dump()
        {
            Debug.Log("--- All the stats ---");
            Debug.Log("Strengh : " + Strengh);
            Debug.Log("Dexterity : " + Dexterity);
            Debug.Log("Constitution : " + Constitution);
            Debug.Log("Intelligence : " + Intelligence);
            Debug.Log("Widsom : " + Widsom);
            Debug.Log("Charisma : " + Charisma);
	        Debug.Log("Protection : " + Protection);
	        Debug.Log("Space : " + Space);
            Debug.Log("--- --- --- --- --- ---");
        }
    }
}