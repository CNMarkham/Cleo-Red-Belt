 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{

    public GameObject toast;
    public GameObject friedEgg;

    public string cookedFood = "";

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
    }

    public void ToastBread()
    {
        toast.SetActive(true);
        cookedFood = "toast";
    }

    public void CleanToaster()
    {
        toast.SetActive(false);
    }
}
