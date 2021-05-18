using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : MonoBehaviour
{
    //4구간 : 좌우로 움직이는 바닥

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
        target1 = new Vector3(-5, y, z);
        target2 = new Vector3(5, y, z);
    }

    void Update()
    {
        if (going1)
        {
            if (transform.position.x >= -5.5 && transform.position.x <= -4.9)
            {
                going1 = false;
                going2 = true;
            }
            else
            {
                Vector3 velo = Vector3.zero;
                transform.position = Vector3.MoveTowards(transform.position, target1, 0.03f);
            }
        }
        else if (going2)
        {
            if (transform.position.x >= 4.9 && transform.position.x <= 5)
            {
                going1 = true;
                going2 = false;
            }
            else
            {
                Vector3 velo = Vector3.zero;
                transform.position = Vector3.MoveTowards(transform.position, target2, 0.03f);
            }
        }
    }
}
