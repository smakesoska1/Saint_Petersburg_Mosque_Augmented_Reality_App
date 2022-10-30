using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stolknjiga : MonoBehaviour
{
 Ray ray;
    RaycastHit hit;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "stol i knjiga")
                {
                    if (text.activeSelf)
                        text.SetActive(false);
                    else
                        text.SetActive(true);
                   
                }
    }
}
}
}
