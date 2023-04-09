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
    }
}
