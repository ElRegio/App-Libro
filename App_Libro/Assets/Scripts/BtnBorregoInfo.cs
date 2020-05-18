using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBorregoInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoBorrego;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;
    GameObject DatoBorrego2;
    GameObject DatoBorrego3;

    // Use this for initialization
    void Start()
    {

        DatoBorrego = GameObject.Find("BorregoDato");
        DatoBorrego.SetActive(false);

        DatoBorrego2 = GameObject.Find("BorregoDato2");
        DatoBorrego2.SetActive(false);

        DatoBorrego3 = GameObject.Find("BorregoDato3");
        DatoBorrego3.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void Next()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(true);
    }
    public void Next2()
    {
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(true);
    }
    public void Close()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(false);
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
                    case "Borrego":
                        DatoBorrego.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Alamo":
                        DatoCactus.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Sicomoro":
                        DatoCoryphantha.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Maguey":
                        DatoIzote.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                }
            }

        }
    }
}
