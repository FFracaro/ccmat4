using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarCompraMilho : MonoBehaviour
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
    public GameObject[] milhos;

    private int pontos;

    // Use this for initialization
    void Start()
    {
        pontos = 300;
        btnConfirmarCompra.onClick.AddListener(comprarMilhos);
    }

    void comprarMilhos()
    {
        if (dataPersistence.moedas < dataPersistence.precoMilho)
        {
            canvasDinheiro.gameObject.SetActive(true);
            canvasConfirmar.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            if (dataPersistence.tipoPlantacao == 0)
            {
                if ((dataPersistence.moedas - dataPersistence.precoMilho) == Int32.Parse(input))
                {
                    dataPersistence.moedas = dataPersistence.moedas - dataPersistence.precoMilho;
                    dataPersistence.tipoPlantacao = 3;
                    dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                    pontos = 300;
                    canvasParabens.gameObject.SetActive(true);
                    canvasConfirmar.gameObject.SetActive(false);

                    int qtdPlantas = UnityEngine.Random.Range(20, 29);

                    dataPersistence.qtdMilho = qtdPlantas;

                    int iterator = 0;
                    while (true)
                    {
                        if (iterator > qtdPlantas)
                            break;
                        else
                        {
                            milhos[iterator].gameObject.SetActive(true);
                            iterator++;
                        }

                    }

                    updateValuesPlantacao updater = targetUpdatePlantacao.GetComponent<updateValuesPlantacao>();
                    updater.updatePlantacao();
                }
                else
                {
                    if ((dataPersistence.moedas - dataPersistence.precoMilho) > Int32.Parse(input))
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
