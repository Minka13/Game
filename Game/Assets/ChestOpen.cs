using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public Animation ChestTrigger;
    public Component Chest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        ChestTrigger.Play();
        Chest.GetComponent<BoxCollider>().enabled = false;
    }
}
