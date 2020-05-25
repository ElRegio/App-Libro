using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCoatiInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoCoati;
    GameObject DatoPino;
    GameObject DatoCoati2;
    GameObject DatoCoati3;

    // Use this for initialization
    void Start()
    {

        DatoCoati = GameObject.Find("CoatiDato");
        DatoCoati.SetActive(false);

        DatoCoati2 = GameObject.Find("CoatiDato2");
        DatoCoati2.SetActive(false);

        DatoCoati3 = GameObject.Find("CoatiDato3");
        DatoCoati3.SetActive(false);

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);
        
    }

    public void Next()
    {
        DatoCoati.SetActive(false);
        DatoCoati2.SetActive(true);
    }
    public void Next2()
    {
        DatoCoati2.SetActive(false);
        DatoCoati3.SetActive(true);
    }
    public void Close()
    {
        DatoCoati.SetActive(false);
        DatoCoati2.SetActive(false);
        DatoCoati3.SetActive(false);
        DatoPino.SetActive(false);
        

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                //btnName = Hit.transform.gameObject.tag;

                switch (btnName)
                {
                    case "Coati":
                        DatoCoati.SetActive(true);
                        DatoPino.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        break;

                    case "Pino":
                        DatoPino.SetActive(true);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        break;

                    

                }
            }

        }
    }
}
