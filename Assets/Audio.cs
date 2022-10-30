using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
   
    public AudioClip zvuk;
    public AudioSource source;
    private bool Zvuk = false;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    void Update()
{
	if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "tripod")
                {
                    if (!Zvuk)
                    {
                        source.clip = zvuk;
                        source.Play();
                        Zvuk = true;
                    }
                    else
                    {
                        source.Stop();
                        Zvuk = false;
                    }
                }
            }
        }
}
}


    