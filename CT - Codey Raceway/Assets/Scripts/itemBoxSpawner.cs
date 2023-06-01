using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;


    // Start is called before the first frame update
    void Start()
    {
        for (int p = 0; p <= numberOfBoxes; p++)
        {
            GameObject itemBoxClone = Instantiate(itemBox, transform.position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
