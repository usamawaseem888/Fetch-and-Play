using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ss : MonoBehaviour
{
    public TextMeshProUGUI sss;
   
    
    // Start is called before the first frame update
    void Start()
    {
        sss.text = PlayerControllerX.x.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        sss.text = "score: " + PlayerControllerX.x.ToString();

    }
}
