using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearZone : MonoBehaviour
{
    public GameManager _gameMgr;
    public int _stageNum = 0;
    // 스테이지존에 도착하면 발생하는 함수
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="player")
        {
            _gameMgr.GoNext(_stageNum);
        }
    }
}