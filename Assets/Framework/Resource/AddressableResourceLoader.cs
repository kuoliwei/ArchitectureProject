using System.Threading.Tasks;
using UnityEngine;

public class AddressableResourceLoader : IResourceLoader
{
    public async Task<T> LoadAsync<T>(string key) where T : Object
    {
        // 模擬非同步載入
        return await Task.FromResult(Resources.Load<T>(key));
    }

    public void Release<T>(T asset)
    {
        // Resources 不需要釋放，這裡可保留空實作
    }
}
