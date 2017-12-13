using UnityEngine;

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

        public void Dump()
        {
            Debug.Log("--- --- --- HP DEBUG MODE --- --- ---");
            Debug.Log("EatBar : " + EatBar);
            Debug.Log("ThirstBar : " + ThirstBar);
            Debug.Log("StaminaBar : " + StaminaBar);
            Debug.Log("--- --- --- --- --- --- --- --- --- ---");
        }
    }
}