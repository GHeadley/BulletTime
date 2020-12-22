using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float TTL;

    public Vector3 direction;

    void Start()
    {
        Destroy(gameObject, TTL);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate((direction) * Time.deltaTime * Speed, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if(!this.CompareTag(other.tag))
        {
            Destroy(this.gameObject);
        }
    }
}
