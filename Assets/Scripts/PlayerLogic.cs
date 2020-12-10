using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public int PlayerHealth;
    public string ExpectedBulletTag;

    private SphereCollider Collider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(ExpectedBulletTag))
        {
            if(--PlayerHealth == 0)
            {
                PlayerDeath();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Collider = this.gameObject.GetComponent<SphereCollider>();
    }

    void PlayerDeath()
    {
        Debug.Log("Player Died!");
    }
}
