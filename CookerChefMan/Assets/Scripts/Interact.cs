using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public string triggerName = "";

    public GameObject breadPrefab;

    public GameObject heldItem;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "bread")
            {
                heldItem = Instantiate(breadPrefab, transform, false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
