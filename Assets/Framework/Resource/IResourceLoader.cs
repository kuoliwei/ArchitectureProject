using System.Threading.Tasks;

public interface IResourceLoader
{
    Task<T> LoadAsync<T>(string key) where T : UnityEngine.Object;
    //透過 key 非同步載入資源，支援泛型，例如 LoadAsync<Sprite>("bg01")
    void Release<T>(T obj);
    //載入後釋放資源（只在 Addressables 需要，Resources 可留空）
}
//一、用途與設計目標
//遊戲開發中會載入大量資源，例如：

//背景圖

//人物立繪

//音效、BGM

//Prefab 或特效

//為了統一管理這些資源的「載入」與「釋放」邏輯，我們定義一個共用介面 IResourceLoader，讓其他模組不需要知道你是用：

//Resources.Load 還是

//Addressables 還是

//自訂 AssetBundle