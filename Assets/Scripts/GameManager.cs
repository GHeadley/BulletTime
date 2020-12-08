using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float minInterval = 1;
    public float maxInterval = 10;
    public float spawnDistanceFromPlayer = 10;
    public GameObject player;
    public GameObject GunPrefab;
    private static string SPAWN_GUN_METHOD_NAME = "SpawnGun";

    // Start is called before the first frame update
    void Start()
    {
        InvokeMethodWithInterval(SPAWN_GUN_METHOD_NAME, minInterval, maxInterval);
    }

    void SpawnGun()
    {
        Vector3 spawnVector = GetRandomSpawnVector();
        Vector3 spawnLocation = (spawnVector * spawnDistanceFromPlayer) + player.transform.position;
        spawnLocation.y = 0;
        // TODO: I want to find out a better way of instantiating the Gun that uses dependency injection.
        // Current solutions I have looked at seem to not include the problem of creating the object at runtime. 
        GameObject createdGun = Instantiate(GunPrefab, spawnLocation, new Quaternion());
        createdGun.GetComponent<GunLogic>().Player = player;
        InvokeMethodWithInterval(SPAWN_GUN_METHOD_NAME, minInterval, maxInterval);
    }

    Vector3 GetRandomSpawnVector()
    {
        Vector3 RandomLocation;
        float randomAngle = Random.Range(0, Mathf.PI * 2);
        RandomLocation.y = 0;
        RandomLocation.x = Mathf.Sin(randomAngle);
        RandomLocation.z = Mathf.Cos(randomAngle);
        return RandomLocation;
    }

    void InvokeMethodWithInterval(string method, float min, float max)
    {
        Invoke(method, Random.Range(min, max));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
