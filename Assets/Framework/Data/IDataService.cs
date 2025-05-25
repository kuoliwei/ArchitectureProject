using System.IO;
using UnityEngine;

public interface IDataService
{
    void Save<T>(string key, T data);
    T Load<T>(string key, T defaultValue);
}
//�o�O�@�Ӫx�������A�䴩�x�s / ���J�������� T �����

//key �O�ɮצW�١]�� PlayerPrefs �W�١^

//defaultValue �O��䤣���Ʈɪ��w�]��