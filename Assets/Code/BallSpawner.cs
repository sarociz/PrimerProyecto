using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
   
    public ManagerScriptableObject managerValues;

    int n = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEntities();
    }

    
    void SpawnEntities()
    {
        int currentSpawnPoint = 0;

        for (int i = 0; i < managerValues.prefabnumber; i++) {
            GameObject entity = Instantiate(managerValues.prefabSpawn, managerValues.spawnPoints[currentSpawnPoint],Quaternion.identity);

            entity.name = managerValues.prefabName + n;

            currentSpawnPoint = (currentSpawnPoint + 1) % managerValues.spawnPoints.Length;

            n++;
        }

    }
}
