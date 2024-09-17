using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{


    public ManagerScriptableObject managerValues;

    int n = 1;

    void Start()
    {
        SpawnEntities();
    }


    void SpawnEntities()
    {

        for (int i = 0; i < managerValues.prefabnumber; i++)
        {
            GameObject entity = Instantiate(managerValues.prefabSpawn, new Vector3(i + 1, i + 1, 0), Quaternion.identity);

            entity.name = managerValues.prefabName + n;
           

            n++;
        }

    }
}
