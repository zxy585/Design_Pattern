using UnityEngine;
using System.Collections;

/// <summary>
/// 场景状态接口
/// </summary>
public class ISceneState
{
    /// <summary>
    /// 状态名称
    /// </summary>
    private string m_StateName = "ISceneState";

    /// <summary>
    /// 场景状态控制器
    /// </summary>
    protected SceneStateController m_Controller = null;

    /// <summary>
    /// 状态名称
    /// </summary>
    public string StateName
    {
        get
        {
            return m_StateName;
        }
        set
        {
            m_StateName = value;
        }
    }

    public ISceneState()
    {

    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="Controller">场景状态控制器</param>
    public ISceneState(SceneStateController Controller)
    {
        m_Controller = Controller;
    }

    /// <summary>
    /// 状态开始
    /// </summary>
    public virtual void StateBegin()
    {

    }

    /// <summary>
    /// 状态更新
    /// </summary>
    public virtual void StateUpdate()
    {

    }

    /// <summary>
    /// 状态结束
    /// </summary>
    public virtual void StateEnd()
    {

    }

    public override string ToString()
    {
        return string.Format("[I_SceneState: StateName = {0}]", StateName);
    }


}
