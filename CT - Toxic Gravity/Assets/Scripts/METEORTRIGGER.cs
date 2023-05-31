using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class METEORTRIGGER : MonoBehaviour
{
    public MeteorSpawner meteor;
    public Collider2D Bloker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // triggered by player

    // I want it when you pass the meteor trigger you can not go back
    // Then the meteors will start to spawn from in between the x axis, 1 or 25
    // I only want the meteors to spawn every single 2 seconds.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Bloker.gameObject.SetActive(true);
        }

        meteor.spawnmeteors();
    }

    
}
