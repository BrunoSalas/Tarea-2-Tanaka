using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    class ArmasCuerpoACuerpo : Armas
    {
        public ArmasCuerpoACuerpo(string name, float damage, float velocity, float price)
        {
            this.name = name;
            this.damage = damage;
            this.velocityAttack = velocity;
            this.price = price;
        }
        public override float CalculateDamage()
        {
            return damage;
        }
        public override float CalculateDamageSegundo()
        {
            return damage / velocityAttack;
        }
    }
}