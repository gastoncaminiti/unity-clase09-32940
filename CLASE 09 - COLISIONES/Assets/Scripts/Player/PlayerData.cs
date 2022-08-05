using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(1,3)]
    private int live = 1;
    public int HP { get { return live; } }


    public void Healing(int value)
    {
        live += value;
    }

    public void Damage(int value)
    {
        live -= value;
    }
}
