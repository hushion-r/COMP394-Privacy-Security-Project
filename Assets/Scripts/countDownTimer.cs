using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    [SerializeField] GameObject stopScene;
    [SerializeField] Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopScene.activeInHierarchy) {
            currentTime -= 1 * Time.deltaTime;
            countDownText.text = currentTime.ToString("0");
        }

        
    }
}
