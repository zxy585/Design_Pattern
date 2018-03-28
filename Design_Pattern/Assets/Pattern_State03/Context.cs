


/// <summary>
/// 状态拥有者
/// </summary>
public class Context
{

    /// <summary>
    /// 拥有的状态
    /// </summary>
    private State m_State = null;

    /// <summary>
    /// Request
    /// </summary>
    /// <param name="Value">参数值</param>
    public void Request(int Value)
    {
        m_State.Handle(Value);
    }

    /// <summary>
    /// 设置状态
    /// </summary>
    /// <param name="theState">状态</param>
    public void SetState(State theState)
    {
        UnityEngine.Debug.Log("Context.SetState:" + theState);
        m_State = theState;
    }
}
