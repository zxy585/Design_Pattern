using System.Collections.Generic;

/// <summary>
/// 代表组合结构的元节点之行为
/// </summary>
public class Composite : IComponent
{

    List<IComponent> m_Childs = new List<IComponent>();

    public Composite(string Value)
    {
        m_Value = Value;
    }

    /// <summary>
    /// 一般操作
    /// </summary>
    public override void Operation()
    {
        UnityEngine.Debug.Log("Composite[" + m_Value + "]");
        foreach (IComponent theComponent in m_Childs)
        {
            theComponent.Operation();
        }
    }

    /// <summary>
    /// 加入节点
    /// </summary>
    public override void Add(IComponent theComponent)
    {
        m_Childs.Add(theComponent);
    }

    /// <summary>
    /// 删除节点
    /// </summary>
    public override void Remove(IComponent theComponent)
    {
        m_Childs.Remove(theComponent);
    }

    /// <summary>
    /// 获取子节点
    /// </summary>
    public override IComponent GetChild(int Index)
    {
        return m_Childs[Index];
    }
}