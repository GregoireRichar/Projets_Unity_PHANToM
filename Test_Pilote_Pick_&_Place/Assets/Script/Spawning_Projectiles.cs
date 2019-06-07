using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_Projectiles : MonoBehaviour
{
    public GameObject projectile;
    public Vector3 spawnValues;
    public float spawnWait = 0.2f;
    public float startWait = 0;

    void Start()
    {
        StartCoroutine(SpawnProjectile());
    }

    IEnumerator SpawnProjectile()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(spawnValues.x - 3.25f, spawnValues.x + 3.25f), spawnValues.y, Random.Range(spawnValues.z - 2.25f, spawnValues.z + 2.25f));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(projectile, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
