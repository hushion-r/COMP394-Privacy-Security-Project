using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class videoPlayer : MonoBehaviour
{
    public VideoPlayer player;
    public GameObject button;
    public GameObject codec;
 
    // Start is called before the first frame update
    void Start()
    {
        
        player.loopPointReached += getCodec;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void getCodec(UnityEngine.Video.VideoPlayer vp)
    {
        codec.SetActive(true);
    }

    public void play()
    {
   
        button.SetActive(false);
        player.Play();
   
    }
}
