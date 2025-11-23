using UnityEngine;
using UnityEngine.UI;

public class cliquesVitoria : MonoBehaviour
{
    [Header("Configura��o da Fase: Tapas")]
    public int cliquesNecessarios = 5; //n� de cliques para terminar a fase; configur�vel

    [Header("UI")]
    public Text textoCliques;

    private int cliquesAtuais = 0;


    private void Update()
    {
        textoCliques.text = $"Tapas: {cliquesAtuais}/{cliquesNecessarios}";
    }
    //m�todo que � chamado toda vez que o ladr�o for clicado
    public void RegistrarClique()
    {
        cliquesAtuais++;

        //atualiza os cliques na tela
        textoCliques.text = $"Tapas: {cliquesAtuais}/{cliquesNecessarios}";

        //verifica se a fase foi conclu�da
        if (cliquesAtuais >= cliquesNecessarios)
        {
            faseConcluida();
        }
    }
    private void faseConcluida()
    {
        Debug.Log("Fase Concluída!");
        textoCliques.text = "Fase concluída!";
        //NOTA: fazer transi��o de fase depois
    }
}
