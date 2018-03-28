using UnityEngine;
using System;
using System.Collections;

/// <summary>
/// 游戏主循环
/// </summary>
public class GameLoop : MonoBehaviour
{
    /// <summary>
    /// 场景状态控制器
    /// </summary>
    SceneStateController m_SceneStateController = new SceneStateController();


    void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
        UnityEngine.Random.seed = (int)DateTime.Now.Ticks;
    }

    void Start()
    {
        //设置起始场景状态
        m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
    }

    void Update()
    {
        //调用控制器的状态更新
        m_SceneStateController.StateUpdate();
    }
}
