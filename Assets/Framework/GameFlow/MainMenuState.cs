using UnityEngine;

public class MainMenuState : IGameState
{
    public void OnEnter()
    {
        Debug.Log("�w�i�J�D��檬�A");
        // �o�̥i�H��ܥD��� UI�A�����ӹ�@ UIManager �ɦA�ɤW
    }

    public void OnExit()
    {
        Debug.Log("�w���}�D��檬�A");
        // �q�`�o�̷|�����D��� UI
    }
}
