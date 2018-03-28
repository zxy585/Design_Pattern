using UnityEngine;

/// <summary>
/// Unity工具
/// </summary>
public static class UnityTool
{

    /// <summary>
    /// 找到场景上的对象
    /// </summary>
    public static GameObject FindGameObject(string GameObjectName)
    {
        //找到对应的GameObject
        GameObject pTmpGameObj = GameObject.Find(GameObjectName);
        if (pTmpGameObj == null)
        {
            Debug.LogWarning("场景中找不到GameObject[" + GameObjectName + "]对象");
            return null;
        }
        return pTmpGameObj;
    }

    /// <summary>
    /// 获取子对象
    /// </summary>
    public static GameObject FindChildGameObject(GameObject Container, string gameobjectName)
    {
        if (Container == null)
        {
            Debug.LogError("NGUICustomTools.GetChild : Container =null");
            return null;
        }

        Transform pGameObjectTF = null;


        //是不是Container本身
        if (Container.name == gameobjectName)
            pGameObjectTF = Container.transform;
        else
        {
            // 找出所有子组件                        
            Transform[] allChildren = Container.transform.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                if (child.name == gameobjectName)
                {
                    if (pGameObjectTF == null)
                        pGameObjectTF = child;
                    else
                        Debug.LogWarning("Container[" + Container.name + "]下找出重复的组件名称[" + gameobjectName + "]");
                }
            }
        }

        //都沒有找到
        if (pGameObjectTF == null)
        {
            Debug.LogError("组件[" + Container.name + "]找不到子组件[" + gameobjectName + "]");
            return null;
        }
        return pGameObjectTF.gameObject;
    }
}
