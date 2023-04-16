using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiation : MonoBehaviour
{
    [SerializeField] private GameObject[] arrayObject = new GameObject[4];
    [SerializeField] private GameObject panel;

    public void createObject(int index)
    {
        panel.SetActive(false);
        Instantiate(arrayObject[index], new Vector3(0, 0, 0), Quaternion.identity);

        if(index == 0)
        {
            SystemInformation.soldierNum += 1;
        }
        else if(index == 1)
        {
            SystemInformation.medicalNum += 1;
        }
        else if(index == 2)
        {
            SystemInformation.tankNum += 1;
        }
        else
        {
            SystemInformation.carNum += 1;
        }
    }
}
