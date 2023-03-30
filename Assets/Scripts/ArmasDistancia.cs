using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace weapons
{
    abstract class ArmasDistancia : Armas
    {
        public float velocityAttack;
        public float price;

        public abstract float CalculateDamage();
    }
}
