using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float TTL;

    private Vector3 direction;

    void Start()
    {
        Destroy(this.gameObject, TTL);
        Debug.Log(this.transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
