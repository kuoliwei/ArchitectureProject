using System.Threading.Tasks;
using UnityEngine;

public class AddressableResourceLoader : IResourceLoader
{
    public async Task<T> LoadAsync<T>(string key) where T : Object
    {
        // �����D�P�B���J
        return await Task.FromResult(Resources.Load<T>(key));
    }

    public void Release<T>(T asset)
    {
        // Resources ���ݭn����A�o�̥i�O�d�Ź�@
    }
}
