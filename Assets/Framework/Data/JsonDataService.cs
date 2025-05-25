using System.IO;
using UnityEngine;

public class JsonDataService : IDataService
{
    private string GetPath(string key)
    {
        return Path.Combine(Application.persistentDataPath, $"{key}.json");
    }

    public void Save<T>(string key, T data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(GetPath(key), json);
    }

    public T Load<T>(string key, T defaultValue)
    {
        string path = GetPath(key);
        if (!File.Exists(path))
            return defaultValue;

        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<T>(json);
    }
}
//一、目標與用途
//遊戲中經常需要：

//儲存設定（音量大小、語言偏好）

//儲存進度（目前章節、角色數值）

//載入玩家記錄（角色資料、商店購買紀錄）

//為了讓資料存取模組化、易擴充，我們先設計一個儲存介面 IDataService，再用 JsonDataService 作為具體實作。
