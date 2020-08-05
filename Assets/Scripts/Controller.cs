using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public GameObject animationRing;
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            animationRing.SetActive(true);
        }

        if(Input.GetKeyUp(KeyCode.Tab))
        {
            animationRing.SetActive(false);
        }
        
    }
}
