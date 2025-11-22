using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    Vector3 pos;
    public float positionOffset = 3f;
    public Vector3 modelOffset;
    [SerializeField] private Animator slapAnim;
    
    [SerializeField] private string slapAnimStr = "slapAnim";

    void Strart()
    {
        
    }
    void Update()
    {
       // if (mAnimator != null)
        //{
            
            if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            slapAnim.Play(slapAnimStr, 0 , 0.0f);
        }
        /*
            {
                
                
            }*/

        //}

        pos = Input.mousePosition;
        pos.z = positionOffset;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = worldPos + modelOffset;
    }
}
