using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 开始状态
/// </summary>
public class StartState : ISceneState
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="Controller">场景状态控制器</param>
    public StartState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "StartState";
    }

    /// <summary>
    /// 状态开始
    /// </summary>
    public override void StateBegin()
    {
        //可在此进行游戏数据加载和初始化等
    }

    /// <summary>
    /// 状态更新
    /// </summary>
    public override void StateUpdate()
    {
        //更换为主目录状态
        m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
    }

}
