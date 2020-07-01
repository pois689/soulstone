using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacter2D : MonoBehaviour
{
    public Rigidbody _rigid;
    public float _jumpForce = 350.0f;
    public float _maxForce = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //방향전환 함수
/*    public void Flip(bool right)
    {
        if (right) // 오른쪽을 본다면
        {
            Vector3 scale = transform.localScale;
            float newScaleX = Mathf.Abs(scale.x); // Abs = 절대값 함수, 양수가 되게 한다.
            transform.localScale = new Vector3(newScaleX, scale.y, scale.z);
        }
        else // 왼쪽을 본다면
        {
            Vector3 scale = transform.localScale;
            float newScaleX = Mathf.Abs(scale.x);
            transform.localScale = new Vector3(-1 * newScaleX, scale.y, scale.z);
        }

    }*/
}
