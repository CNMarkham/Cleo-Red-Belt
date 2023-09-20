using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Vector3 clickStarLocation;

    public Vector3 launchVector;

    public float launchForce;

    public Transform sLimEtRanSfOrM;
    public Rigidbody sLimERigIdIbOdY;

    private Vector3 normalPosition;

    private Quaternion normalRotation;

    [Header("Lives")]
    public LivesManager LivesManager;

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
            launchVector = new Vector3(
                mouseDiffrence.x * 1f,
                mouseDiffrence.y * 1.2f,
                mouseDiffrence.y * 1.5f
                );
            sLimEtRanSfOrM.position = normalPosition - launchVector / 400;
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0))
        {
            sLimERigIdIbOdY.isKinematic = false;
            sLimERigIdIbOdY.AddForce(launchForce * launchVector, ForceMode.Impulse);

        }

        if (Input.GetMouseButton(1))
        {
            Vector3 Position = normalPosition;
            Quaternion Rotation = normalRotation;
        }
    }

    private void Start()
    {
        normalPosition = sLimEtRanSfOrM.position;
        normalRotation = sLimEtRanSfOrM.rotation;
    }
}
