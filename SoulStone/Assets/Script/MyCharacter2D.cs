using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacter2D : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _maxForce = 0.0f;
    public Animator _ani;

    public int _hp = 0;
    public int _maxHp = 300;
    // Start is called before the first frame update
    void Start()
    {
        _hp = _maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        // run애니메이션
        if (Mathf.Abs(_rigid.velocity.x)>0 || Mathf.Abs(_rigid.velocity.y)>0)
            _ani.SetBool("velocity", true);
         else
            _ani.SetBool("velocity", false);
    }

    //방향전환 함수
        public void Flip(bool right)
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

        }
}
