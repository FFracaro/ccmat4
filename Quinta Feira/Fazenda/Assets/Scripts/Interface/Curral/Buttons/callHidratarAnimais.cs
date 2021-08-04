using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callHidratarAnimais : MonoBehaviour
{
    public Button btnCallAguaAnimais;
    public Canvas Curral;
    public Canvas AguaAnimais;
    public Canvas ErroAgua;

    // Use this for initialization
    void Start()
    {
        btnCallAguaAnimais.onClick.AddListener(chamarAguaAnimais);
    }

    void chamarAguaAnimais()
    {
        if (dataPersistence.ANIMAIS_HIDRATADOS == 0)
        {
            AguaAnimais.gameObject.SetActive(true);
            Curral.gameObject.SetActive(false);
        }
        else
        {
            ErroAgua.gameObject.SetActive(true);
        }

    }
}
