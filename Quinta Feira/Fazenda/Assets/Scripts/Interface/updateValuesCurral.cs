using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateValuesCurral : MonoBehaviour
{
    public Text textoOvelhaQtd;
    public Text textoPorcoQtd;
    public Text textoVacaQtd;
    public Text totalAnimais;
    public Text capacidadeMax;
    public Text precoOvelha;
    public Text precoPorco;
    public Text precoVaca;
    public Text capacidadeMaxMercado;
    public Text qtdMoedasMercado;

    public Text precoOvelhaCC;
    public Text precoVacaCC;
    public Text precoPorcoCC;
    public Text qtdMoedasOvelhaCC;
    public Text qdtMoedasVacaCC;
    public Text qtdMoedasPorcoCC;
    public Text questionOvelhaCC;
    public Text questionPorcoCC;
    public Text questionVacaCC;

    public Text qtdComidaOvelha;
    public Text qtdComidaPorco;
    public Text qtdComidaVaca;
    public Text qtdOvelha;
    public Text qtdPorco;
    public Text qtdVaca;

    public TextMeshProUGUI Pontuacao;
    public TextMeshProUGUI Moedas;

    public Text qtdAguaOvelha;
    public Text qtdAguaPorco;
    public Text qtdAguaVaca;
    public Text qtdOvelhaA;
    public Text qtdPorcoA;
    public Text qtdVacaA;

    void Awake()
    {
        dataPersistence.qtdMacas = Random.Range(2, 11);
    }

    // Use this for initialization
    void Start()
    {
        Pontuacao.text = "Pontuação: " + dataPersistence.pontuacao;
        Pontuacao.ForceMeshUpdate();

        Moedas.text = "Moedas: " + dataPersistence.moedas;
        Moedas.ForceMeshUpdate();

        textoOvelhaQtd.text = "Quantidade: " + dataPersistence.ovelhas;
        textoPorcoQtd.text = "Quantidade: " + dataPersistence.porcos;
        textoVacaQtd.text = "Quantidade: " + dataPersistence.vaca;
        totalAnimais.text = "Total de animais no curral: " + (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca);
        capacidadeMax.text = "Capacidade máxima do curral: " + (2 + dataPersistence.dias) + " animais.";
        dataPersistence.precoOvelha = calcPreco(125);
        dataPersistence.precoPorco = calcPreco(100);
        dataPersistence.precoVaca = calcPreco(150);
        precoOvelha.text = "Preço: " + dataPersistence.precoOvelha;
        precoPorco.text = "Preço: " + dataPersistence.precoPorco;
        precoVaca.text = "Preço: " + dataPersistence.precoVaca;
        capacidadeMaxMercado.text = "Seu curral têm capacidade para mais " + ((2 + dataPersistence.dias) - (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca)) + " animais.";
        qtdMoedasMercado.text = "Você possui " + dataPersistence.moedas + " moedas.";
        precoOvelhaCC.text = "Preço: " + dataPersistence.precoOvelha + " moedas.";
        precoVacaCC.text = "Preço: " + dataPersistence.precoVaca + " moedas.";
        precoPorcoCC.text = "Preço: " + dataPersistence.precoPorco + " moedas.";
        qtdMoedasOvelhaCC.text = "Quantidade: " + dataPersistence.moedas;
        qdtMoedasVacaCC.text = "Quantidade: " + dataPersistence.moedas;
        qtdMoedasPorcoCC.text = "Quantidade: " + dataPersistence.moedas;
        questionOvelhaCC.text = "Uma ovelha custa " + dataPersistence.precoOvelha + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra da ovelha?";
        questionPorcoCC.text = "Um porco custa " + dataPersistence.precoPorco + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra do porco?";
        questionVacaCC.text = "Uma vaca custa " + dataPersistence.precoVaca + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra da vaca?";
        dataPersistence.comidaOvelha = calcComida(10);
        dataPersistence.comidaPorco = calcComida(15);
        dataPersistence.comidaVaca = calcComida(25);
        qtdComidaOvelha.text = dataPersistence.comidaOvelha + " Kg";
        qtdComidaPorco.text = dataPersistence.comidaPorco + " Kg";
        qtdComidaVaca.text = dataPersistence.comidaVaca + " Kg";
        qtdOvelha.text = dataPersistence.ovelhas + "";
        qtdPorco.text = dataPersistence.porcos + "";
        qtdVaca.text = dataPersistence.vaca + "";
        dataPersistence.aguaOvelha = calcAguaa(15);
        dataPersistence.aguaPorco = calcAguaa(12);
        dataPersistence.aguaVaca = calcAguaa (22);
        qtdAguaOvelha.text = dataPersistence.aguaOvelha + " L";
        qtdAguaPorco.text = dataPersistence.aguaPorco + " L";
        qtdAguaVaca.text = dataPersistence.aguaVaca + " L";
        qtdOvelhaA.text = dataPersistence.ovelhas + "";
        qtdPorcoA.text = dataPersistence.porcos + "";
        qtdVacaA.text = dataPersistence.vaca + "";
    }

    public void updateCurral()
    {
        Pontuacao.text = "Pontuação: " + dataPersistence.pontuacao;
        Pontuacao.ForceMeshUpdate();

        Moedas.text = "Moedas: " + dataPersistence.moedas;
        Moedas.ForceMeshUpdate();

        textoOvelhaQtd.text = "Quantidade: " + dataPersistence.ovelhas;
        textoPorcoQtd.text = "Quantidade: " + dataPersistence.porcos;
        textoVacaQtd.text = "Quantidade: " + dataPersistence.vaca;
        totalAnimais.text = "Total de animais no curral: " + (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca);
        capacidadeMax.text = "Capacidade máxima do curral: " + ((2 + dataPersistence.dias) - (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca)) + " animais.";
        precoOvelha.text = "Preço: " + dataPersistence.precoOvelha;
        precoPorco.text = "Preço: " + dataPersistence.precoPorco;
        precoVaca.text = "Preço: " + dataPersistence.precoVaca;
        capacidadeMaxMercado.text = "Seu curral têm capacidade para mais " + ((2 + dataPersistence.dias) - (dataPersistence.ovelhas + dataPersistence.porcos + dataPersistence.vaca)) + " animais.";
        qtdMoedasMercado.text = "Você possui " + dataPersistence.moedas + " moedas.";
        precoOvelhaCC.text = "Preço: " + dataPersistence.precoOvelha + " moedas.";
        precoVacaCC.text = "Preço: " + dataPersistence.precoVaca + " moedas.";
        precoPorcoCC.text = "Preço: " + dataPersistence.precoPorco + " moedas.";
        qtdMoedasOvelhaCC.text = "Quantidade: " + dataPersistence.moedas;
        qdtMoedasVacaCC.text = "Quantidade: " + dataPersistence.moedas;
        qtdMoedasPorcoCC.text = "Quantidade: " + dataPersistence.moedas;
        questionOvelhaCC.text = "Uma ovelha custa " + dataPersistence.precoOvelha + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra da ovelha?";
        questionPorcoCC.text = "Um porco custa " + dataPersistence.precoPorco + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra do porco?";
        questionVacaCC.text = "Uma vaca custa " + dataPersistence.precoVaca + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra da vaca?";
        qtdComidaOvelha.text = dataPersistence.comidaOvelha + " Kg";
        qtdComidaPorco.text = dataPersistence.comidaPorco + " Kg";
        qtdComidaVaca.text = dataPersistence.comidaVaca + " Kg";
        qtdOvelha.text = dataPersistence.ovelhas + "";
        qtdPorco.text = dataPersistence.porcos + "";
        qtdVaca.text = dataPersistence.vaca + "";
        qtdAguaOvelha.text = dataPersistence.aguaOvelha + " L";
        qtdAguaPorco.text = dataPersistence.aguaPorco + " L";
        qtdAguaVaca.text = dataPersistence.aguaVaca + " L";
        qtdOvelhaA.text = dataPersistence.ovelhas + "";
        qtdPorcoA.text = dataPersistence.porcos + "";
        qtdVacaA.text = dataPersistence.vaca + "";
    }

    int calcPreco (int basePreco)
    {
        return (basePreco + Random.Range(-20, 20));
    }

    int calcPrecoPlantas (int basePreco)
    {
        return (basePreco + Random.Range(-50, 50));
    }

    int calcComida (int baseComida)
    {
        return (baseComida + Random.Range(-5, 5));
    }

    int calcAguaa(int baseAgua)
    {
        return (baseAgua + Random.Range(-10, 10));
    }

    int calcAguaPlantacao (int baseAgua)
    {
        return (baseAgua + Random.Range(-25, 25));
    }
}
