using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW4 : MonoBehaviour
{
    [SerializeField] string itemToFind;
    [ContextMenu("Find item")]

    //������� ��������� � ���������. ��������� ���������� �������� �������� � ���������.
    void FindItem()
    {
        List<string> inventory = new List<string>() { "���", "���", "���", "���", "���", "�����", "�����", "�������",
            "�������", "�������", "����� �����" };

        int itemCount = 0;

        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i] == itemToFind)
            {
                itemCount++;
            }
        }
        Debug.Log($"���������� ��������� ��������� {itemToFind}: {itemCount}");
    }
}
