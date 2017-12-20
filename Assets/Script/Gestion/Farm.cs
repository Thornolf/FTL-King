using UnityEngine;

namespace Script.Gestion
{
    public class Farm : ABuilding {
        
        protected override void DoMoreStuff(){
            Debug.Log("This is the farm house. Do you need any food ?");
        }
    }
}