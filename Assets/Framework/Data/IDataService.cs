using System.IO;
using UnityEngine;

public interface IDataService
{
    void Save<T>(string key, T data);
    T Load<T>(string key, T defaultValue);
}
//這是一個泛型介面，支援儲存 / 載入任何類型 T 的資料

//key 是檔案名稱（或 PlayerPrefs 名稱）

//defaultValue 是當找不到資料時的預設值