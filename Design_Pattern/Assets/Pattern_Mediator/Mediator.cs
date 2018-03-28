//用来管理Colleague对象的接口
public abstract class Mediator
{
    public abstract void SendMessage(Colleague theColleague, string Message);
}