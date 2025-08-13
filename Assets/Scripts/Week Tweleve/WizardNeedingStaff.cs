using System.Collections;
using System.Collections.Generic;
using SeaWizards.Staffs;
using UnityEngine;

public class WizardNeedingStaff : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Staff retrievedStaff = StaffPoolManager.Instance.GetPooledStaff();

            Debug.Log($" staff {retrievedStaff.name}");

            retrievedStaff.transform.position = new Vector3 (0f, 0f, 0f);
            retrievedStaff.gameObject.SetActive (true);
        }
    }
}
