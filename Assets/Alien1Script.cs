using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Alien1Script : MonoBehaviour
{

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TankMissile")
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed");
        }
       
    }

    private void Move()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

    }

 
}
