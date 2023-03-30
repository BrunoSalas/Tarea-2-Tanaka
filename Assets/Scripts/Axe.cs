using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace weapons
{
    class Axe : ArmasCuerpoACuerpo
    {
        public Axe()
        {
            this.name = "Arco";
            this.damage = 4;
            this.price = 20;
            this.velocityAttack = 1;
        }
    }
}
