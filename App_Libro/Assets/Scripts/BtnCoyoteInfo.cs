using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCoyoteInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoCoyote;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;
    GameObject DatoCoyote2;
   

    // Use this for initialization
    void Start()
    {

        DatoCoyote = GameObject.Find("CoyoteDato");
        DatoCoyote.SetActive(false);

        DatoCoyote2 = GameObject.Find("CoyoteDato2");
        DatoCoyote2.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void Next()
    {
        DatoCoyote.SetActive(false);
        DatoCoyote2.SetActive(true);
    }
   
    public void Close()
    {
        DatoCoyote.SetActive(false);
        DatoCoyote2.SetActive(false);
        DatoCactus.SetActive(false);
        DatoCoryphantha.SetActive(false);
        DatoIzote.SetActive(false);

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
                    case "Coyote":
                        DatoCoyote.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoCoyote.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Coryphantha":
                        DatoCoryphantha.SetActive(true);
                        DatoCoyote.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Izote":
                        DatoIzote.SetActive(true);
                        DatoCoyote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                }
            }

        }
    }
}
