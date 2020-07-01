using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My2DUserControl : MonoBehaviour
{
    public Rigidbody _rigid;
    public float _moveForce = 10.0f;
    public float _moveMax = 3.0f;
    public MyCharacter2D _myChar2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid.AddForce(new Vector3(-1 * _moveForce, 0.0f, 0.0f));
            /*_myChar2D.Flip(false);*/
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigid.AddForce(new Vector3(_moveForce, 0.0f, 0.0f));
            /*_myChar2D.Flip(true);*/
        }

        if (Input.GetKey(KeyCode.DownArrow))
            _rigid.AddForce(new Vector3(0.0f, 0.0f, -1 * _moveForce));

        if (Input.GetKey(KeyCode.UpArrow))
            _rigid.AddForce(new Vector3(0.0f, 0.0f, _moveForce));

        Vector3 velX = _rigid.velocity;
        float limitX = Mathf.Min(_moveMax, velX.x); // x축으로의 속도가 3을 넘지 않게한다.

        limitX = Mathf.Max(-1 * _moveMax, limitX); // x축으로의 속도가 -3보다 낮지 않게한다. -3 < limit < 3 이된다
        _rigid.velocity = new Vector3(limitX, 0.0f, velX.z);

        Vector3 velZ = _rigid.velocity;
        float limitZ = Mathf.Min(_moveMax, velZ.z);

        limitZ = Mathf.Max(-1 * _moveMax, limitZ);
        _rigid.velocity = new Vector3(velZ.x, 0.0f, limitZ);

    }
}
