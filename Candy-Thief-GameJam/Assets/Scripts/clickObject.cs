using UnityEngine;

public class clickObject : MonoBehaviour
{
    private Camera _mainCamera;
    private Renderer _renderer;

    private Ray _ray;
    private RaycastHit _rayHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _mainCamera = Camera.main;
        _renderer = GetComponent<Renderer>();
       Cursor.visible = false;

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out _rayHit, 1000f))
            {
                if (_rayHit.transform == transform)
                {
                    Debug.Log("Click!");
                    _renderer.material.color =
                        _renderer.material.color == Color.red ? Color.blue : Color.red;
                }
            }
        }
    }
}
