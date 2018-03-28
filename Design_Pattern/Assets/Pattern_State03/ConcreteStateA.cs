using UnityEngine;


/// <summary>
/// 具体状态A
/// </summary>
public class ConcreteStateA : State
{

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="theContext">状态拥有者</param>
    public ConcreteStateA(Context theContext) : base(theContext)
    {

    }

    /// <summary>
    /// Handle
    /// </summary>
    /// <param name="Value">参数值</param>
    public override void Handle(int Value)
    {
        Debug.Log("ConcreteStateA.Handle");
        //根据条件切换到状态B
        if (Value > 10)
        {
            m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}
