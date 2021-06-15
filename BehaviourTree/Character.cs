using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DI_Dialogue
{
    [CreateAssetMenu(fileName = "character", menuName = "Data/Character")]
    public class Character : ScriptableObject
    {
        public string Name;
        public Sprite Icon;
    }
}

