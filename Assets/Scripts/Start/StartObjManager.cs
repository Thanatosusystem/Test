using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObjManager : MonoBehaviour
{
    //インスタンス変数
    public static StartObjManager instance;



    private void Awake()
    {
        instance = this;
    }

}


