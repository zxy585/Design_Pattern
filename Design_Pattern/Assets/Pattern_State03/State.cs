/// <summary>
/// 状态接口类
/// </summary>
public abstract class State
{

    /// <summary>
    /// 关联的状态拥有者
    /// </summary>
    protected Context m_Context = null;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="theContext">状态拥有者</param>
    public State(Context theContext)
    {
        m_Context = theContext;
    }

    /// <summary>
    /// Handle抽象方法
    /// </summary>
    /// <param name="Value">参数值</param>
    public abstract void Handle(int Value);
}
