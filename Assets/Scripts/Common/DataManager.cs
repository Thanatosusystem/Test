using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //インスタンス変数
    public static DataManager instance;

    private void Awake()
    {
        instance = this;
    }


}
