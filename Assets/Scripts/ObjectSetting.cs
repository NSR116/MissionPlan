using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] GameObject panel;
    private bool isPlaced = false;
    private bool isRotated = false;
    private Vector2 turn;

    // Update is called once per frame
    void Update()
    {
        if (isPlaced)
        {
            rotateObject();
            return;
        }

        moveWithMouse();
    }

    void moveWithMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hitInfo, Mathf.Infinity, layer))
        {
            transform.position = hitInfo.point;
        }

        if(Input.GetMouseButtonDown(0))
        {
            isPlaced = true;
        }
    }

    void rotateObject()
    {
        if (!isRotated)
        {
            turn.x += Input.GetAxis("Mouse X");
            turn.y += Input.GetAxis("Mouse Y");
            //Vector2 turnSpeed = new Vector2(turn.x, turn.y) * Time.deltaTime * 50f;
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRotated = true;
        }     
        
    }

    void OnMouseOver()
    {
        if(isPlaced && isRotated)
        {
            print("!!!");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hitInfo, Mathf.Infinity))
            {
                if (hitInfo.transform.gameObject.name == "Soldier(Clone)" ||
                    hitInfo.transform.gameObject.name == "Medical(Clone)" ||
                    hitInfo.transform.gameObject.name == "Tank(Clone)" ||
                    hitInfo.transform.gameObject.name == "Transportation(Clone)")
                {
                    print(hitInfo.transform.gameObject.name);
                    panel.SetActive(true);
                }
            }
        }
    }

    void OnMouseExit()
    {
        if(isPlaced && isRotated)
        {
            panel.SetActive(false);
        }
    }

    public void delete()
    {
        Destroy(gameObject);
    }

    public void edit()
    {
        isPlaced = false;
        isRotated = false;
    }
}
