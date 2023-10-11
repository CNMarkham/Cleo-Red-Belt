using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockers : MonoBehaviour
{

    public Rigidbody Fall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Fall.useGravity = true;
        Fall.isKinematic = false;
    }
}
