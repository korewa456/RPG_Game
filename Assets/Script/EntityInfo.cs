using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "NewEntityInfo", menuName = "EntityInfo")]
public class EntityInfo : ScriptableObject
{
    public Sprite Avatar;
    public string Name;
}
