//实现Mediator接口,并集合管理Colleague对象
public class ConcreteMediator : Mediator
{
    ConcreateColleague1 m_Colleague1 = null;
    ConcreateColleague2 m_Colleague2 = null;

    public void SetColleageu1(ConcreateColleague1 theColleague)
    {
        m_Colleague1 = theColleague;
    }

    public void SetColleageu2(ConcreateColleague2 theColleague)
    {
        m_Colleague2 = theColleague;
    }

    // 收到来自Colleague的通知请求
    public override void SendMessage(Colleague theColleague, string Message)
    {
        // 收到Colleague1通知Colleague2
        if (m_Colleague1 == theColleague)
            m_Colleague2.Request(Message);

        // 收到Colleague2通知Colleague1
        if (m_Colleague2 == theColleague)
            m_Colleague1.Request(Message);
    }
}