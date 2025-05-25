using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Dictionary<string, GameObject> panels = new();

    public void Show(string panelName)
    {
        if (!panels.ContainsKey(panelName))
        {
            var prefab = Resources.Load<GameObject>($"UI/{panelName}");
            panels[panelName] = Instantiate(prefab, transform);
        }
        panels[panelName].SetActive(true);
    }
    //�o�����ڭ̪� GameState �� ��L�Ҳ�
    //���ݭn���D�o�ӭ��O�b���̡B��� Instantiate�B�O���O�w�g�b�����̡C


    public void Hide(string panelName)
    {
        if (panels.TryGetValue(panelName, out var go))
        {
            go.SetActive(false);
        }
    }
}
//�@�B�\�໡��
//UIManager �O�@�ӲΤ@�����O�޲z���ߡA�t�d�G

//�}�� / ���� UI ���O

//�קK���� Instantiate

//���� UI �����޿�A�������b�U�����θ}����
