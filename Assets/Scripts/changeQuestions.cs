using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeQuestions : MonoBehaviour
{
    public GameObject nextQuestion;
    public GameObject thisQuestion;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void SwitchScenario()
    {
        thisQuestion.SetActive(false);
        nextQuestion.SetActive(true);
    }
}
