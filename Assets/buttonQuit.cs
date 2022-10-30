using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonQuit : MonoBehaviour
{
   public GameObject Panel;

	public void OpenPanel(){
		if(Panel!=null){
		bool isActive=Panel.activeSelf;
		Panel.SetActive(!isActive);
		}
			}
    public void Quit()
    {
       
 Application.Quit();
         
    }

public void Link()
    {
        Application.OpenURL("https://c2.etf.unsa.ba/course/view.php?id=44");
    }
}

