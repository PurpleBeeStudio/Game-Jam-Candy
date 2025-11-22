using UnityEngine;
using UnityEngine.UI;

public class LadraoVence : MonoBehaviour
{
    [Header("Configuração da Fase: Doces")]
    public int doces = 3; //nº de "vidas"; obviamente não configurar como zero ou abaixo

    [Header("UI")]
    public Text textoDoces;

    public void RegistrarFuga()
    {
        doces--;
        Debug.Log("O Ladrão escapou!");

        if (doces <= 0)
        {
            Derrota();
        }
    }

    private void Derrota()
    {
        Debug.Log("Você perdeu…");
        textoDoces.text = "Derrota!";
        //NOTA: fazer transição de tela depois
    }
}
