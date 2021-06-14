using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "character", menuName = "Data/Character")]
public class Character : ScriptableObject
{
    public string Name;
    public Sprite Icon;
}
