using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject[] _uiList;
    public GameManager _gamemgr;

    // Start is called before the first frame update
    void Start()
    {
        HideAll();

        Show("startUI", true);
    }

    public void HideAll() 
    {
        GameObject ui = null;

        for (int i = 0; i < _uiList.Length; i++)
        {
            ui = _uiList[i];
            ui.SetActive(false);
        }
    }

    // UI를 보였다 숨겼다 하는 함수
    public void Show(string name, bool show) 
    {
        HideAll(); // 숨기고 시작

        GameObject ui = null;

        for (int i = 0; i < _uiList.Length; i++)
        {
            ui = _uiList[i];

            if (ui.name == name)
            {
                ui.SetActive(show);
            }

        }
    }

    // 게임 시작 버튼 클릭시 발생하는 함수
    public void OnGameStart() 
    {
        Show("loadingUI", true);
    }

    // 게임 종료 버튼 클릭시 발생하는 함수 (메인메뉴에서만 가능)
    public void OnExit()
    {
        Debug.Log("게임종료");
    }

    // 나가기 버튼 클릭시 발생하는 함수
    public void OnMenu() 
    {
        SceneManager.LoadScene(0);
    }

    // 플레이 중 옵션 버튼 클릭시 발생하는 함수
    public void PlaySetting() 
    {
        Show("playsettingUI", true);
    }

    // 게임오버 UI에서 다시하기 클릭시 발생하는 함수
    public void Retry() 
    {
        _gamemgr.Respawn();
        Show("playUI", true);

    }
}
