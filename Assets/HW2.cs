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
    //�������� ����������, ������� ���� ��������� � �������� �� 30 ��.
    void Homework2()
    {
        _health = 100;
        Debug.Log($"������� �������� ��������� - {_health} ��.");
        _health = Damage(_health);
        Debug.Log($"������� ���� �� {_damage} ��. ������� �������� ��������� - {_health} ��.");
        _health = Heal(_health);
        Debug.Log($"�� �������� ������� �� {_heal} ��. ������� �������� ��������� - {_health} ��");
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
