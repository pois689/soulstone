﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{

    public GameObject[] _startPointList;
    public int[] _mapNum;
    public GameObject _player;
    private int _curStage;

    // Start is called before the first frame update
    void Start()
    {
        _curStage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoNext(int stageNum) 
    {
        GameObject startPoint = _startPointList[stageNum]; // 스테이지 넘버를 넣어준다

        Vector3 pos = startPoint.transform.position;

        _player.transform.position = new Vector3(pos.x, pos.y, pos.z);

        _curStage++;
    }

    // 다시하기 클릭시 발생하는 함수
    public void Respawn()
    {
        Debug.Log("리스폰" + _curStage);
        // 현재 스테이지의 시작포인트 가져오기
        GameObject spawnPoint = _startPointList[_curStage - 1];
        Vector3 newPos = spawnPoint.transform.position;
        Vector3 charPos = _player.transform.position; // 스타트 포인트 때문에 캐릭터의 z값이 변하는 것을 방지

        _player.transform.position = new Vector3(newPos.x, newPos.y, charPos.z);
    }
}
