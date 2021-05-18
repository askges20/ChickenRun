using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAnimator : MonoBehaviour
{
    private Animator animator;
    KeyCode currentKey;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {   
        //컴퓨터 버전은 키 입력에 따라 동작 다르게
        //앱은 자동으로 애니메이션 변경
        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentKey = KeyCode.UpArrow;
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentKey = KeyCode.LeftArrow;
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentKey = KeyCode.RightArrow;
            animator.SetBool("Run", true);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentKey = KeyCode.DownArrow;
            animator.SetBool("Run", true);
        }

        if (Input.GetKeyUp(currentKey))
        {
            animator.SetBool("Run", false);
        }
        */
    }
}
