using UnityEngine;

/// <summary>
/// 组合体内含对象之界面
/// </summary>
public abstract class IComponent
{

    protected string m_Value;

    /// <summary>
    /// 一般操作
    /// </summary>
    public abstract void Operation();

    /// <summary>
    /// 加入节点
    /// </summary>
    public virtual void Add(IComponent theComponent)
    {
        Debug.LogWarning("子类没实现");
    }

    /// <summary>
    /// 删除节点
    /// </summary>
    public virtual void Remove(IComponent theComponent)
    {
        Debug.LogWarning("子类没实现");
    }

    /// <summary>
    /// 获取子节点
    /// </summary>
    public virtual IComponent GetChild(int Index)
    {
        Debug.LogWarning("子类没实现");
        return null;
    }
}