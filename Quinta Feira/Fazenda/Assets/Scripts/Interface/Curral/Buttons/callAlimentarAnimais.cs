using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callAlimentarAnimais : MonoBehaviour
{

    public Button btnCallAlimentarAnimais;
    public Canvas Curral;
    public Canvas AlimentarAnimais;
    public Canvas ErroAlimento;

    // Use this for initialization
    void Start()
    {
        btnCallAlimentarAnimais.onClick.AddListener(chamarAlimentarAnimais);
    }

    void chamarAlimentarAnimais()
    {
        if (dataPersistence.ANIMAIS_ALIMENTADOS == 0)
        {
            AlimentarAnimais.gameObject.SetActive(true);
            Curral.gameObject.SetActive(false);
        }
        else
        {
            ErroAlimento.gameObject.SetActive(true);
        }

    }
}
