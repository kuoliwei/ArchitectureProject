using UnityEngine;

public class MainMenuState : IGameState
{
    public void OnEnter()
    {
        Debug.Log("已進入主選單狀態");
        // 這裡可以顯示主選單 UI，等未來實作 UIManager 時再補上
    }

    public void OnExit()
    {
        Debug.Log("已離開主選單狀態");
        // 通常這裡會關閉主選單 UI
    }
}
