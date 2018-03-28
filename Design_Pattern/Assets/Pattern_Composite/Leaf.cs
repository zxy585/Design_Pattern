/// <summary>
/// 代表组合结构之终端对象
/// </summary>
public class Leaf : IComponent
{
    public Leaf(string Value)
    {
        m_Value = Value;
    }

    /// <summary>
    /// 一般操作
    /// </summary>
    public override void Operation()
    {
        UnityEngine.Debug.Log("Leaf[" + m_Value + "]执行Operation()");
    }
}