using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight : MonoBehaviour
{
    Transform playerTransform;

    void Start()
    {
        //tr = GetComponent<Transform>();
    }

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        float x = playerTransform.position.x;
        float z = playerTransform.position.z;
        transform.position = new Vector3(x, transform.position.y, z+1);
    }
}
