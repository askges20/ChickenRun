using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    Transform tr;
    //float x = 0.0f, y = 0.0f, z = 0.0f;

    Transform playerTransform;
    Vector3 Offset;

    void Start()
    {
        //tr = GetComponent<Transform>();
    }

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {   
        //캐릭터와 일정 거리 유지하며 이동
        transform.position = playerTransform.position + Offset;
    }
}
