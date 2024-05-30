using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;

    public static GameManager instance { get { init(); return Instance; } } // 외부에서 사용하기 위해서

    private Player player;

    public Player Player
    {
        get { return player; }
        set { player = value; }
    }


    private void Awake()
    {
        init();
    }

    static void init()
    {
        if (Instance == null) // 매니저 객체가 없다면
        {
            //초기화
            GameObject gameObject = GameObject.Find("@Managers");
            if (gameObject == null)
            {
                gameObject = new GameObject
                {
                    name = "@Managers"
                };
                gameObject.AddComponent<GameManager>();
            }

            DontDestroyOnLoad(gameObject);
            Instance = gameObject.GetComponent<GameManager>();

        }

    }
}
