using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    abstract class Projectile
    {
        public string name;
        public float damage; 
        public string GetName()
        {
            return name;
        }
    }
}
