using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyObjs : ScriptableObject
{
    [SerializeField] internal float health, speed, dmg, maxHealth, detectRange;
    [SerializeField] internal string nickName;
}
