using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        FireTank();

    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A)) //GetKey vs GetKeyDown to have it continuously listening to input = holding the key down.
        {
            transform.Translate((Vector2.left * Time.deltaTime) * moveSpeed); //the transform property of the object translates toward direction.
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.right * Time.deltaTime) * moveSpeed);
        }
    }

    void FireTank()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn projectile from transform.position.x if some time has passed
            Debug.Log("Fire!");
        }
    }

}
