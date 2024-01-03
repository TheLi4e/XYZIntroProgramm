using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2 : MonoBehaviour
{
    private int _health { get; set; }
    private int _damage { get; set; }
    private int _heal { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        Homework2();
    }
    //Добавить переменную, нанести урон персонажу и вылечить на 30 хп.
    void Homework2()
    {
        _health = 100;
        Debug.Log($"Текущее здоровье персонажа - {_health} ХП.");
        _health = Damage(_health);
        Debug.Log($"Нанесен урон на {_damage} ХП. Текущее здоровье персонажа - {_health} ХП.");
        _health = Heal(_health);
        Debug.Log($"Вы получили лечение на {_heal} ХП. Текущее здоровье персонажа - {_health} ХП");
    }

    int Damage(int hp)
    {
        _damage = 50;
        return hp - _damage;

    }

    int Heal(int hp)
    {
        _heal = 30;
        return hp + _heal;
    }

}
