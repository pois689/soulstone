using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ClearZone : MonoBehaviour
{
    public GameObject _startPos;

    void Start()
    {
    }

    // 클리어존에 도착하면 발생하는 함수
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
                Vector3 pos = _startPos.transform.position;

                collision.transform.position = new Vector3(pos.x, pos.y, pos.z);
        }
    }
}