using System;

public interface IEventBus
{
    void Subscribe<T>(Action<T> handler);
    void Unsubscribe<T>(Action<T> handler);
    void Publish<T>(T evt);
}
//一、模組用途說明
//這是一個「事件中心系統（Event Bus）」，目的是：

//提供遊戲內模組之間的鬆耦合通訊方式，不需要彼此持有參考也能溝通。

//你可以這樣理解：

//玩家血量歸零 → 發送 PlayerDiedEvent

//其他系統（音效、特效、畫面）只要有訂閱這個事件，就能收到通知

//沒有人需要知道彼此的存在 → 模組之間更鬆散、更彈性

//這就是「觀察者模式（Observer Pattern）」的一種實作。

