using System;

public interface IEventBus
{
    void Subscribe<T>(Action<T> handler);
    void Unsubscribe<T>(Action<T> handler);
    void Publish<T>(T evt);
}
//�@�B�Ҳեγ~����
//�o�O�@�ӡu�ƥ󤤤ߨt�Ρ]Event Bus�^�v�A�ت��O�G

//���ѹC�����Ҳդ������P���X�q�T�覡�A���ݭn���������ѦҤ]�෾�q�C

//�A�i�H�o�˲z�ѡG

//���a��q�k�s �� �o�e PlayerDiedEvent

//��L�t�Ρ]���ġB�S�ġB�e���^�u�n���q�\�o�Өƥ�A�N�ব��q��

//�S���H�ݭn���D�������s�b �� �Ҳդ������P���B��u��

//�o�N�O�u�[��̼Ҧ��]Observer Pattern�^�v���@�ع�@�C

