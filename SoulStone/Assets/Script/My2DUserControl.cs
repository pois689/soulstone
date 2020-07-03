using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My2DUserControl : MonoBehaviour
{
    public Rigidbody2D _rigid;
    public float _moveForceX;
    public float _moveForceY;
    public MyCharacter2D _myChar2D;

    void Start()
    {

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
    }

    private void FixedUpdate()
    {
        _rigid.velocity = new Vector2(_moveForceX, _moveForceY);
    }

}
