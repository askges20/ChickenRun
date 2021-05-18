using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    Rigidbody rigid;
    public float jumpPower;
    public float speed;

    bool tryJump;
    bool isJump;

    float hAxis;
    float vAxis;
    Vector3 moveVec;

    public Manager manager;
    int chickCnt;

    public JoyStick joystick; //모바일용 조이스틱 연결

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        isJump = false;
    }

    void Update()
    {
        //컴퓨터용 조작
        //hAxis = Input.GetAxis("Horizontal");
        //vAxis = Input.GetAxis("Vertical");

        hAxis = joystick.Horizontal();
        vAxis = joystick.Vertical();

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;

        if (tryJump && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //바닥에 착지하면 점프 초기화
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
            tryJump = false;
        }
        //눈덩이(구)와 닿으면 원점으로 이동, attempt 증가
        else if (collision.gameObject.tag == "Sphere")
        {
            transform.position = new Vector3(0, 5.57f, -38.03f);
            manager.increaseAttempt();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Item")  //아이템(병아리)를 얻으면
        {
            other.gameObject.SetActive(false);
            chickCnt++;
            manager.GetItem(chickCnt);
        }
        else if (other.tag == "Wall")   //벽에 닿으면 원점으로, attempt 증가
        {
            transform.position = new Vector3(0, 5.57f, -38.03f);
            manager.increaseAttempt();
        }
        else if (other.tag == "Goal")   //목표 지점 도착
        {
            if (chickCnt == 4)  //모든 병아리를 찾았을 때
            {
                manager.setResult(1);
                gameObject.SetActive(false);
            }
            else manager.setResult(2);
        }
    }

    public void ButtonDown(string type) //점프키
    {
        switch (type)
        {
            case "J":
                tryJump = true;
                break;
        }
    }
}
