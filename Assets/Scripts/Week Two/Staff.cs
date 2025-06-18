using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
namespace SeaWizards.Staffs
{

    public class Staff : MonoBehaviour, ICollectable, IIdentifable
    {
        private Player player;
        // we need some properties
        // has a magic power/damage amount 
        private int magicDamage = 10;
        // has a magic type
        private string magicType = "fire";
        // has a mana cost for spell use 
        private int manaCost = 1;

        private bool playerInRange = false;

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

            if (Input.GetKeyDown(KeyCode.I) && playerInRange == true)
            {
                Identify();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<ICollectable>() != null)
            {
                Collect();
                playerInRange = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            playerInRange = false;
        }

        public void DealDamage(int damage)
        {
           damage = magicDamage;
           player.SetHealth(damage);
        }

        public void Collect()
        {
            Debug.Log("the staff has been collected");
        }

        public void Identify()
        {
            Debug.Log("This item has been identified, it is a fire staff");
        }
    }
}
