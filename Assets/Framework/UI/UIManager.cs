using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Dictionary<string, GameObject> panels = new();

    public void Show(string panelName)
    {
        if (!panels.ContainsKey(panelName))
        {
            var prefab = Resources.Load<GameObject>($"UI/{panelName}");
            panels[panelName] = Instantiate(prefab, transform);
        }
        panels[panelName].SetActive(true);
    }
    //這能讓我們的 GameState 或 其他模組
    //不需要知道這個面板在哪裡、怎麼 Instantiate、是不是已經在場景裡。


    public void Hide(string panelName)
    {
        if (panels.TryGetValue(panelName, out var go))
        {
            go.SetActive(false);
        }
    }
}
//一、功能說明
//UIManager 是一個統一的面板管理中心，負責：

//開啟 / 關閉 UI 面板

//避免重複 Instantiate

//集中 UI 控制邏輯，不分散在各場景或腳本中
