using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingSphere : MonoBehaviour
{
    //6구간 : 굴러오는 눈덩이(구)

    Rigidbody rigidbody;
    Vector3 target;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        target = new Vector3(transform.position.x, -15, 284f);
        transform.position = Vector3.MoveTowards(transform.position, target, 0.4f);
    }
}
