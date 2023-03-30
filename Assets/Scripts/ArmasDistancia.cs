using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace weapons
{
    class ArmasDistancia : Armas
    {
        public Projectile projectile;

        public ArmasDistancia(string name, float damage, float velocity, float price, Projectile projectile)
        {
            this.name = name;
            this.damage = damage;
            this.velocityAttack = velocity;
            this.price = price;
            this.projectile = projectile;
        }
        public override float CalculateDamage()
        {
            return projectile.damage + damage;
        }
        public override float CalculateDamageSegundo()
        {
            return projectile.damage + damage / velocityAttack;
        }
    }
}
