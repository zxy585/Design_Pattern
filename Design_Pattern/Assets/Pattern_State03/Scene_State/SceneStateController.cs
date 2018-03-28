using UnityEngine;
using System.Collections;

/// <summary>
/// 场景状态控制器
/// </summary>
public class SceneStateController
{

    /// <summary>
    /// 场景状态
    /// </summary>
    private ISceneState m_State;


    private bool m_bRunBegin = false;

    /// <summary>
    /// 构造函数
    /// </summary>
    public SceneStateController()
    {

    }

    /// <summary>
    /// 设置状态
    /// </summary>
    /// <param name="State">状态接口</param>
    /// <param name="LoadSceneName">场景名称</param>
    public void SetState(ISceneState State, string LoadSceneName)
    {
        Debug.Log("SetState:" + State.ToString());
        m_bRunBegin = false;

        //载入场景
        LoadScene(LoadSceneName);

        //通知前一个场景结束
        if (m_State != null)
        {
            m_State.StateEnd();
        }

        //设置当前场景
        m_State = State;
    }

    /// <summary>
    /// 加载场景
    /// </summary>
    /// <param name="LoadSceneName">场景名称</param>
    private void LoadScene(string LoadSceneName)
    {
        if (LoadSceneName == null || LoadSceneName.Length == 0)
        {
            return;
        }
        Application.LoadLevel(LoadSceneName);
    }

    /// <summary>
    /// 状态更新
    /// </summary>
    public void StateUpdate()
    {
        //是否还在载入
        if (Application.isLoadingLevel)
            return;

        // 通知新的State開始
        if (m_State != null && m_bRunBegin == false)
        {
            m_State.StateBegin();
            m_bRunBegin = true;
        }

        if (m_State != null)
        {
            //调用状态的状态更新
            m_State.StateUpdate();
        }
    }
}
