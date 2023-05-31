using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public Teleport Beans;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        Beans = GameObject.FindGameObjectWithTag("Portal").GetComponent<Teleport>();
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        if(gameObject.tag == "Dagger") 
        {
            Invoke("DestroyThrowable", 7);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Dagger")
        {
            transform.position += direction.offset * Time.deltaTime * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyCollision>().health -= 1;

            if (collision.gameObject.GetComponent<EnemyCollision>().health == 0)
            {
                Destroy(collision.gameObject);
                Beans.enemyCount--;
            }
            Destroy(this.gameObject);
        }

    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}

