using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnJabaliInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoJabali;
    GameObject DatoCeriman;
    GameObject DatoCaoba;
    GameObject DatoCedroRojo;
    GameObject DatoHelecho;
    GameObject DatoLiana;
    GameObject DatoJabali2;

    // Use this for initialization
    void Start()
    {

        DatoJabali = GameObject.Find("JabaliDato");
        DatoJabali.SetActive(false);

        DatoJabali2 = GameObject.Find("JabaliDato2");
        DatoJabali2.SetActive(false);

        DatoCeriman = GameObject.Find("CerimanDato");
        DatoCeriman.SetActive(false);

        DatoCaoba = GameObject.Find("CaobaDato");
        DatoCaoba.SetActive(false);

        DatoCedroRojo = GameObject.Find("CedroDato");
        DatoCedroRojo.SetActive(false);

        DatoHelecho = GameObject.Find("HelechoDato");
        DatoHelecho.SetActive(false);

        DatoLiana = GameObject.Find("LianaDato");
        DatoLiana.SetActive(false);

    }

    public void Next()
    {
        DatoJabali.SetActive(false);
        DatoJabali2.SetActive(true);
        
    }
    public void Next2()
    {
       
    }
    public void Close()
    {
        DatoJabali.SetActive(false);
        DatoHelecho.SetActive(false);
        DatoLiana.SetActive(false);
        DatoCeriman.SetActive(false);
        DatoCaoba.SetActive(false);
        DatoCedroRojo.SetActive(false);
        DatoJabali2.SetActive(false);

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
                    case "Jabali":
                        DatoJabali.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    case "Ceriman":
                        DatoCeriman.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    case "Caoba":
                        DatoCaoba.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    case "CedroRojo":
                        DatoCedroRojo.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    case "Helecho":
                        DatoHelecho.SetActive(true);
                        DatoLiana.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                       DatoCedroRojo.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    case "Liana":
                        DatoLiana.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoJabali2.SetActive(false);
                        break;

                    
                }
            }

        }
    }
}
