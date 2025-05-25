using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using System;

public static class ServiceLocator
{
    private static Dictionary<Type, object> services = new();

    public static void Register<T>(T service) => services[typeof(T)] = service;
    //    �o�O�u���U�A�ȡv����k�C

    //T �O�x���A���\�A���U���N�����]�Ҧp IDataService�BIEventBus ���^

    //typeof(T) �O�Ψӷ�@�r�媺 key

    //�N�Ƕi�Ӫ�����]�p new JsonDataService()�^�n�O�i�r�夤
    public static T Get<T>() => (T)services[typeof(T)];
    //    �o�O�u���o�A�ȡv����k�C

    //�� typeof(T) �h�r�夤�d��

    //�j���૬�� T �A�^�ǡ]�A�n���O IDataService�A�N�|�ন���ӫ��O�^

    public static void RegisterAll()
    {
        Register<IDataService>(new JsonDataService());
        Register<IResourceLoader>(new AddressableResourceLoader());
        Register<IEventBus>(new DefaultEventBus());
    }
}
//�A�i�H��u�A�ȡv�Q���O�@�ӥ���i�Ϊ��Ҳթκ޲z���A���o�Ǳ`�����F��G

//�x�s�t�Ρ]�s��/Ū�ɡ^

//�귽���J���]���J�Ϥ��BPrefab�^

//�ƥ��`�u�]�ǰe�ƥ�q���^

//���ı���]���񭵼֡^

///����y�{�`���ϡG
//    [GameEntry.cs]
//        �� �I�s RegisterAll()
//[ServiceLocator] �w�w�� services: Dictionary<Type, object>
//        ��                   ��
//        ��             Register<T>(����)
//        ��                   ��
//        �|�w�w�w�w�w Get<T>() ���w�w�w�w�w ���N�Ҳըϥ�
