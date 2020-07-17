using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{

    public GameObject _player;
    public MyCharacter2D _myChar2D;
    Monster _monster;

    // Start is called before the first frame update
    void Start()
    {
        _monster = FindObjectOfType<Monster>();
    }

    public void GoMap (int mapNum) 
    {
        
    }
}
