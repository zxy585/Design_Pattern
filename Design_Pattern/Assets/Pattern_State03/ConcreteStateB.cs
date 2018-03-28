
/// <summary>
/// 具体状态A
/// </summary>
public class ConcreteStateB : State
{

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="theContext"></param>
    public ConcreteStateB(Context theContext) : base(theContext)
    {

    }

    /// <summary>
    /// Handle
    /// </summary>
    /// <param name="Value">参数值</param>
    public override void Handle(int Value)
    {
        UnityEngine.Debug.Log("ConcreteStateB.Handle");
        //根据条件切换到状态C
        if (Value > 20)
        {
            m_Context.SetState(new ConcreteStateC(m_Context));
        }
    }
}
