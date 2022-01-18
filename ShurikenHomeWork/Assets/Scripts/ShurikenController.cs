using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    float speed = 0;  // 초기 속도
    float rotSpeed = 0;  // 초기 회전 속도

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 왼쪽 버튼을 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 왼쪽 버튼을 떼었을 때 좌표
            this.endPos = Input.mousePosition;
            // 스와이프(드레그) 길이 구하기
            float swipeLength = this.endPos.x - this.startPos.y;
            // 스와이프(드레그) 길이를 속도로 변경
            this.speed = swipeLength / 5000.0f;

            // 왼쪽으로 회전
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);  // z축으로 회전
        this.rotSpeed *= 0.96f;  // 감속

        transform.Translate(0, this.speed, 0, Space.World);  // 월드 좌표계 기준으로 y축으로 이동
        this.speed *= 0.98f;  // 감속
    }
}
