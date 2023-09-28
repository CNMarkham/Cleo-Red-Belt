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

    private Vector3 forwardAxis;
    private Vector3 sideAxis;

    // Update is called once per frame
    void Update()
    {
        if (LivesManager.lives < 0)
        {
            return;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            clickStarLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDiffrence = clickStarLocation - Input.mousePosition;

            launchVector = sideAxis * mouseDiffrence.x
                + forwardAxis * mouseDiffrence.y
                + Vector3.up * mouseDiffrence.y;
            sLimEtRanSfOrM.position = normalPosition - launchVector / 400;
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0))
        {
            sLimERigIdIbOdY.isKinematic = false;
            sLimERigIdIbOdY.AddForce(launchForce * launchVector, ForceMode.Impulse);

        }

        if (Input.GetMouseButtonDown(1))
        {
            sLimEtRanSfOrM.position = normalPosition;
            sLimEtRanSfOrM.rotation = normalRotation;
            sLimERigIdIbOdY.isKinematic = true;
            LivesManager.RemoveLife();
        }
    }

    private void Start()
    {
        normalPosition = sLimEtRanSfOrM.position;
        normalRotation = sLimEtRanSfOrM.rotation;

        forwardAxis = Camera.main.transform.forward;
        sideAxis = Camera.main.transform.right;
    }
}
