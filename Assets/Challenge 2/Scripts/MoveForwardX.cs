using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blue"))
        {
            PlayerControllerX.x += 1;
            Destroy(other.gameObject);

        }
        else if (other.gameObject.CompareTag("red"))
        {
            PlayerControllerX.x += 4;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("green"))
        {
            PlayerControllerX.x += 2;
            Destroy(other.gameObject);
        }

    }
}
