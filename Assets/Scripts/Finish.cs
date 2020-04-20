using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public void doQuit()
    {
        Debug.Log("Exiting");
        Application.
            Quit();
    }


}
