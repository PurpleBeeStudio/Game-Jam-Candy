using UnityEngine;
using UnityEngine.InputSystem;
public class LadraoMove : MonoBehaviour
{
    [Header("Pontos de Spawn")]
    public Transform[] pontos;

    private int ultimoIndex = -1;

    [Header("Timer para troca de posições automática")]
    public float tempoTroca = 3f;
    private float timer;

    private Camera _mainCamera;
    private LadraoControls controls;


    private void Awake()
    {
        //Instancia as ações
        controls = new LadraoControls();

        controls.Gameplay.Click.performed += ctx => OnClick();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void Osable()
    {
        controls.Disable();       
    }
    
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

            //Avisa "LadraoVence" que o ladrão escapou
            FindObjectOfType<LadraoVence>().RegistrarFuga();
        }
       
    }
    private void OnClick()
    {
        //Posição do mouse
        Vector2 mousePos = Mouse.current.position.ReadValue();

        //Raycast
        Ray ray = _mainCamera.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform == transform)
            {
                Debug.Log("Clicou no ladrão!");

                //Atualiza contador de tapas
                FindObjectOfType<cliquesVitoria>().RegistrarClique();

                MoverParaPontoAleatorio();
                timer =tempoTroca;
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
