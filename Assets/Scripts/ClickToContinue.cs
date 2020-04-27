using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToContinue : MonoBehaviour
{   public GameObject previous;
    public GameObject good;
    public GameObject bad;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
  		{
            previous.SetActive(false);
            good.SetActive(true);
            bad.SetActive(true);
            
  		}
    }
}
