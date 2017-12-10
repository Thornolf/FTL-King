namespace Script
{
    public class Level
    {
        public int CurrentLevel;
        public int ExperienceBar;
        public int AllXp;
        // Add boost XP etc.

        public Level()
        {
            CurrentLevel = 1;
            ExperienceBar = 0;
            AllXp = 0;
        }

        public Level(int newCurrentLevel, int newExperienceBar, int newAllXp)
        {
            CurrentLevel = newCurrentLevel;
            ExperienceBar = newExperienceBar;
            AllXp = newAllXp;
        }
    }
}