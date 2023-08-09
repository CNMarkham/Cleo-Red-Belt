using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFetures : MonoBehaviour
{

    public float RotationSpeed = 3;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 68, 49) * Time.deltaTime * RotationSpeed);
    }
    private void OnTriggerEnter(Collider a)
    {
        if (a.gameObject.CompareTag("Player"))
        {
            transform.localScale = Vector3.zero;
            Invoke("Reappear", 2f);
        }
    }

   

    private void Reappear()
    {
        transform.localScale = Vector3.one;
    }

}
