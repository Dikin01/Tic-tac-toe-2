using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreObserver : MonoBehaviour
{
    public event Action OnFinishMove; //������� ����� ����
    public event Action<FieldPartState> OnWin; //������� ����� ������

    private MainBlock _mainBlock; //�� ������� ����

    public int ScorePlayerX { get; private set; }
    public int ScorePlayerO { get; private set; }

    public void FinishMove()
    {
        Debug.Log("Cell click");
        OnFinishMove?.Invoke();
    }

    private void Start()
    {
        _mainBlock = FindObjectOfType<MainBlock>();

        //���������� ���� �� ��������� ����������� � ������� OnEnable � �������� � ����� �������������         
        OnFinishMove += DataHolder.ChangePlayer;
        OnFinishMove += CheckWin; //���, ���� �������� � ChangePlayer �������
        OnWin += DataHolder.Win;
    }

    private void CheckWin()
    {
        FieldPartState state = _mainBlock.GetBlock().CheckState();
        switch (state)
        {
            case FieldPartState.PlayerX:
                Debug.Log("Player X is winner!!!");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
            case FieldPartState.PlayerO:
                Debug.Log("Player O is winner!!!");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
            case FieldPartState.Tie:
                Debug.Log("Tie((");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
        }        
    }
}
