using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    //1구간 : 좌우로 움직이는 큐브

    Vector3 target1;
    Vector3 target2;
    bool going1 = true;
    bool going2 = false;

    float y;
    float z;

    void Start()
    {
        y = transform.position.y;
        z = transform.position.z;
        target1 = new Vector3(-10, y, z);
        target2 = new Vector3(10, y, z);
    }

    void Update()
    {
        if (going1)
        {
            if (transform.position.x >= -6.5 && transform.position.x <= -5.9)
            {
                going1 = false;
                going2 = true;
            }
            else transform.position = Vector3.Lerp(transform.position, target1, 0.01f);
        }
        else if (going2)
        {
            if (transform.position.x >= 5.9 && transform.position.x <= 6)
            {
                going1 = true;
                going2 = false;
            }
            else transform.position = Vector3.Lerp(transform.position, target2, 0.005f);
        }
    }
}
