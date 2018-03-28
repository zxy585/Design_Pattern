//实现Colleague的类1
public class ConcreateColleague1 : Colleague
{
    public ConcreateColleague1(Mediator theMediator) : base(theMediator)
    { }

    //执行动作
    public void Action()
    {
        //执行后需要通知其他Colleague
        m_Mediator.SendMessage(this, "Colleage1发出通知");
    }

    //Mediator通知请求
    public override void Request(string Message)
    {
        UnityEngine.Debug.Log("ConcreateColleague1.Request:" + Message);
    }
}
