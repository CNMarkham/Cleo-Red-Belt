using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider Sphere)
    {
        FindObjectOfType<CodeyMove>().Speed = 2000;
        Destroy(gameObject, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
