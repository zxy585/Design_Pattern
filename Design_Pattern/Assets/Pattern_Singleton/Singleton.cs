//单例
public class Singleton
{
    public string Name { get; set; }

    private static Singleton _instance;
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                UnityEngine.Debug.Log("产生Singleton");
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    private Singleton() { }
}
