using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownWall : MonoBehaviour
{
    //5구간 : 위 아래로 움직이는 벽

    Vector3 down;
    Vector3 up;

    bool goingDown = true;
    bool goingUp = false;

    float x;
    float z;

    void Start()
    {
        x = transform.position.x;
        z = transform.position.z;
        down = new Vector3(x, -2.5f, z);
        up = new Vector3(x, 2.18f, z);
    }

    void Update()
    {
        if (goingDown)
        {
            if (transform.position.y <= -2)
            {
                goingDown = false;
                goingUp = true;
            }
            else
            {
                Vector3 velo = Vector3.zero;
                transform.position = Vector3.MoveTowards(transform.position, down, 0.02f);
            }
        }
        else if (goingUp)
        {
            if (transform.position.y >= 2.18f)
            {
                goingDown = true;
                goingUp = false;
            }
            else
            {
                Vector3 velo = Vector3.zero;
                transform.position = Vector3.MoveTowards(transform.position, up, 0.02f);
            }
        }
    }
}
