using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public GameObject Player;
    public GameObject BulletPrefab;
    public GameObject BulletSpawn;
    public float AimWindupDuration;

    private float currDuration = 0;
    private Vector3 playerLocation;
    private Vector3 startGunLocation;

    public GunLogic(GameObject player, GameObject bulletPrefab, float aimWindupDuration, GameObject bulletSpawn)
    {
        this.Player = player;
        this.BulletPrefab = bulletPrefab;
        this.AimWindupDuration = aimWindupDuration;
        this.BulletSpawn = bulletSpawn;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerLocation = Player.transform.position;
        startGunLocation = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currDuration += Time.deltaTime;
        if(currDuration >= AimWindupDuration)
        {
            FireGun();
            Destroy(this.gameObject);
        }
        float currY = Mathf.Lerp(startGunLocation.y, playerLocation.y, currDuration / AimWindupDuration);
        Vector3 newLocation = new Vector3(startGunLocation.x, currY, startGunLocation.z);
        this.transform.position = newLocation;
        this.transform.LookAt(Player.transform, Vector3.up);
    }

    private void FireGun()
    {
        Instantiate(BulletPrefab, BulletSpawn.transform.position, this.transform.rotation);
    }
}
