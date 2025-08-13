using System.Collections;
using System.Collections.Generic;
using SeaWizards.Staffs;
using UnityEngine;

public class StaffPoolManager : MonoBehaviour
{
    public static StaffPoolManager Instance;

    public Staff staffPrefab;
    public int poolSize = 10;

    private List<Staff> staffPool;

    private void Awake()
    {
        Instance = this;
        InitialiseStaffPool();
    }

    private void InitialiseStaffPool()
    {
        staffPool = new List<Staff>();
        for (int i = 0; i < poolSize; i++)
        {
            Staff newStaff = Instantiate(staffPrefab);
            newStaff.gameObject.SetActive(false);
            staffPool.Add(newStaff);
        }

    }

    public Staff GetPooledStaff()
    {
        foreach (Staff Staff in staffPool)
        {
            if (Staff.gameObject.activeInHierarchy == false)
            {
                return Staff;
            }
        }
        return null;
    }
}
