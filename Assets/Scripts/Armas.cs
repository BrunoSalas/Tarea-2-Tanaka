using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace weapons
{
    abstract class Armas
    {
        public string name;
        public float damage;
        public float velocityAttack;
        public float price;
        public string GetName()
        {
            return name;
        }
        public abstract float CalculateDamage();
        public abstract float CalculateDamageSegundo();
    }

}