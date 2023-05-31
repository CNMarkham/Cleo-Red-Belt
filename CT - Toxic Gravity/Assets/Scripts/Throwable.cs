using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter = 0;
    public AnimateMovement AM;
    public Text collectableCounter;
    int Number;
    public Text Daggers;

    // Start is called before the first frame update
    void Start()
    {
        AM = GetComponent<AnimateMovement>();
        offset = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {

            throwableCounter--;
            collectableCounter.text = throwableCounter.ToString();

            Quaternion rotation;
            if (AM.facingRight)
            {
                rotation = Quaternion.Euler(0, 0, 90);
            }
            else
            {
                rotation = Quaternion.Euler(0, 180, 90);
            }

            Vector3 throwablePosition = transform.position + offset;
            offset = new Vector3(1, 0, 0);
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Instantiate(objectThrown, throwablePosition, rotation); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Collectable") 
        {
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);

        }
        

    }
}
