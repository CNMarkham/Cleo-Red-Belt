using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;
    public GameObject[] Enemies;

    // Start is called before the first frame update
    void Start()
    {
        if (Enemies == null)
        {
            Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            enemyCount = Enemies.Length;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemyCount == 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   
}
