// Mediator所控管的Colleague
public abstract class Colleague
{
    protected Mediator m_Mediator = null;

    public Colleague(Mediator theMediator)
    {
        m_Mediator = theMediator;
    }

    // Mediator通知請求
    public abstract void Request(string Message);

}
