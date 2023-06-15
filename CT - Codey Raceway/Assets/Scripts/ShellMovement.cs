using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
