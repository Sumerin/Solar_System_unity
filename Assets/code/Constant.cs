using UnityEngine;
using System.Collections;

public class Constant : MonoBehaviour {

    private static Constant _instance;
    public static Constant instance
    {
        get
        {
            if(_instance==null)
            {
                GameObject t = new GameObject("Physics_value");
                t.AddComponent<Constant>();
            }
            return _instance;
        }
    }

	private  float _G=6.674F;
    public float G
    {
        get
        {
            return _G;
        }
    }


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _instance = this;
    }

}
