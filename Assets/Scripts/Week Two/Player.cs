using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SeaWizards.Staffs
{

    public class Player : MonoBehaviour
    {
        [SerializeField] private int playerHealth = 100;
        [SerializeField] private Inventory inventory;
        [SerializeField] private Staff staff;

       

        public void SetHealth(int damage)
        {
            playerHealth = playerHealth - damage;
            Debug.Log($"Players health is now {playerHealth}!");
        }

        //public void TakeDamage(int damage)
        //{
        //    DealDamage(damage);
        //    SetHealth(damage);
        //}
    }
}
