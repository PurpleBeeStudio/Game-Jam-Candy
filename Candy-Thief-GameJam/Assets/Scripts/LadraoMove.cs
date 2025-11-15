using UnityEngine;

public class LadraoMove : MonoBehaviour
{
    [Header("Pontos de Spawn")]
    public Transform[] pontos;

    private int ultimoIndex = -1;

    [Header("Timer para troca de posições automática")]
    public float tempoTroca = 3f;
    private float timer;

    private Camera _mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _mainCamera = Camera.main;
        timer = tempoTroca;

        MoverParaPontoAleatorio();
    }

    // Update is called once per frame
    void Update()
    {
        //Contagem Timer
        timer -= Time.deltaTime;
        
        if (timer <= 0f)
        {
            MoverParaPontoAleatorio();
            timer = tempoTroca;
        }
        //Detectar clique
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    Debug.Log("Ladrão clicado!");

                    //Move o ladrão
                    MoverParaPontoAleatorio();

                    //Resetar o timer
                    timer = tempoTroca;
                }    
            } 
        }
    }

    private void MoverParaPontoAleatorio()
    {
        if (pontos.Length == 0)
        {
            Debug.LogWarning("Nenhum ponto foi configurado!");
        }

        int novoIndex;

        //Garante que não repita o ponto que já esteja
        do
        {
          novoIndex = Random.Range(0,pontos.Length);   
        }
        while (novoIndex == ultimoIndex);

        ultimoIndex = novoIndex;
        
        transform.position = pontos[novoIndex].position;
        Debug.Log("O Ladrão se moveu para o ponto: " + pontos[novoIndex].name);
    }
}
