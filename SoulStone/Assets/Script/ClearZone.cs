using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearZone : MonoBehaviour
{
    // 스테이지존에 도착하면 발생하는 함수
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="player")
        {
            Debug.Log("클리어존");
            // 스테이지 클리어
            /*UI uimgr = FindObjectOfType<UI>();
            uimgr.Show("ui_Loading", true); // ui_Loading 띄우기

            UI_Lodiong ui_Loading = FindObjectOfType<UI_Lodiong>();
            ui_Loading.GoNext(_stageNum);*/
        }
    }
}