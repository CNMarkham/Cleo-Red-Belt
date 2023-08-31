using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Vector3 clickStarLocation;

    public Vector3 launchVector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStarLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDiffrence = clickStarLocation - Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("Release!");
        }
    }
}
