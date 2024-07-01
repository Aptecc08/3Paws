using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private bool _isBlocked;

    private Gem _gem;
    private bool _isEmpty;

    private void Start()
    {
        if (!_isBlocked)
            //��������� ��� �� ������ �� ����
            GemManager.Instance.GetTypeForGenerateGem();
    }
    private void UnBlocked()
    {
        _isBlocked = false;
    }

    public void SetGem(Gem gem)
    {
        _gem = gem;
    }

    public void ChangeFillingStatus()
    {
        _isEmpty = !_isEmpty;
    }

    public Gem GetGem()
    {
        return _gem;
    }
}
