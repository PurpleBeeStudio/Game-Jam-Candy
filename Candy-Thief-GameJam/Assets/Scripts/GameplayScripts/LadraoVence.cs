using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LadraoVence : MonoBehaviour
{
    [Header("Configuração da Fase: Doces")]
    public int docesMax = 3; //n� de "vidas"; obviamente n�o configurar como zero ou abaixo
    public int docesAtual;
    [Header("UI")]
    public Text textoDoces;
    public AudioSource audioSourceLaugh;
    public AudioSource audioSourceCry;


    private void Start()
    {
        docesAtual = docesMax;
    }
    private void Update()
    {
        textoDoces.text = $"Candies:{docesAtual}/{docesMax}";
    }

    public void RegistrarFuga()
    {
        docesAtual--;
        Debug.Log("O Ladrão escapou!");
        textoDoces.text = $"Candies:{docesAtual}/{docesMax}";
        if(audioSourceLaugh !=null && audioSourceLaugh.clip != null)
                    {
                        AudioSource.PlayClipAtPoint(audioSourceLaugh.clip, transform.position);
                    }
        if(audioSourceCry !=null && audioSourceCry.clip != null)
        {
            AudioSource.PlayClipAtPoint(audioSourceCry.clip, transform.position );
        }

        if (docesAtual <= 0)
        {
            Derrota();
        }
    }

    private void Derrota()
    {
        Debug.Log("Você perdeu!");
        SceneManager.LoadScene("LoseMenu");
    }
}
