using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnmeteors()
    {
        Vector3 mozart = new Vector3(Random.Range(1.5f, 17.5f),7.12f ,0f );
        GameObject Meteor = Instantiate(meteor,mozart,Quaternion.identity);
        Meteor.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6f, 5),-10f);


        Invoke("spawnmeteors", 10);
    }


}
