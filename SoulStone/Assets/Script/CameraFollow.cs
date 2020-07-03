using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _target;

    void Update()
    {
        //먼저 캐릭터의 위치를 가져온다.
        Vector3 charPos = _target.position;
        //카메라의 위치를 가져온 캐릭터의 위치로 세팅해준다. (z값은 제외)
        float camZ = transform.position.z;
        transform.position = new Vector3(charPos.x, charPos.y, camZ);
    }
}
