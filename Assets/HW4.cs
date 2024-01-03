using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW4 : MonoBehaviour
{
    [SerializeField] string itemToFind;
    [ContextMenu("Find item")]

    //Сделать дубликаты в инвентаре. Посчитать количество искомого предмета в инвентаре.
    void FindItem()
    {
        List<string> inventory = new List<string>() { "меч", "меч", "меч", "меч", "щит", "зелье", "зелье", "монетка",
            "монетка", "монетка", "хвост бобра" };

        int itemCount = 0;

        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i] == itemToFind)
            {
                itemCount++;
            }
        }
        Debug.Log($"Количество найденных предметов {itemToFind}: {itemCount}");
    }
}
