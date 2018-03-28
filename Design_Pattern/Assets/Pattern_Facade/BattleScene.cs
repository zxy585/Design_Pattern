/// <summary>
/// 战斗场景
/// </summary>
public class BattleScene : ISceneState
{

    /// <summary>
    /// 开始
    /// </summary>
    public override void StateBegin()
    {
        PBaseDefenseGame.Instance.Initinal();
    }

    /// <summary>
    /// 更新
    /// </summary>
    public override void StateUpdate()
    {
        //游戏逻辑
        PBaseDefenseGame.Instance.Update();
           // ...
            //游戏是否结束
            if (PBaseDefenseGame.Instance.ThisGameIsOver())
        {
            m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
        }
    }

    /// <summary>
    /// 结束
    /// </summary>
    public override void StateEnd()
    {
        PBaseDefenseGame.Instance.Release();
    }
}
