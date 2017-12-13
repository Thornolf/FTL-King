using UnityEngine;

namespace Script
{
    public class Level
    {
        public int CurrentLevel { get; set; }
        public int ExperienceBar { get; set; }
        public int AllXp { get; set; }

        public int StepLevel { get; set; }
        // Add boost XP etc.

        public Level()
        {
            CurrentLevel = 1;
            ExperienceBar = 0;
            AllXp = 0;
            StepLevel = 10000;
        }

        public Level(int newCurrentLevel, int newExperienceBar, int newAllXp, int newStepLevel)
        {
            CurrentLevel = newCurrentLevel;
            ExperienceBar = newExperienceBar;
            AllXp = newAllXp;
            StepLevel = newStepLevel;
        }

        public Level GenerateRandomLevel()
        {
            AllXp = UnityEngine.Random.Range(0, 1000000000);
            CurrentLevel = AllXp / StepLevel;
            ExperienceBar = AllXp % StepLevel;
            return (this);
        }

        public void Dump()
        {
            Debug.Log("--- --- --- LEVEL DEBUG MODE --- --- ---");
            Debug.Log("All xp since the beginning : " + AllXp);
            Debug.Log("All xp on the actual level : " + ExperienceBar);
            Debug.Log("Current level : " + CurrentLevel);
            Debug.Log("--- --- --- --- --- --- --- --- --- --- ---");
        }
    }
}