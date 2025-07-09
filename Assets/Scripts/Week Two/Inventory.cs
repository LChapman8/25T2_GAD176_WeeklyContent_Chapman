using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SeaWizards.Staffs
{

    public class Inventory : MonoBehaviour
    {
        [SerializeField] private Item[] Items;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (Items[0] != null)
                {
                    Debug.Log($"item in the first slot is {Items[0].itemName}");
                }
            }
        }
    }
}
