using System;
using System.Collections.Generic;

public class DefaultEventBus : IEventBus
{
    private Dictionary<Type, List<Delegate>> _subscribers = new();
    //    �ѻ��G
    //�ϥ� Dictionary<Type, List<Delegate>> �ӰO���Ҧ����ƥ��ť��

    //key �O�ƥ󫬧O�A�Ҧp typeof(PlayerDiedEvent)

    //value �O�Ҧ��q�\�Өƥ󪺳B�z�禡�]Action<PlayerDiedEvent> �Q���� Delegate�^

    //�]�N�O���G

    //�u�C�@�بƥ󫬧O�����@�խq�\�̲M��v
    public void Subscribe<T>(Action<T> handler)
    {
        var type = typeof(T);
        //        ���o�ƥ󫬧O�]�p typeof(PlayerDiedEvent)�^

        //�Ψӧ@���r�媺 key
        if (!_subscribers.ContainsKey(type))
            _subscribers[type] = new List<Delegate>();
        _subscribers[type].Add(handler);
        //�p�G�r�夤�S���o�ӫ��O�A�N��l�Ƥ@�ӪŪ��q�\�̲M��
    }
    //    �x����k�G���A�q�\���N���O���ƥ�]�Ҧp PlayerDiedEvent�BEnemySpawnedEvent�^

    //Action<T> �O�@�ةe���]delegate�^�A��ܡu�����@�� T �ƥ󪫥󪺨禡�v

    public void Unsubscribe<T>(Action<T> handler)
    {
        var type = typeof(T);
        if (_subscribers.ContainsKey(type))
            _subscribers[type].Remove(handler);
        //�ˬd�o�ӫ��O���L�q�\

        //�����ܴN����w�� handler �q�M�椤����
    }
    //���\�A�����q�\�Y�Өƥ�]�Ҧp����Q�P���e�������U�^

    public void Publish<T>(T evt)
    {
        var type = typeof(T);
        if (_subscribers.TryGetValue(type, out var list))
        {
            foreach (var handler in list)
                ((Action<T>)handler).Invoke(evt);
            //            ��C�� handler �j���૬�� Action<T>�]�]�� list �O Delegate ���O�^

            //�I�s�Ө禡�A�ç�ƥ� evt �ǵ���
        }
        //�p�G���q�\�̡A�N��������e���M����X�ӡ]list �O�@�� List < Delegate >�^
    }
    //    �o�e�@�Өƥ�]�p new PlayerDiedEvent { id = 1 }�^

    //�Ҧ���o�Өƥ󫬧O�����U���q�\�̳��|����q��
}
