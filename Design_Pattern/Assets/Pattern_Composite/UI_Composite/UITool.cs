using UnityEngine;

/// <summary>
/// UI工具
/// </summary>
public static class UITool
{
    /// <summary>
    /// 场景上的2D画布对象
    /// </summary>
    private static GameObject m_CanvasObj = null;

    /// <summary>
    /// 寻找限定在Canvas画布下的UI界面
    /// </summary>
    public static GameObject FindUIGameObject(string UIName)
    {
        if (m_CanvasObj == null)
            m_CanvasObj = UnityTool.FindGameObject("Canvas");
        if (m_CanvasObj == null)
            return null;
        return UnityTool.FindChildGameObject(m_CanvasObj, UIName);
    }

    /// <summary>
    /// 获取子对象
    /// </summary>
    public static T GetUIComponent<T>(GameObject Container, string UIName) where T : UnityEngine.Component
    {
        //找出子对象
        GameObject ChildGameObject = UnityTool.FindChildGameObject(Container, UIName);
        if (ChildGameObject == null)
            return null;

        T tempObj = ChildGameObject.GetComponent<T>();
        if (tempObj == null)
        {
            Debug.LogWarning("组件[" + UIName + "]不是[" + typeof(T) + "]");
            return null;
        }
        return tempObj;
    }
}
