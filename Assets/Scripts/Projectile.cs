using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    class Projectile
    {
        public string name;
        public float damage;
        public float price;
        public string GetName()
        {
            return name;
        }
        public Projectile(string name, float damage, float price)
        {
            this.name = name;
            this.damage = damage;
            this.price = price;
        }
    }
}
