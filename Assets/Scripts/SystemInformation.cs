using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemInformation : MonoBehaviour
{
    public static int soldierNum = 0;
    public static int medicalNum = 0;
    public static int tankNum = 0;
    public static int carNum = 0;
    [SerializeField] TextMeshProUGUI soldierText;
    [SerializeField] TextMeshProUGUI medicalText;
    [SerializeField] TextMeshProUGUI tankText;
    [SerializeField] TextMeshProUGUI carText;
    [SerializeField] GameObject panel;

    private void Update()
    {
        displayInfo();
    }

    public void displayInfo()
    {
        soldierText.text = soldierNum.ToString();
        medicalText.text = medicalNum.ToString();
        tankText.text = tankNum.ToString();
        carText.text = carNum.ToString();
    }

    public void onClick()
    {
        if (panel.activeInHierarchy)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
