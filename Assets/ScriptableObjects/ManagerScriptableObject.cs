using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class ManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int prefabnumber;

    public Vector3[] spawnPoints; 

    public GameObject prefabSpawn;
}
