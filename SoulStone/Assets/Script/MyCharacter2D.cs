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

    public int _hp;
    public int _maxHp = 300;
    public Player_Weapon _weapon;

    void Start()
    {
        _hp = _maxHp;
        _ani = GetComponent<Animator>();
        _weapon.gameObject.SetActive(false); // 시작할때 weapon off
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

        if (_hp==0)
            _ui.Hpbar(false, false, false);
        else if (_hp<=100)
            _ui.Hpbar(true, false, false);
        else if (_hp<=200)
            _ui.Hpbar(true, true, false);
        else if (_hp<=300)
            _ui.Hpbar(true, true, true);

        if (_hp == 0)
        {
            // 게임오버 처리
            _ui.Show("gameoverUI",true);
            
            // 조작 금지로 바꾸기 및 죽은 후 카메라가 이동하는 버그 수정
            My2DUserControl control = GetComponent<My2DUserControl>();
            control._moveForceX = 0.0f;
            control._moveForceY = 0.0f;
            control.enabled = false;
        }
    }

    // 캐릭터 부활하기
    public void Respawn() 
    {
        _hp = _maxHp; // 부활 후 피 회복
        _ani.SetInteger("hp", _maxHp);
        _ui.Hpbar(true, true, true);
    }

    // 공격하기
    public void Attack() 
    {
        _ani.SetBool("attack", true);
    }
}
