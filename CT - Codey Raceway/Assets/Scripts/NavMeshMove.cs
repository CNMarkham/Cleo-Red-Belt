using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMove : MonoBehaviour
{
    public NavMeshAgent aGeNt;

    // Start is called before the first frame update
    void Start()
    {
        aGeNt.destination = GameObject.FindGameObjectWithTag("Obstacle").transform.position;

        for ( )
    } 


    // Update is called once per frame
    void Update()
    {
        
    }
}
