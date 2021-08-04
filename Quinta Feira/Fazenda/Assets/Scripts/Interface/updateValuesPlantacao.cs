using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateValuesPlantacao : MonoBehaviour
{

    // Tela PLANTAÇÃO
    public Text qtdPlantasTrigo;
    public Text qtdPlantasGirassol;
    public Text qtdPlantasMilho;
    public Text tipoPlantacaoAtual;

    // Mercado Sementes
    public Text precoTrigo;
    public Text precoGirassol;
    public Text precoMilho;
    public Text qtdMoedas;

    // Comprar Tigro
    public Text precoTrigoConfirma;
    public Text qtdMoedasConfirmaT;
    public Text questaoTrigo;

    // Comprar Girassol
    public Text precoGirassolConfirma;
    public Text qtdMoedasConfirmaG;
    public Text questaoGirassol;

    // Comprar Milho
    public Text precoMilhoConfirma;
    public Text qtdMoedasConfirmaM;
    public Text questaoMilho;

    // Hidratar Plantas
    public Text qtdAguaTrigo;
    public Text qtdAguaGirassol;
    public Text qtdAguaMilho;
    public Text qtdPlantaTrigo;
    public Text qtdPlantaGirassol;
    public Text qtdPlantaMilho;

    public TextMeshProUGUI Pontuacao;
    public TextMeshProUGUI Moedas;

    // Use this for initialization
    void Start()
    {

        // Tela PLANTAÇÃO
        qtdPlantasTrigo.text = "Quantidade: " + dataPersistence.qtdTrigo;
        qtdPlantasGirassol.text = "Quantidade: " + dataPersistence.qtdGirassol;
        qtdPlantasMilho.text = "Quantidade: " + dataPersistence.qtdMilho;

        if (dataPersistence.tipoPlantacao == 0)
        {
            tipoPlantacaoAtual.text = "Nenhuma plantação ativa.";
        }
        else if (dataPersistence.tipoPlantacao == 1)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Trigos.";
        }
        else if (dataPersistence.tipoPlantacao == 2)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Girassóis.";
        }
        else if (dataPersistence.tipoPlantacao == 3)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Milhos.";
        }

        dataPersistence.precoTrigo = calcPrecoPlantas(200);
        dataPersistence.precoGirassol = calcPrecoPlantas(300);
        dataPersistence.precoMilho = calcPrecoPlantas(250);

        // Mercado Sementes
        precoTrigo.text = "Preço: " + dataPersistence.precoTrigo;
        precoGirassol.text = "Preço: " + dataPersistence.precoGirassol;
        precoMilho.text = "Preço: " + dataPersistence.precoMilho;
        qtdMoedas.text = "Você possui " + dataPersistence.moedas + " moedas.";

        // Comprar Tigro
        precoTrigoConfirma.text = "Preço: " + dataPersistence.precoTrigo;
        qtdMoedasConfirmaT.text = "Quantidade: " + dataPersistence.moedas;
        questaoTrigo.text = "Sementes de trigo custam " + dataPersistence.precoTrigo + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        // Comprar Girassol
        precoGirassolConfirma.text = "Preço: " + dataPersistence.precoGirassol;
        qtdMoedasConfirmaG.text = "Quantidade: " + dataPersistence.moedas;
        questaoGirassol.text = "Sementes de girassol custam " + dataPersistence.precoGirassol + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        // Comprar Milho
        precoMilhoConfirma.text = "Preço: " + dataPersistence.precoMilho;
        qtdMoedasConfirmaM.text = "Quantidade: " + dataPersistence.moedas;
        questaoMilho.text = "Sementes de milho custam " + dataPersistence.precoMilho + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        dataPersistence.aguaTrigo = calcAguaPlantacao(45);
        dataPersistence.aguaGirassol = calcAguaPlantacao(65);
        dataPersistence.aguaMilho = calcAguaPlantacao(55);

        // Hidratar Plantas
        qtdAguaTrigo.text = dataPersistence.aguaTrigo + " L";
        qtdAguaGirassol.text = dataPersistence.aguaGirassol + " L";
        qtdAguaMilho.text = dataPersistence.aguaMilho + " L";
        qtdPlantaTrigo.text = dataPersistence.qtdTrigo + "";
        qtdPlantaGirassol.text = dataPersistence.qtdGirassol + "";
        qtdPlantaMilho.text = dataPersistence.qtdMilho + "";

    }

    public void updatePlantacao()
    {
        // Tela PLANTAÇÃO
        qtdPlantasTrigo.text = "Quantidade: " + dataPersistence.qtdTrigo;
        qtdPlantasGirassol.text = "Quantidade: " + dataPersistence.qtdGirassol;
        qtdPlantasMilho.text = "Quantidade: " + dataPersistence.qtdMilho;

        if (dataPersistence.tipoPlantacao == 0)
        {
            tipoPlantacaoAtual.text = "Nenhuma plantação ativa.";
        }
        else if (dataPersistence.tipoPlantacao == 1)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Trigos.";
        }
        else if (dataPersistence.tipoPlantacao == 2)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Girassóis.";
        }
        else if (dataPersistence.tipoPlantacao == 3)
        {
            tipoPlantacaoAtual.text = "Tipo de plantação atual: Milhos.";
        }

        // Mercado Sementes
        precoTrigo.text = "Preço: " + dataPersistence.precoTrigo;
        precoGirassol.text = "Preço: " + dataPersistence.precoGirassol;
        precoMilho.text = "Preço: " + dataPersistence.precoMilho;
        qtdMoedas.text = "Você possui " + dataPersistence.moedas + " moedas.";

        // Comprar Tigro
        precoTrigoConfirma.text = "Preço: " + dataPersistence.precoTrigo;
        qtdMoedasConfirmaT.text = "Quantidade: " + dataPersistence.moedas;
        questaoTrigo.text = "Sementes de trigo custam " + dataPersistence.precoTrigo + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        // Comprar Girassol
        precoGirassolConfirma.text = "Preço: " + dataPersistence.precoGirassol;
        qtdMoedasConfirmaG.text = "Quantidade: " + dataPersistence.moedas;
        questaoGirassol.text = "Sementes de girassol custam " + dataPersistence.precoGirassol + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        // Comprar Milho
        precoMilhoConfirma.text = "Preço: " + dataPersistence.precoMilho;
        qtdMoedasConfirmaM.text = "Quantidade: " + dataPersistence.moedas;
        questaoMilho.text = "Sementes de milho custam " + dataPersistence.precoMilho + " moedas e você têm " + dataPersistence.moedas + " moedas. Quantas moedas irão sobrar após a compra das sementes?";

        // Hidratar Plantas
        qtdAguaTrigo.text = dataPersistence.aguaTrigo + " L";
        qtdAguaGirassol.text = dataPersistence.aguaGirassol + " L";
        qtdAguaMilho.text = dataPersistence.aguaMilho + " L";
        qtdPlantaTrigo.text = dataPersistence.qtdTrigo + "";
        qtdPlantaGirassol.text = dataPersistence.qtdGirassol + "";
        qtdPlantaMilho.text = dataPersistence.qtdMilho + "";

        Pontuacao.text = "Pontuação: " + dataPersistence.pontuacao;
        Pontuacao.ForceMeshUpdate();

        Moedas.text = "Moedas: " + dataPersistence.moedas;
        Moedas.ForceMeshUpdate();

    }

    int calcPreco(int basePreco)
    {
        return (basePreco + Random.Range(-20, 20));
    }

    int calcPrecoPlantas(int basePreco)
    {
        return (basePreco + Random.Range(-50, 50));
    }

    int calcComida(int baseComida)
    {
        return (baseComida + Random.Range(-5, 5));
    }

    int calcAguaa(int baseAgua)
    {
        return (baseAgua + Random.Range(-10, 10));
    }

    int calcAguaPlantacao(int baseAgua)
    {
        return (baseAgua + Random.Range(-25, 25));
    }
}
