using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearZone : MonoBehaviour
{
    public GameManager _gameMgr;
    public int _stageNum = 0;
    // 클리어존에 도착하면 발생하는 함수
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            _gameMgr.GoNext(_stageNum);
        }
    }
}