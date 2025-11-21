using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    Vector3 pos;
    public float positionOffset = 3f;
    public Vector3 modelOffset;
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = positionOffset;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = worldPos + modelOffset;
    }
}
