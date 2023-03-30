using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace weapons
{
    abstract class Armas
    {

        public string name;
        public float damage;
        public string GetName()
        {
            return name;
        }
    }
    
}