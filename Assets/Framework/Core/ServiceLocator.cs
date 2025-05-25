using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using System;

public static class ServiceLocator
{
    private static Dictionary<Type, object> services = new();

    public static void Register<T>(T service) => services[typeof(T)] = service;
    //    這是「註冊服務」的方法。

    //T 是泛型，允許你註冊任意類型（例如 IDataService、IEventBus 等）

    //typeof(T) 是用來當作字典的 key

    //將傳進來的實體（如 new JsonDataService()）登記進字典中
    public static T Get<T>() => (T)services[typeof(T)];
    //    這是「取得服務」的方法。

    //用 typeof(T) 去字典中查詢

    //強制轉型成 T 再回傳（你要的是 IDataService，就會轉成那個型別）

    public static void RegisterAll()
    {
        Register<IDataService>(new JsonDataService());
        Register<IResourceLoader>(new AddressableResourceLoader());
        Register<IEventBus>(new DefaultEventBus());
    }
}
//你可以把「服務」想成是一個全域可用的模組或管理器，像這些常見的東西：

//儲存系統（存檔/讀檔）

//資源載入器（載入圖片、Prefab）

//事件總線（傳送事件通知）

//音效控制器（播放音樂）

///整體流程總結圖：
//    [GameEntry.cs]
//        ↓ 呼叫 RegisterAll()
//[ServiceLocator] ──→ services: Dictionary<Type, object>
//        ↑                   ↓
//        ↑             Register<T>(實體)
//        ↑                   ↓
//        └───── Get<T>() ←───── 任意模組使用
