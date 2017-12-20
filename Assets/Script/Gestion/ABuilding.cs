using System.Collections.Generic;
using UnityEngine;

namespace Script.Gestion
{
    public abstract class ABuilding  {

        protected virtual void DoMoreStuff(){
            Debug.Log("Doing more stuff");
        }
    }
}