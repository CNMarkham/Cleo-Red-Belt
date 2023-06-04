using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;

    public int numberOfBoxes;

    public int modifyXposition;
    public int modifyZposition;

    // Start is called before the first frame update
    void Start()
    {
        for (int p = 0; p <= numberOfBoxes; p++)
        {
            GameObject itemBoxClone = Instantiate(
                itemBox,
                new Vector3 (
                    transform.position.x + modifyXposition * p,
                    transform.position.y,
                    transform.position.z + modifyZposition * p
                    ),
                transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
