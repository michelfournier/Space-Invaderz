using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Invaders : MonoBehaviour
{
    public int rows = 5;
    public int columns = 11;

    public InvaderScript[] prefabs;

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            float width = 0.6f * (this.columns - 1);
            float height = 0.6f * (this.rows - 1);
            Vector3 centering = new Vector2(-width/2, -height/2);
            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * 0.6f), 0.0f);
           
            for (int col = 0; col < this.columns; col++)
            {
                InvaderScript invaders = Instantiate(this.prefabs[row], this.transform); //ex. instantiate invader of index 0 at (-5,-2) Going from col 0 to col 1
                Vector3 position = rowPosition; //position = (-5, -2 + (0 * 0.6), 0)
                position.x += col * 0.6f; // -5 += (1 * 0.6)
                invaders.transform.localPosition = position; // set new position at (-4.4, -2, 0)
            }
        }
    }
}
