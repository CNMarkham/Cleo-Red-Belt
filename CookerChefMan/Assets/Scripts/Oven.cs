using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    [Header("Prefrabs")]
    public GameObject muffin;

    [Header("Inventory")]
    public string cookedFood = "";
    public bool isCooking = false;

    [Header("Particles")]
    public ParticleSystem smoke;
    public ParticleSystem complete;

    // Start is called before the first frame update
    void Start()
    {
        muffin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
