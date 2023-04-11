using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetting : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    private bool isPlaced = false;
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hitInfo, Mathf.Infinity))
            {
                //print(hitInfo.transform.gameObject.name);

                if (hitInfo.transform.gameObject.name == "Soldier(Clone)" ||
                    hitInfo.transform.gameObject.name == "Medical(Clone)" ||
                    hitInfo.transform.gameObject.name == "Tank(Clone)" ||
                    hitInfo.transform.gameObject.name == "Transportation(Clone)")
                {
                    //print(hitInfo.transform.gameObject.name);

                    turn.x += Input.GetAxis("Mouse X");
                    turn.y += Input.GetAxis("Mouse Y");
                    hitInfo.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
                }
            }
        }

        else
        {
            return;
        }
    }
}
