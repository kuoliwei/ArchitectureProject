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
//�@�B�ؼлP�γ~
//�C�����g�`�ݭn�G

//�x�s�]�w�]���q�j�p�B�y�����n�^

//�x�s�i�ס]�ثe���`�B����ƭȡ^

//���J���a�O���]�����ơB�ө��ʶR�����^

//���F����Ʀs���ҲդơB���X�R�A�ڭ̥��]�p�@���x�s���� IDataService�A�A�� JsonDataService �@�������@�C
