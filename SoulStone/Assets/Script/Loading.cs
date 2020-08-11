using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject _loadingUI;
    public Slider slider;
    float value = 0.0f;
    public UI _ui;

    void Update()
    {
        if (value<1)
        {
            value += Time.deltaTime; // 매 프레임마다 밸류값 올리기  - 0.005f
            slider.value = value;
        }
        else
        {
            _ui.Show("playUI", true); // 로딩바가 다 채워지면 playUI 호출
            value = 0.0f;
        }
    }
}
