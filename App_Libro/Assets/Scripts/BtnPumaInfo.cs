using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPumaInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoPuma;
    GameObject DatoPino;
    GameObject DatoPuma2;
    GameObject DatoPuma3;

    // Use this for initialization
    void Start()
    {

        DatoPuma = GameObject.Find("PumaDato");
        DatoPuma.SetActive(false);

        DatoPuma2 = GameObject.Find("PumaDato2");
        DatoPuma2.SetActive(false);

        DatoPuma3 = GameObject.Find("PumaDato3");
        DatoPuma3.SetActive(false);

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);

    }

    public void Next()
    {
        DatoPuma.SetActive(false);
        DatoPuma2.SetActive(true);
    }
    public void Next2()
    {
        DatoPuma2.SetActive(false);
        DatoPuma3.SetActive(true);
    }
    public void Close()
    {
        DatoPuma.SetActive(false);
        DatoPuma2.SetActive(false);
        DatoPuma3.SetActive(false);
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
                    case "Puma":
                        DatoPuma.SetActive(true);
                        DatoPino.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        break;

                    case "Pino":    
                        DatoPino.SetActive(true);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        break;



                }
            }

        }
    }
}
