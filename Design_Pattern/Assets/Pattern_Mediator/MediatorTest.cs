using UnityEngine;

public class MediatorTest : MonoBehaviour
{

    void Start()
    {
        UnitTest();
    }

    // 
    void UnitTest()
    {

        ConcreteMediator pMediator = new ConcreteMediator();

        ConcreateColleague1 pColleague1 = new ConcreateColleague1(pMediator);
        ConcreateColleague2 pColleague2 = new ConcreateColleague2(pMediator);

        pMediator.SetColleageu1(pColleague1);
        pMediator.SetColleageu2(pColleague2);

        pColleague1.Action();
        pColleague2.Action();
    }
}