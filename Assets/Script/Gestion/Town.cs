using System.Collections.Generic;

namespace Script.Gestion
{
    public class Town
    {
        protected List<ABuilding> Buildings { get; set; }

        public Town()
        {
            Buildings = new List<ABuilding>();
        }
        
        public void AddBuilding(ABuilding child)
        {
            this.Buildings.Add(child);
        }
    }
}