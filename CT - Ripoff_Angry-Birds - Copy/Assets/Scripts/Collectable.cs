using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    public Vector3 startingPosition;
    public Vector3 endingPosition;

    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startingPosition, endingPosition, curve.Evaluate(Time.time));
    }

    private void OnTriggerEnter(Collider C)
    {
        if (C.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
