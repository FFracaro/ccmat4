using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarCompraGirassol : MonoBehaviour
{
    public Button btnConfirmarCompra;
    public Canvas canvasErroMais;
    public Canvas canvasErroMenos;
    public Canvas canvasParabens;
    public Canvas canvasPlantacaoCheia;
    public Canvas canvasConfirmar;
    public Canvas canvasDinheiro;
    public GameObject targetUpdatePlantacao;
    public InputField inputResult;
    public GameObject[] girassois;

    private int pontos;

    // Use this for initialization
    void Start()
    {
        pontos = 300;
        btnConfirmarCompra.onClick.AddListener(comprarGirassol);
    }

    void comprarGirassol()
    {
        if (dataPersistence.moedas < dataPersistence.precoGirassol)
        {
            canvasDinheiro.gameObject.SetActive(true);
            canvasConfirmar.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            if (dataPersistence.tipoPlantacao == 0)
            {
                if ((dataPersistence.moedas - dataPersistence.precoGirassol) == Int32.Parse(input))
                {
                    dataPersistence.moedas = dataPersistence.moedas - dataPersistence.precoGirassol;
                    dataPersistence.tipoPlantacao = 2;
                    dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                    pontos = 300;
                    canvasParabens.gameObject.SetActive(true);
                    canvasConfirmar.gameObject.SetActive(false);

                    int qtdPlantas = UnityEngine.Random.Range(20, 41);

                    dataPersistence.qtdGirassol = qtdPlantas;

                    int iterator = 0;
                    while (true)
                    {
                        if (iterator > qtdPlantas)
                            break;
                        else
                        {
                            girassois[iterator].gameObject.SetActive(true);
                            iterator++;
                        }

                    }

                    updateValuesPlantacao updater = targetUpdatePlantacao.GetComponent<updateValuesPlantacao>();
                    updater.updatePlantacao();
                }
                else
                {
                    if ((dataPersistence.moedas - dataPersistence.precoGirassol) > Int32.Parse(input))
                    {
                        canvasErroMenos.gameObject.SetActive(true);
                    }
                    else
                    {
                        canvasErroMais.gameObject.SetActive(true);
                    }

                    if (pontos > 50)
                    {
                        pontos = pontos - 30;
                    }
                }
            }
            else
            {
                canvasPlantacaoCheia.gameObject.SetActive(true);
                canvasConfirmar.gameObject.SetActive(false);
            }
        }
    }
}
