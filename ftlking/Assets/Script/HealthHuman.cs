namespace Script
{
    public class HealthHuman : Health
    {
        public int EatBar { get; set; }
        public int ThirstBar { get; set; }
        public int StaminaBar { get; set; }

        public HealthHuman()
        {
            EatBar = 100;
            ThirstBar = 100;
            StaminaBar = 100;
        }
    }
}