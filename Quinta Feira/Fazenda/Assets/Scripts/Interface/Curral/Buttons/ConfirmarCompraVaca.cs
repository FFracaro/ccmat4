using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarCompraVaca : MonoBehaviour
{

    public Button btnConfirmarCompra;
    public Canvas canvasErroMais;
    public Canvas canvasErroMenos;
    public Canvas canvasParabens;
    public Canvas canvasCurralCheio;
    public Canvas canvasConfirmar;
    public Canvas canvasDinheiro;
    public GameObject targetUpdateCurral;
    public InputField inputResult;
    public GameObject[] vacas;

    private int pontos;

    // Use this for initialization
    void Start()
    {
        pontos = 150;
        btnConfirmarCompra.onClick.AddListener(comprarVaca);
    }

    void comprarVaca()
    {
        if (dataPersistence.moedas < dataPersistence.precoVaca)
        {
            canvasDinheiro.gameObject.SetActive(true);
            canvasConfirmar.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            if (((2 + dataPersistence.dias) - (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca)) > 0)
            {
                if ((dataPersistence.moedas - dataPersistence.precoVaca) == Int32.Parse(input))
                {
                    dataPersistence.moedas = dataPersistence.moedas - dataPersistence.precoVaca;
                    dataPersistence.vaca = dataPersistence.vaca + 1;
                    dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                    pontos = 150;
                    canvasParabens.gameObject.SetActive(true);
                    canvasConfirmar.gameObject.SetActive(false);

                    int iterator = 0;
                    while (true)
                    {
                        if (iterator > vacas.Length)
                            break;
                        if (vacas[iterator].gameObject.activeSelf)
                            iterator++;
                        else
                        {
                            vacas[iterator].gameObject.SetActive(true);
                            break;
                        }
                    }

                    updateValuesCurral updater = targetUpdateCurral.GetComponent<updateValuesCurral>();
                    updater.updateCurral();
                }
                else
                {
                    if ((dataPersistence.moedas - dataPersistence.precoVaca) > Int32.Parse(input))
                    {
                        canvasErroMenos.gameObject.SetActive(true);
                    }
                    else
                    {
                        canvasErroMais.gameObject.SetActive(true);
                    }

                    if (pontos > 50)
                    {
                        pontos = pontos - 10;
                    }
                }
            }
            else
            {
                canvasCurralCheio.gameObject.SetActive(true);
                canvasConfirmar.gameObject.SetActive(false);
            }
        }
    }
}
