using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x <-35)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        

    }
}
