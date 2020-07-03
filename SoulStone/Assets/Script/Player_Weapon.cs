using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon : MonoBehaviour
{
    public GameObject _effectPrefab;
    public int _attack = 30; // 공격력

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            Monster monster = FindObjectOfType<Monster>();
            monster.OnDamage(_attack);

            /*// 이펙트 효과
            GameObject effectfab = Instantiate(_effectPrefab); // instantiate = 복사
            Vector3 charPos = monster.transform.position;
            effectfab.transform.position = new Vector3(charPos.x, charPos.y, charPos.z);*/
        }
    }
}
