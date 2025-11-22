using UnityEngine;
using UnityEngine.UI;

public class cliquesVitoria : MonoBehaviour
{
    [Header("Configuração da Fase: Tapas")]
    public int cliquesNecessarios = 5; //nº de cliques para terminar a fase; configurável

    [Header("UI")]
    public Text textoCliques;

    private int cliquesAtuais = 0;

    //método que é chamado toda vez que o ladrão for clicado
    public void RegistrarClique()
    {
        cliquesAtuais++;

        //atualiza os cliques na tela
        textoCliques.text = $"Cliques: {cliquesAtuais}/{cliquesNecessarios}";

        //verifica se a fase foi concluída
        if (cliquesAtuais >= cliquesNecessarios)
        {
            faseConcluida();
        }
    }
    private void faseConcluida()
    {
        Debug.Log("Fase Concluída!");
        textoCliques.text = "Fase concluída!";
        //NOTA: fazer transição de fase depois
    }
}
