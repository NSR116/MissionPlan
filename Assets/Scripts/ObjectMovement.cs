using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private bool isPlaced = false;
    [SerializeField] LayerMask layer;

    // Update is called once per frame
    void Update()
    {
        if(isPlaced) return;

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
}
