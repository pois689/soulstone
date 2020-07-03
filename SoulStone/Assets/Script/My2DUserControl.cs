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
        _moveForceX = Input.GetAxisRaw("Horizontal");
        _moveForceY = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        Debug.Log(_moveForceX);
        Debug.Log(_moveForceY);

        _rigid.velocity = new Vector2(_moveForceX, _moveForceY);
    }

}
