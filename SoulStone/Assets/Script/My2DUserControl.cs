using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My2DUserControl : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _moveForceX;
    public float _moveForceY;
    protected MyCharacter2D _myChar2D;
    protected Animator _ani;

    void Start()
    {
        _myChar2D = GetComponent<MyCharacter2D>();
        _ani = GetComponent<Animator>();
    }

    void Update()
    {
        // 움직이기
        _moveForceX = Input.GetAxisRaw("Horizontal");
        _moveForceY = Input.GetAxisRaw("Vertical");

        // 방향전환
        if (_moveForceX == 1)
            _myChar2D.Flip(true);
        else if (_moveForceX == -1)
            _myChar2D.Flip(false);

        // 공격
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _ani.SetBool("attack", true);
        }
    }

    private void FixedUpdate()
    {
        _rigid.velocity = new Vector2(_moveForceX, _moveForceY);
    }

}
