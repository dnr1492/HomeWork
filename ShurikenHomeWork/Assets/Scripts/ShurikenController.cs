using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    float speed = 0;  // �ʱ� �ӵ�
    float rotSpeed = 0;  // �ʱ� ȸ�� �ӵ�

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 ���� ��ư�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ���� ��ư�� ������ �� ��ǥ
            this.endPos = Input.mousePosition;
            // ��������(�巹��) ���� ���ϱ�
            float swipeLength = this.endPos.x - this.startPos.y;
            // ��������(�巹��) ���̸� �ӵ��� ����
            this.speed = swipeLength / 5000.0f;

            // �������� ȸ��
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);  // z������ ȸ��
        this.rotSpeed *= 0.96f;  // ����

        transform.Translate(0, this.speed, 0, Space.World);  // ���� ��ǥ�� �������� y������ �̵�
        this.speed *= 0.98f;  // ����
    }
}
