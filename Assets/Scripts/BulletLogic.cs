using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float TTL;

    private Vector3 direction;

    private CapsuleCollider bulletCollider;

    void Start()
    {
        bulletCollider = this.gameObject.GetComponentInChildren<CapsuleCollider>();
        Destroy(gameObject, TTL);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-transform.forward * Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        Destroy(gameObject);
    }
}
