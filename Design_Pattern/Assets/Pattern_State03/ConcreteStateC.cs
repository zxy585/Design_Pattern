/// <summary>
/// 具体状态A
/// </summary>
public class ConcreteStateC : State
{

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="theContext"></param>
    public ConcreteStateC(Context theContext) : base(theContext)
    {

    }

    /// <summary>
    /// Handle
    /// </summary>
    /// <param name="Value">参数值</param>
    public override void Handle(int Value)
    {
        UnityEngine.Debug.Log("ConcreteStateC.Handle");
        //根据条件切换到状态A
        if (Value > 30)
        {
            m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}
