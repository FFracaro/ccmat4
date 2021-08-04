using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callHidratarPlantas : MonoBehaviour
{
    public Button btnCallAguaPlantas;
    public Canvas Plantacao;
    public Canvas AguaPlantas;
    public Canvas ErroAgua;

    // Use this for initialization
    void Start()
    {
        btnCallAguaPlantas.onClick.AddListener(chamarAguaPlantas);
    }

    void chamarAguaPlantas()
    {
        if (dataPersistence.PLANTAS_HIDRATADAS == 0)
        {
            AguaPlantas.gameObject.SetActive(true);
            Plantacao.gameObject.SetActive(false);
        }
        else
        {
            ErroAgua.gameObject.SetActive(true);
        }
    }
}
