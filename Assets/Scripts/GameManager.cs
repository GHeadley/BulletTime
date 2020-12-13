using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float minInterval;
    public float maxInterval;
    public float spawnDistanceFromPlayer;
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
        GameObject createdGun = Instantiate(GunPrefab, spawnLocation, new Quaternion());
        createdGun.GetComponent<GunLogic>().Player = player;
        InvokeMethodWithInterval(SPAWN_GUN_METHOD_NAME, minInterval, maxInterval);
    }

    public Vector3 GetRandomSpawnVector()
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
