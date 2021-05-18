using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider slider;
    public Chicken player;
    float goalZ;
    float totalDistance;
    float nowDistance;
    float distancePercent;

    void Start()
    {
        slider.value = 0;
        goalZ = 390f;
        totalDistance = goalZ - player.transform.position.z;
    }

    void Update()
    {
        nowDistance = goalZ - player.transform.position.z;  //목표 지점과 플레이어 사이의 거리
        distancePercent = 1 - nowDistance / totalDistance;
        if (distancePercent >= 1)
            slider.value = 1;
        else
            slider.value = distancePercent;
    }
}
