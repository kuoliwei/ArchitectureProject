using UnityEngine;

public class GameStartup : MonoBehaviour
{
    public GameObject uiManagerPrefab;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // 保持常駐，不在場景切換時消失

        // 1. 註冊全域服務（呼叫 ServiceLocator 設定各種服務）
        ServiceLocator.RegisterAll();

        // 2. 建立 UI 管理器
        if (uiManagerPrefab != null)
        {
            var ui = Instantiate(uiManagerPrefab);
            DontDestroyOnLoad(ui); // 讓 UIManager 跨場景共用
            ServiceLocator.Register(ui.GetComponent<UIManager>());
        }

        // 3. 啟動遊戲主流程狀態
        GameFlowManager.Instance.ChangeState(new MainMenuState());
    }
}
//一、用途說明
//GameStartup 是整個遊戲架構的進入點，掛在場景中的第一個 GameObject 上，負責：

//建立 ServiceLocator 所需的所有服務（已在 GameEntry 處理）

//將所有必要的管理器類別實體化並常駐化（例如：UIManager）

//啟動第一個遊戲狀態（例如 MainMenuState）

//它等同於一個「組裝師／總指揮官」，一旦完成初始化就不再處理遊戲邏輯。


