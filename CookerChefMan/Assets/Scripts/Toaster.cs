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
    public bool isCooking = false;

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
        isCooking = true;
        smoke.Play();
        toast.SetActive(true);
        Invoke("CompleteToasting", 6f);
    }

    public void CleanToaster()
    {
        toast.SetActive(false);
        complete.Stop();
    }

    private void CompleteToasting()
    {
        cookedFood = "toast";
        isCooking = false;
        smoke.Stop();
        complete.Play();
    }

    // when complete is played than codey is able to pick up the food :) You can not take the food when the smoke is playing and the complete is not playing qw
}
