using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    class Tienda : MonoBehaviour
    {
        static Projectile bullet = new Projectile("Bala", 15,8);
        static Projectile arrow = new Projectile("Flecha", 25,1);
        ArmasDistancia bow = new ArmasDistancia("Arco", 66, 8, 550,arrow);
        ArmasDistancia pistol = new ArmasDistancia("Pistola", 16, 5, 2, bullet);
        ArmasCuerpoACuerpo axe = new ArmasCuerpoACuerpo("Hacha",20,4,20);
        ArmasCuerpoACuerpo sword = new ArmasCuerpoACuerpo("Espada", 100, 2, 120);

        public List<Armas> inventory = new List<Armas>();
        public void Bow()
        {
            Debug.Log($"Name : {bow.name} / Damage: {bow.damage} / DamageTotal : {bow.CalculateDamage()} / DamageSeconds : {bow.CalculateDamageSegundo()}/ VelocityAttack: { bow.velocityAttack} / Price : {bow.price}");
            inventory.Add(new ArmasDistancia(bow.name, bow.CalculateDamage(), bow.velocityAttack, bow.price, arrow));
        }
        public void Pistol()
        {
            Debug.Log($"Name : {pistol.name} / Damage: {pistol.damage} / DamageTotal : {pistol.CalculateDamage()} / VelocityAttack: { pistol.velocityAttack} / Price : {pistol.price}");
            inventory.Add(new ArmasDistancia(pistol.name, pistol.CalculateDamage(), pistol.velocityAttack, pistol.price, bullet));
        }

        public void Axe()
        {
            Debug.Log($"Name : {axe.name} / Damage: {axe.damage} / VelocityAttack: { axe.velocityAttack} / Price : {axe.price}");
            inventory.Add(new ArmasCuerpoACuerpo(axe.name, axe.damage, axe.velocityAttack, axe.price));
        }
        public void Sword()
        {
            Debug.Log($"Name : {sword.name} / Damage: {sword.damage} / VelocityAttack: { sword.velocityAttack} / Price : {sword.price}");
            inventory.Add(new ArmasCuerpoACuerpo(sword.name, sword.damage, sword.velocityAttack, sword.price));
        }
        public void Bullet()
        {
            Debug.Log($"Name : {bullet.name} / Damage: {bullet.damage} / Precio : {bullet.price}");
        }
        public void Arrow()
        {
            Debug.Log($"Name : {arrow.name} / Damage: {arrow.damage} / Precio : {arrow.price}");
        }

        public void List()
        {
            for(int i = 0; i < inventory.Count;i++)
            {
                Debug.Log($"{i+1}){inventory[i].name}");
            }
        }
        public void ListDeleteUnid(string i)
        {
            int j = int.Parse(i);
            if (j <= 0 || j > inventory.Count)
            {
                Debug.Log("No hay ningún elemento en esa posición");
                return;
            }

            if (inventory[j - 1] != null)
            {
                inventory.RemoveAt(j - 1);
                List();
            }
        }
    }
}
