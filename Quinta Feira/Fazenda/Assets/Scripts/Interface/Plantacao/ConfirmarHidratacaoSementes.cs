using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarHidratacaoSementes : MonoBehaviour
{
    public Button btnHidratar;
    public Canvas ErroMais;
    public Canvas ErroMenos;
    public Canvas Confirma;
    public Canvas Agua;
    public Canvas NoPlantas;
    public GameObject targetUpdatePlantacao;
    public InputField inputResult;

    private int pontos;

    // Use this for initialization
    void Start()
    {
        pontos = 400;
        btnHidratar.onClick.AddListener(hidratarPlantas);
    }

    void hidratarPlantas()
    {
        if ((dataPersistence.tipoPlantacao) == 0)
        {
            NoPlantas.gameObject.SetActive(true);
            Agua.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            int calcResult = 0;

            if (dataPersistence.tipoPlantacao == 1)
                calcResult = dataPersistence.aguaTrigo * dataPersistence.qtdTrigo;
            else if (dataPersistence.tipoPlantacao == 2)
                calcResult = dataPersistence.aguaGirassol * dataPersistence.qtdGirassol;
            else if (dataPersistence.tipoPlantacao == 3)
                calcResult = dataPersistence.aguaMilho * dataPersistence.qtdMilho;

            if (calcResult == Int32.Parse(input))
            {
                dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                pontos = 400;

                Confirma.gameObject.SetActive(true);
                Agua.gameObject.SetActive(false);

                dataPersistence.PLANTAS_HIDRATADAS = 1;

                updateValuesPlantacao updater = targetUpdatePlantacao.GetComponent<updateValuesPlantacao>();
                updater.updatePlantacao();
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
                    pontos = pontos - 40;
                }
            }
        }
    }
}
