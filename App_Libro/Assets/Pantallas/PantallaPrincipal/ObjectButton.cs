using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectButton : MonoBehaviour {
    string btnName;
    GameObject Dato;
    
    
    
	// Use this for initialization
	void Start () {
        
        Dato = GameObject.Find("Panel");
        Dato.SetActive(false);
    }

    public void Close()
    {

        Dato.SetActive(false);

    }
    // Update is called once per frame
    void Update () {
		
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray,out Hit))
            {
                btnName = Hit.transform.name;
                //btnName = Hit.transform.gameObject.tag;
                  
                switch (btnName)
                {
                    case "Sicomoro":
                        transform.localScale = new Vector3 (5f, 2f, 10f);
                        Dato.SetActive(true);
                                break;

                }
            }

        }
	}
}
