
public interface IGameState
{
    void OnEnter();
    void OnExit();
}
//所有遊戲流程狀態都必須實作這個介面

//保證每個狀態都會定義「進入」與「離開」的行為

//例如 MainMenuState, PlayState, PauseState 都會繼承它

//一、核心概念：什麼是「遊戲流程狀態」？
//在所有遊戲中，整體流程通常會分為以下幾個狀態（State）：

//主選單 MainMenu

//關卡選擇 LevelSelect

//關卡進行中 InGame

//遊戲暫停 Paused

//關卡結算 GameResult

//而這些流程之間需要做切換控制。
//這時候使用「狀態模式（State Pattern）」就非常合適，能讓流程清楚分離、易於擴充。
