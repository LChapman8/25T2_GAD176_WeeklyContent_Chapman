using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SeaWizards.Staffs
{

    public class Staff : MonoBehaviour
    {
        private Player player;
        // we need some properties
        // has a magic power/damage amount 
        private int magicDamage = 10;
        // has a magic type
        private string magicType = "fire";
        // has a mana cost for spell use 
        private int manaCost = 1;

        // we need some functionality 
        // can be picked up and dropped
        // can only have 1 at a time
        // can click to cast a spell 
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                DealDamage(magicDamage);
            }
        }
        public void DealDamage(int damage)
        {
           damage = magicDamage;
           player.SetHealth(damage);
        }
    }
}
