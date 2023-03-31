using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    class Tienda : MonoBehaviour
    {
        static Projectile bullet = new Projectile("Bala", 15);
        static Projectile arrow = new Projectile("Flecha", 25);
        ArmasDistancia bow = new ArmasDistancia("Arco", 66, 8, 550,arrow);
        ArmasDistancia pistol = new ArmasDistancia("Pistola", 16, 5, 2, bullet);
        ArmasCuerpoACuerpo axe = new ArmasCuerpoACuerpo("Hacha",20,4,20);

        public List<Armas> inventory = new List<Armas>();
        public void Bow()
        {
            Debug.Log($"Name : {bow.name} / Damage: {bow.damage} / DamageTotal : {bow.CalculateDamage()} / DamageSeconds : {bow.CalculateDamageSegundo()}/ VelocityAttack: { bow.velocityAttack} / Price : {bow.price}");
            inventory.Add(new ArmasDistancia("Arco", 66, 8, 550, bullet));
        }
        public void Pistol()
        {
            Debug.Log($"Name : {pistol.name} / Damage: {pistol.damage} / DamageTotal : {pistol.CalculateDamage()} / VelocityAttack: { pistol.velocityAttack} / Price : {pistol.price}");
            inventory.Add(new ArmasDistancia("Arco", 66, 8, 550, bullet));
        }

        public void Axe()
        {
            Debug.Log($"Name : {axe.name} / Damage: {axe.damage} / VelocityAttack: { axe.velocityAttack} / Price : {axe.price}");
            inventory.Add(new ArmasCuerpoACuerpo("Hacha", 20, 4, 20));
        }

        public void List()
        {
            for(int i = 0; i < inventory.Count;i++)
            {
                
            }
        }
    }
}
