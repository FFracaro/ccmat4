using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callPlantarPlantas : MonoBehaviour
{
    public Button btnCallComprarSementes;
    public Canvas Plantacao;
    public Canvas ComprarSementes;

    // Use this for initialization
    void Start()
    {
        btnCallComprarSementes.onClick.AddListener(chamarComprarSementes);
    }

    void chamarComprarSementes()
    {
        ComprarSementes.gameObject.SetActive(true);
        Plantacao.gameObject.SetActive(false);
    }
}
