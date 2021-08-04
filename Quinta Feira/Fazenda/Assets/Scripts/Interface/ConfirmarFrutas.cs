using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarFrutas : MonoBehaviour
{
    public Button btnFrutar;
    public Canvas ErroMais;
    public Canvas ErroMenos;
    public Canvas Confirma;
    public Canvas canvasFrutas;
    public Canvas NoFrutos;
    public GameObject targetUpdateCurral;
    public InputField inputResult;
    public Text qtdMacas;
    public GameObject Maca1;
    public GameObject Maca2;
    public GameObject Maca3;

    private int pontos;
    private int macas;

    // Use this for initialization
    void Start()
    {
        qtdMacas.text = dataPersistence.qtdMacas + "";
        pontos = 200;
        btnFrutar.onClick.AddListener(coletarFrutas);
    }

    void coletarFrutas ()
    {
        if (dataPersistence.arvore == 1)
        {
            NoFrutos.gameObject.SetActive(true);
            canvasFrutas.gameObject.SetActive(false);
        }
        else
        {
            string input = inputResult.text;

            int calcResult = dataPersistence.qtdMacas * 3;

            if (calcResult == Int32.Parse(input))
            {
                dataPersistence.pontuacao = dataPersistence.pontuacao + pontos;
                pontos = 200;

                dataPersistence.moedas = dataPersistence.moedas + (10 * dataPersistence.qtdMacas);

                Confirma.gameObject.SetActive(true);
                canvasFrutas.gameObject.SetActive(false);

                dataPersistence.arvore = 1;
                Maca1.gameObject.SetActive(false);
                Maca2.gameObject.SetActive(false);
                Maca3.gameObject.SetActive(false);

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
                if (pontos > 50)
                {
                    pontos = pontos - 10;
                }
            }
        }
    }
}
