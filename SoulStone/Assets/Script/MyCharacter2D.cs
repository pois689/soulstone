using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacter2D : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _maxForce = 0.0f;
    protected Animator _ani;
    public UI _ui;

    public int _hp = 0;
    public int _maxHp = 300;

    void Start()
    {
        _hp = _maxHp;
        _ani = GetComponent<Animator>();
    }

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

    // 피격당했을때
    public void OnDamage(int damage)
    {
        _hp -= damage;
        _hp = Math.Max(0, _hp); // Hp가 0이하로 내려가는 것을 방지
        _ani.SetBool("hit", true);
        _ani.SetInteger("hp", _hp);

        if (_hp == 0)
        {
            // 게임오버 처리
            _ui.Show("gameoverUI", true);

        }
    }

}
