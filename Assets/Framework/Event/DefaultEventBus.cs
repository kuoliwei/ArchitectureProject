using System;
using System.Collections.Generic;

public class DefaultEventBus : IEventBus
{
    private Dictionary<Type, List<Delegate>> _subscribers = new();
    //    解說：
    //使用 Dictionary<Type, List<Delegate>> 來記錄所有的事件監聽者

    //key 是事件型別，例如 typeof(PlayerDiedEvent)

    //value 是所有訂閱該事件的處理函式（Action<PlayerDiedEvent> 被視為 Delegate）

    //也就是說：

    //「每一種事件型別都有一組訂閱者清單」
    public void Subscribe<T>(Action<T> handler)
    {
        var type = typeof(T);
        //        取得事件型別（如 typeof(PlayerDiedEvent)）

        //用來作為字典的 key
        if (!_subscribers.ContainsKey(type))
            _subscribers[type] = new List<Delegate>();
        _subscribers[type].Add(handler);
        //如果字典中沒有這個型別，就初始化一個空的訂閱者清單
    }
    //    泛型方法：讓你訂閱任意型別的事件（例如 PlayerDiedEvent、EnemySpawnedEvent）

    //Action<T> 是一種委派（delegate），表示「接受一個 T 事件物件的函式」

    public void Unsubscribe<T>(Action<T> handler)
    {
        var type = typeof(T);
        if (_subscribers.ContainsKey(type))
            _subscribers[type].Remove(handler);
        //檢查這個型別有無訂閱

        //有的話就把指定的 handler 從清單中移除
    }
    //允許你取消訂閱某個事件（例如物件被銷毀前取消註冊）

    public void Publish<T>(T evt)
    {
        var type = typeof(T);
        if (_subscribers.TryGetValue(type, out var list))
        {
            foreach (var handler in list)
                ((Action<T>)handler).Invoke(evt);
            //            把每個 handler 強制轉型成 Action<T>（因為 list 是 Delegate 型別）

            //呼叫該函式，並把事件 evt 傳給它
        }
        //如果有訂閱者，就把對應的委派清單取出來（list 是一個 List < Delegate >）
    }
    //    發送一個事件（如 new PlayerDiedEvent { id = 1 }）

    //所有對這個事件型別有註冊的訂閱者都會收到通知
}
