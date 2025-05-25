public class GameFlowManager
{
    private static GameFlowManager _instance = new();
    public static GameFlowManager Instance => _instance;
    //使用 Singleton（單例模式），讓整個專案中任何地方都能呼叫：

    private IGameState _current;
    //用來保存目前的狀態。這個變數會指向目前執行中的流程狀態物件，例如 MainMenuState。
    public void ChangeState(IGameState newState)
    {
        _current?.OnExit();
        _current = newState;
        _current.OnEnter();
    }
    //切換到新的遊戲狀態。
}
//一、核心概念：什麼是「遊戲流程狀態」？
//在所有遊戲中，整體流程通常會分為以下幾個狀態（State）：

//主選單 MainMenu

//關卡選擇 LevelSelect

//關卡進行中 InGame

//遊戲暫停 Paused

//關卡結算 GameResult

//而這些流程之間需要做切換控制。
//這時候使用「狀態模式（State Pattern）」就非常合適，能讓流程清楚分離、易於擴充。

// 在整體架構中的角色
//項目	說明
//所屬層級	GameFlow 層（遊戲主流程控制）
//責任	管理遊戲從一個狀態轉換到另一狀態
//與誰互動	IGameState 的所有實作類別，如 MainMenuState, PlayState
