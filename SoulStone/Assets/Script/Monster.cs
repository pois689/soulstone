using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public int _attack = 10; // 공격력
    public float _speed = 1; // 속도
    public float _desPoint; // 목적지 (오른쪽)
    public float _orgPoint; // 시작점 (현재 박쥐가 있는 위치)
    protected bool _moveCheck = false;
    public GameObject _effectPrefab;

    public int _hp = 0;
    public int _maxHp = 100;
    protected MyCharacter2D _char;
    protected Animator _ani;
    protected BoxCollider2D _boxCol;

    // Start is called before the first frame update
    void Start()
    {
        _hp = _maxHp;
        _ani = GetComponent<Animator>(); // 게임오브젝트 안에 붙어있는 컴포넌트(애니메이터)를 할당해준다.
        _boxCol = GetComponent<BoxCollider2D>();
        _char = GetComponent<MyCharacter2D>();
    }

    public virtual void OnDamage(int damage)
    {
        _hp -= damage;
        _hp = Math.Max(0, _hp); // Hp가 0이하로 내려가는 것을 방지


        if (_hp == 0)
        {
            /*_ani.SetBool("die", true);*/

            if (_boxCol != null)
            {
                _boxCol.enabled = false;
            }
            else
            {
                Debug.LogError("[Error] BoxCollider2D가 Null입니다!");
            }
        }
    }

    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            _char.OnDamage(_attack);
            GameObject effectfab = Instantiate(_effectPrefab); // instantiate = 복사
            Vector3 charPos = _char.transform.position;
            effectfab.transform.position = new Vector3(charPos.x, charPos.y, charPos.z);
        }
    }*/

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

    void Update()
    {
        Vector3 pos = transform.localPosition;
        float move = Time.deltaTime * _speed;

        if (_moveCheck)
            move = move * 1;
        else
            move = move * -1;

        if (!_ani.GetBool("die")) // 박쥐가 죽엇으면 움직이지 않게 하기
        {
            transform.Translate(new Vector3(move, 0, 0));
        }

        if (pos.x > _desPoint) // 정해진 위치까지 이동해라
        {
            _moveCheck = false;
            Flip(_moveCheck);
        }

        if (pos.x < _orgPoint) // 정해놓은 위치로 돌아와라
        {
            _moveCheck = true;
            Flip(_moveCheck);
        }
    }
}
