using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float s;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -35 || transform.position.y <0)
        {
            Destroy(gameObject);    
        }
        
    }
}
