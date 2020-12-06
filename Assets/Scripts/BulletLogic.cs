using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 1;
    public float TTL = 30;

    private Vector3 direction;

    void Start()
    {
        //direction = Vector3.forward;
        Destroy(this.gameObject, TTL);       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-this.transform.forward * Time.deltaTime * Speed);
    }
}
