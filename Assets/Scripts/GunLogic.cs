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
            return;
        } 
        else
        {
            float currY = Mathf.Lerp(startGunLocation.y, playerLocation.y, currDuration / AimWindupDuration);
            Vector3 newLocation = new Vector3(startGunLocation.x, currY, startGunLocation.z);
            this.transform.position = newLocation;
            this.transform.LookAt(Player.transform, Vector3.up);
        }
    }

    private void FireGun()
    {
        var spawnedBullet = Instantiate(BulletPrefab, BulletSpawn.transform.position, BulletPrefab.transform.rotation);
        // TODO: Find better way of passing in direction vector, via injection?
        var bulletLogicComponent = spawnedBullet.GetComponent<BulletLogic>();
        bulletLogicComponent.direction = Vector3.Normalize(Player.transform.position 
            - BulletSpawn.transform.position);
        spawnedBullet.transform.LookAt(Player.transform, Vector3.up);
        spawnedBullet.transform.Rotate(new Vector3(90, 90, 90), Space.Self);
    }
}
