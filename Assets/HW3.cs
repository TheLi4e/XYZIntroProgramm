using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HW3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Homework3();
    }

    // ���������� ���������. ���� ����� � ������� 2 - ������� �� ������� : "�� ����� ������ �������. ����� �������: 2".
    void Homework3()
    {
        Debug.Log("�������� �������� �������������!");
        for (int room = 1; room < 5; room++)
        {
            Debug.Log($"�� ����� � ������� {room}.");
            if (room == 2)
            {
                Debug.Log($"�� ����� ������ �������. ����� �������: {room}");
                break;
            }                

            for (int corner = 1; corner < 5; corner++)
            {
                Debug.Log($"�� ��������� ���� {corner}.");
            }
        }
        Debug.Log("�� ��������� ���� �����, ������� �����!");
    }
}
