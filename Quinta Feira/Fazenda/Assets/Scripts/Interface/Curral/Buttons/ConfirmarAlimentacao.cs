using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarAlimentacao : MonoBehaviour
{
    public Button btnAlimentar;
    public Canvas ErroMais;
    public Canvas ErroMenos;
    public Canvas Confirma;
    public Canvas Alimentar;
    public Canvas NoAnimals;
    public GameObject targetUpdateCurral;
    public InputField inputResult;

    private int pontos;

    // Use this for initialization
    void Start ()
    {
        pontos = 300;
        btnAlimentar.onClick.AddListener(alimentarAnimais);
	}

    void alimentarAnimais()
    {
        if ((dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca) == 0)
        {
            NoAnimals.gameObject.SetActive(true);
            Alimentar.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            int calcResult = (dataPersistence.comidaOvelha * dataPersistence.ovelhas)
                + (dataPersistence.comidaPorco * dataPersistence.porcos)
                + (dataPersistence.comidaVaca * dataPersistence.vaca);

            if (calcResult == Int32.Parse(input))
            {
                dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                pontos = 300;

                Confirma.gameObject.SetActive(true);
                Alimentar.gameObject.SetActive(false);

                dataPersistence.ANIMAIS_ALIMENTADOS = 1;

                updateValuesCurral updater = targetUpdateCurral.GetComponent<updateValuesCurral>();
                updater.updateCurral();
            }
            else
            {
                if (calcResult > Int32.Parse(input))
                {
                    ErroMenos.gameObject.SetActive(true);
                }
                else
                {
                    ErroMais.gameObject.SetActive(true);
                }
                if (pontos > 100)
                {
                    pontos = pontos - 20;
                }
            }
        }
    }
}
