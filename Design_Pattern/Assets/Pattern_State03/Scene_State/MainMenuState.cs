using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 主菜单状态
/// </summary>
public class MainMenuState : ISceneState
{

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="Controller">场景状态控制器</param>
    public MainMenuState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "MainMenuState";
    }

    /// <summary>
    /// 状态开始
    /// </summary>
    public override void StateBegin()
    {
        //获取开始按钮
        //Button tmpBtn = UITool.GetUIComponent<Button>("StartGameBtn");
        //if (tmpBtn != null)
        //{
        //    tmpBtn.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn));
        //}
    }

    /// <summary>
    /// 开始战斗
    /// </summary>
    /// <param name="theButton">按钮</param>
    private void OnStartGameBtnClick(Button theButton)
    {
        Debug.Log("OnStartBtnClick:" + theButton.gameObject.name);
        m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
    }

}
