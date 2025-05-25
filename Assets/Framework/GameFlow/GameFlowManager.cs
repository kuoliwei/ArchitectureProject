public class GameFlowManager
{
    private static GameFlowManager _instance = new();
    public static GameFlowManager Instance => _instance;
    //�ϥ� Singleton�]��ҼҦ��^�A����ӱM�פ�����a�賣��I�s�G

    private IGameState _current;
    //�ΨӫO�s�ثe�����A�C�o���ܼƷ|���V�ثe���椤���y�{���A����A�Ҧp MainMenuState�C
    public void ChangeState(IGameState newState)
    {
        _current?.OnExit();
        _current = newState;
        _current.OnEnter();
    }
    //������s���C�����A�C
}
//�@�B�֤߷����G����O�u�C���y�{���A�v�H
//�b�Ҧ��C�����A����y�{�q�`�|�����H�U�X�Ӫ��A�]State�^�G

//�D��� MainMenu

//���d��� LevelSelect

//���d�i�椤 InGame

//�C���Ȱ� Paused

//���d���� GameResult

//�ӳo�Ǭy�{�����ݭn����������C
//�o�ɭԨϥΡu���A�Ҧ��]State Pattern�^�v�N�D�`�X�A�A�����y�{�M�������B�����X�R�C

// �b����[�c��������
//����	����
//���ݼh��	GameFlow �h�]�C���D�y�{����^
//�d��	�޲z�C���q�@�Ӫ��A�ഫ��t�@���A
//�P�֤���	IGameState ���Ҧ���@���O�A�p MainMenuState, PlayState
