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

    // Доработать программу. Если вошли в комнату 2 - вывести на консоль : "Вы нашли нужную комнату. Номер комнаты: 2".
    void Homework3()
    {
        Debug.Log("Начинаем изучение неизведанного!");
        for (int room = 1; room < 5; room++)
        {
            Debug.Log($"Вы зашли в комнтау {room}.");
            if (room == 2)
            {
                Debug.Log($"Вы нашли нужную комнату. Номер комнаты: {room}");
                break;
            }                

            for (int corner = 1; corner < 5; corner++)
            {
                Debug.Log($"Вы осмотрели угол {corner}.");
            }
        }
        Debug.Log("Вы закончили свой поход, храбрый герой!");
    }
}
