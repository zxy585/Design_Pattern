using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 战斗状态
/// </summary>
public class BattleState : ISceneState
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="Controller">场景状态控制器</param>
    public BattleState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "BattleState";
    }

    /// <summary>
    /// 状态开始
    /// </summary>
    public override void StateBegin()
    {
        //初始化
        PBaseDefenseGame.Instance.Initinal();
    }

    /// <summary>
    /// 状态更新
    /// </summary>
    public override void StateUpdate()
    {
        //游戏逻辑
        PBaseDefenseGame.Instance.Update();

        //游戏是否结束
        if (PBaseDefenseGame.Instance.ThisGameIsOver())
        {
            m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
        }
    }

    /// <summary>
    /// 状态结束
    /// </summary>
    public override void StateEnd()
    {
        //释放
        PBaseDefenseGame.Instance.Release();
    }


}
