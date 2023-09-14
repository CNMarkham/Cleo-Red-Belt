using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition =  (startingPosition.x +);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
