using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Manager : MonoBehaviour
{
    public int totalChick;      //총 병아리 수
    public Text foundChickText; //찾은 병아리 수
    public Text timerText;      //누적 시간
    public Text attemptText;    //시도 횟수
    public Text endText;        //게임 종료 알림
    public Text notFinishedText;//게임 종료 조건 만족x 알림
    public Text resultText;     //결과

    System.Random rand = new System.Random();
    int randX;

    int attemptCnt = 1;
    int time = 0;

    void Start()
    {
        StartCoroutine(co_timer()); //타이머 시작
    }

    IEnumerator co_timer()
    {
        while(true)
        {
            //1초 단위로 증가
            timerText.text = time+" sec";
            yield return new WaitForSeconds(1f);
            time++;
        }
    }

    public void GetItem(int cnt)
    {
        foundChickText.text = cnt + "";
    }

    public void increaseAttempt()
    {
        attemptCnt++;
        attemptText.text = "Attempt " + attemptCnt;
    }

    public void setResult(int num)
    {
        if (num == 1)   //게임 종료
        {
            endText.text = "Congratulations!";
            notFinishedText.text = "";
            resultText.text = "You accomplished the mission in "+ attemptCnt + " tries and " + time + " sec";
            attemptText.text = "";
}
        else //게임 종료 조건 달성x
            notFinishedText.text = "You need to find all chicks!";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")   //캐릭터가 맵 밖으로 벗어난 경우
        {
            increaseAttempt();
            other.transform.position = new Vector3(0, 5.57f, -38.03f);
        }
        else if (other.gameObject.tag == "Sphere")  //눈덩이(구) 리젠
        {
            randX = rand.Next(214) - 69;
            other.transform.position = new Vector3(((float)randX) / 10, 10f, 356f);
        }
    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
