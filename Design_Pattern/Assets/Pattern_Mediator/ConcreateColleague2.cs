//实现Colleague的类2
public class ConcreateColleague2 : Colleague
{
    public ConcreateColleague2(Mediator theMediator) : base(theMediator)
    { }

    // 執行動作
    public void Action()
    {
        //执行后需要通知其他Colleague
        m_Mediator.SendMessage(this, "Colleage2发出通知");
    }

    //Mediator通知请求
    public override void Request(string Message)
    {
        UnityEngine.Debug.Log("ConcreateColleague2.Request:" + Message);
    }
}