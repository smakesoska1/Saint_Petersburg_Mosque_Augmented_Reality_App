using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlane : MonoBehaviour
{   public VideoPlayer videoPlayer;
    public GameObject Video;
    Ray ray;
    RaycastHit hit;
    int brojac = 0;
    // Start is called before the first frame update
    void Start()
    {
        Video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name =="Tepih")
                {
                    if (brojac == 0)
                    {
                        videoPlayer.Pause();
                        Video.SetActive(false);
                        brojac = 1;

                    }
                    else
                    {
                        Video.SetActive(true);
                        videoPlayer.Play();
                        brojac = 0;
                    }
                    
                } 
            }
        }
    }
}