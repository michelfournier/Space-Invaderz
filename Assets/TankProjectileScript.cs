using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankProjectileScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;

    public float TankProjectileVelocity;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.velocity = new Vector2(0, 1 * TankProjectileVelocity); // fly little projectile
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GameLimit")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed, out of bound");
        }

        if (collision.tag == "Alien1")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed, Alien1");
        }
        if (collision.tag == "Alien2")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed, Alien2");
        }    
        if (collision.tag == "Alien3")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed, Alien3");
        }
        if (collision.tag == "Shield")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed, shield");
        }                                     
    }

}
