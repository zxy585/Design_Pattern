using UnityEngine;

public class GameEventSystem{public GameEventSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("GameEventSystem"); } };
public class CampSystem { public CampSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("CampSystem"); } };
public class StageSystem { public StageSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("StageSystem"); } };
public class CharacterSystem { public CharacterSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("CharacterSystem"); } };
public class APSystem { public APSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("APSystem"); } };
public class AchievementSystem { public AchievementSystem(PBaseDefenseGame a) { } public void Update() { Debug.Log("AchievementSystem"); } };

/// <summary>
/// 整合所有子系统,并提供高级界面的外观模式类
/// </summary>
public class PBaseDefenseGame : MonoBehaviour
{
    private static PBaseDefenseGame _instance;
    public static PBaseDefenseGame Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("产生PBaseDefenseGame");
                _instance = new PBaseDefenseGame();
            }
            return _instance;
        }
    }
    //...
    /// <summary>
    /// 游戏事件系统
    /// </summary>
    private GameEventSystem m_GameEventSystem = null;
    /// <summary>
    /// 兵营系统
    /// </summary>
    private CampSystem m_CampSystem = null;
    /// <summary>
    /// 关卡系统
    /// </summary>           
    private StageSystem m_StageSystem = null;
    /// <summary>
    /// 角色管理系统
    /// </summary>     
    private CharacterSystem m_CharacterSystem = null;
    /// <summary>
    /// 行动力系统
    /// </summary>     
    private APSystem m_ApSystem = null;
    /// <summary>
    /// 成就系统
    /// </summary>                 
    private AchievementSystem m_AchievementSystem = null;
    //...             


    private bool m_bGameOver = false;

    /// <summary>
    /// 初始化
    /// </summary>
    public void Initinal()
    {
        //场景状态控制
        m_bGameOver = false;
        //游戏系统
        m_GameEventSystem = new GameEventSystem(this);
        m_CampSystem = new CampSystem(this);
        m_StageSystem = new StageSystem(this);
        m_CharacterSystem = new CharacterSystem(this);
        m_ApSystem = new APSystem(this);
        m_AchievementSystem = new AchievementSystem(this);
        //...
    }

    /// <summary>
    /// 更新
    /// </summary>
    public void Update()
    {
        //游戏系统更新
        m_GameEventSystem.Update();
        m_CampSystem.Update();
        m_StageSystem.Update();
        m_CharacterSystem.Update();
        m_ApSystem.Update();
        m_AchievementSystem.Update();
        // ...

        //玩家界面更新
        //m_CampInfoUI.Update();
        //m_SoldierInfoUI.Update();
        //m_GameStateInfoUI.Update();
        //m_GamePauseUI.Update();

    }

    /// <summary>
    /// 释放
    /// </summary>
    public void Release()
    {

    }



    /// <summary>
    /// 结束
    /// </summary>
    public bool ThisGameIsOver()
    {
      return  m_bGameOver;
    }

}
