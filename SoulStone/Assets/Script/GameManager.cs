using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{

    public GameObject[] _startPointList;
    public int[] _mapNum;
    public GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoNext(int stageNum) 
    {
        Debug.Log("스테이지 넘버" + stageNum);
        GameObject startPoint = _startPointList[stageNum]; // 스테이지 넘버를 넣어준다

        Vector3 pos = startPoint.transform.position;

        _player.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
