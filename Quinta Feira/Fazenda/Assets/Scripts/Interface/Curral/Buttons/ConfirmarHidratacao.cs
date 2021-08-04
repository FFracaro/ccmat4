using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarHidratacao : MonoBehaviour
{
    public Button btnHidratar;
    public Canvas ErroMais;
    public Canvas ErroMenos;
    public Canvas Confirma;
    public Canvas Agua;
    public Canvas NoAnimals;
    public GameObject targetUpdateCurral;
    public InputField inputResult;

    private int pontos;

    // Use this for initialization
    void Start()
    {
        pontos = 200;
        btnHidratar.onClick.AddListener(hidratarAnimais);
    }

    void hidratarAnimais()
    {
        if ((dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca) == 0)
        {
            NoAnimals.gameObject.SetActive(true);
            Agua.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            int calcResult = (dataPersistence.aguaOvelha * dataPersistence.ovelhas)
                + (dataPersistence.aguaPorco * dataPersistence.porcos)
                + (dataPersistence.aguaVaca * dataPersistence.vaca);

            if (calcResult == Int32.Parse(input))
            {
                dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                pontos = 200;

                Confirma.gameObject.SetActive(true);
                Agua.gameObject.SetActive(false);

                dataPersistence.ANIMAIS_HIDRATADOS = 1;

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
                if (pontos > 80)
                {
                    pontos = pontos - 15;
                }
            }
        }
    }
}
