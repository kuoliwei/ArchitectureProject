using System.Threading.Tasks;

public interface IResourceLoader
{
    Task<T> LoadAsync<T>(string key) where T : UnityEngine.Object;
    //�z�L key �D�P�B���J�귽�A�䴩�x���A�Ҧp LoadAsync<Sprite>("bg01")
    void Release<T>(T obj);
    //���J������귽�]�u�b Addressables �ݭn�AResources �i�d�š^
}
//�@�B�γ~�P�]�p�ؼ�
//�C���}�o���|���J�j�q�귽�A�Ҧp�G

//�I����

//�H����ø

//���ġBBGM

//Prefab �ίS��

//���F�Τ@�޲z�o�Ǹ귽���u���J�v�P�u����v�޿�A�ڭ̩w�q�@�Ӧ@�Τ��� IResourceLoader�A����L�Ҳդ��ݭn���D�A�O�ΡG

//Resources.Load �٬O

//Addressables �٬O

//�ۭq AssetBundle