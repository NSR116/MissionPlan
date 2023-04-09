using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playermove();
    }

    void playermove()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPosition.x++;

            if(targetPosition.x >= -409f)
            {
                targetPosition.x = -409f;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPosition.x--;

            if(targetPosition.x <= -444f)
            {
                targetPosition.x = -444f;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPosition.z--;

            if(targetPosition.z <= 463f)
            {
                targetPosition.z = 463f;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPosition.z++;

            if (targetPosition.z >= 1352f)
            {
                targetPosition.z = 1352f;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            targetPosition.y--;
            
            if(targetPosition.y <= 187f)
            {
                targetPosition.y = 187f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            targetPosition.y++;

            if (targetPosition.y <= 507f)
            {
                targetPosition.y = 507f;
            }
        }
        
        transform.position = targetPosition; 

    }
}
