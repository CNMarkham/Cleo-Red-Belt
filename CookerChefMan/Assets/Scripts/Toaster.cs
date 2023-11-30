 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{

    [Header("Prefrabs")]
    public GameObject friedEgg;
    public GameObject toast;

    [Header("Inventory")]
    public string cookedFood = "";

    [Header("Particles")]
    public ParticleSystem smoke;
    public ParticleSystem complete;

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
    }

    public void ToastBread()
    {
        smoke.Play();
        toast.SetActive(true);
        cookedFood = "toast";
    }

    public void CleanToaster()
    {
        toast.SetActive(false);
    }
}
