using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecionarObjeto : MonoBehaviour
{
    public LayerMask mask;
    public float MaxDistance = 100.0f;
    public Canvas canvasAnimais;
    public Canvas canvasPlantas;
    public Canvas canvasFim;
    public Canvas canvasAlmost;
    public Canvas canvasFrutas;
    public Canvas canvasFrutasError;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {

            RaycastHit hit, hitPlayer;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit, MaxDistance, mask))
            {
                if (hit.transform != null)
                {
                    if (Physics.Raycast(transform.position, (hit.point - transform.position).normalized, out hitPlayer, MaxDistance, mask))
                    {
                        if (hitPlayer.transform.gameObject.CompareTag("Animais")
                            && !canvasAnimais.gameObject.activeSelf)
                        {
                            Debug.Log("CLIQUEI NA FARM CAPETA DOS INFERNOS");
                            callInterfacePrincipal();
                        }
                        else
                        {
                            if (hitPlayer.transform.gameObject.CompareTag("Plantacao")
                            && !canvasPlantas.gameObject.activeSelf)
                            {
                                Debug.Log("CLIQUEI NA PLANTA CAPETA DOS INFERNOS");
                                callInterfacePlantas();
                            }
                            else
                            {
                                if (hitPlayer.transform.gameObject.CompareTag("Save")
                                    && !canvasAlmost.gameObject.activeSelf 
                                    && !canvasFim.gameObject.activeSelf)
                                {
                                    Debug.Log("CLIQUEI NO SAVE DO CAPETA DOS INFERNOS");
                                    callInterfaceFim();
                                }
                                else
                                {
                                    if (hitPlayer.transform.gameObject.CompareTag("Arvores")
                                    )
                                    {
                                        Debug.Log("CLIQUEI NA ARVORE DO SATANAS DO CAPETA DOS INFERNOS");
                                        callInterfaceFrutas();
                                    }
                                }
                            }
                        }
                        print(hitPlayer.distance);
                        print(hit.transform.name);
                        Debug.DrawRay(transform.position, (hit.point - transform.position).normalized * 5, Color.red, 2);
                    }

                }

                Debug.DrawLine(ray.origin, hit.point, Color.red);
            }
        }
    }

    void callInterfacePrincipal ()
    {
        canvasAnimais.gameObject.SetActive(true);
    }

    void callInterfacePlantas()
    {
        canvasPlantas.gameObject.SetActive(true);
    }

    void callInterfaceFrutas()
    {
        if (dataPersistence.arvore == 0)
            canvasFrutas.gameObject.SetActive(true);
        else
            canvasFrutasError.gameObject.SetActive(true);
    }

    void callInterfaceFim()
    {
        if (dataPersistence.ANIMAIS_ALIMENTADOS == 1
            && dataPersistence.ANIMAIS_HIDRATADOS == 1
            && dataPersistence.PLANTAS_HIDRATADAS == 1
            && !canvasAlmost.gameObject.activeSelf)
        {
            canvasFim.gameObject.SetActive(true);
        }
        else
        {
            canvasAlmost.gameObject.SetActive(true);
        }
    }
}
