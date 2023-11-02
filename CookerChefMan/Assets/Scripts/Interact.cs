using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Toaster toaster;

    public string triggerName = "";

    public GameObject breadPrefab;

    public GameObject heldItem;
    public string heldItemName;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "bread")
            {
                heldItem = Instantiate(breadPrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(1, 1, 0);
                heldItem.transform.localScale = new Vector3(3, 3, 3);
                heldItemName = "breadSlice";
            }

            if (triggerName == "Toaster")
            {
                Debug.Log("Im at the Toaster!");
                if(heldItemName == "breadSlice")
                {
                    print("Ready to Toast!");
                    Destroy(heldItem);
                    heldItemName = "";
                    toaster.ToastBread();
                }
                else
                {
                    print("Codey is empty Handed");
                    if(toaster.cookedFood == "toast")
                    {
                        heldItem = Instantiate(breadPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(1, 1, 0);
                        heldItemName = "toastSlice";
                        toaster.CleanToaster();
                        heldItem.transform.localScale = new Vector3(3, 3, 3);
                    }
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
