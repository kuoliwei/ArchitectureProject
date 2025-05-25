using UnityEngine;

public class GameStartup : MonoBehaviour
{
    public GameObject uiManagerPrefab;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // �O���`�n�A���b���������ɮ���

        // 1. ���U����A�ȡ]�I�s ServiceLocator �]�w�U�تA�ȡ^
        ServiceLocator.RegisterAll();

        // 2. �إ� UI �޲z��
        if (uiManagerPrefab != null)
        {
            var ui = Instantiate(uiManagerPrefab);
            DontDestroyOnLoad(ui); // �� UIManager ������@��
            ServiceLocator.Register(ui.GetComponent<UIManager>());
        }

        // 3. �ҰʹC���D�y�{���A
        GameFlowManager.Instance.ChangeState(new MainMenuState());
    }
}
//�@�B�γ~����
//GameStartup �O��ӹC���[�c���i�J�I�A���b���������Ĥ@�� GameObject �W�A�t�d�G

//�إ� ServiceLocator �һݪ��Ҧ��A�ȡ]�w�b GameEntry �B�z�^

//�N�Ҧ����n���޲z�����O����ƨñ`�n�ơ]�Ҧp�GUIManager�^

//�ҰʲĤ@�ӹC�����A�]�Ҧp MainMenuState�^

//�����P��@�ӡu�ոˮv���`�����x�v�A�@��������l�ƴN���A�B�z�C���޿�C


