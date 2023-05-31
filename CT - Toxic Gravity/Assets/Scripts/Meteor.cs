using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meteor : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Collectable"))
        {
            StartCoroutine(boom());
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level2");
        }
    }

    IEnumerator boom()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<ParticleSystem>().Play();
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(3f);
/*        this.gameObject.GetComponent<ParticleSystem>().Stop();*/
        Destroy(this.gameObject);

    }
}
