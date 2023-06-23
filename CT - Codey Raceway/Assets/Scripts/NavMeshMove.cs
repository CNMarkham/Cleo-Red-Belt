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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        aGeNt.destination = GameObject.FindGameObjectWithTag("Obstacle").transform.position;
    }
}
