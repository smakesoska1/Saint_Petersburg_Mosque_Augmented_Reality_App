using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{

    //public GameObject stol i knjiga;
    public GameObject Plane;

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        Plane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0)) {

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit)) {

                if(hit.collider.gameObject.name == "stol i knjiga") {

                    if(Plane.activeSelf)
			Plane.SetActive(false);
                    else 
			Plane.SetActive(true);     

            }

        }

    }
}
}
