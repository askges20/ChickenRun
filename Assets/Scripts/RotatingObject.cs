using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    //3구간 : 회전하는 빨간 벽

    Transform tr;
    public int rotateSpeed;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        tr.Rotate(new Vector3(0, 30, 0) * Time.deltaTime * rotateSpeed, Space.World);
    }
}
