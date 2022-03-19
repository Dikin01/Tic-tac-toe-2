using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreObserver : MonoBehaviour
{  

    public event Action<FieldPartState> OnChangeScores;
    public event Action<FieldPartState> OnWin;
    private FieldPartState _stateGlobal = FieldPartState.NotFinished; //� ����� �������� ����, ���� ���������, ��� ��� � ����� ������ �� ���� �� ��� ������ ���������
    private MainBlock _mainBlock;

    public int ScorePlayerX { get; private set; }
    public int ScorePlayerO { get; private set; }

    public void UpdateScore()
    {
        Debug.Log("UpdateScore");
        OnChangeScores?.Invoke(DataHolder.TempPlayer);

    }

    private void Start()
    {
        _mainBlock = FindObjectOfType<MainBlock>(); //��� � Awake?
        OnChangeScores += CheckWin;
        OnWin += DataHolder.Win;
    }

    private void CheckWin(FieldPartState fuck)
    {
        
        FieldPartState state = _mainBlock.GetBlock().CheckState();
        switch (state)
        {
            case FieldPartState.PlayerX:
                Debug.Log("Player 1 is winner!!!");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
            case FieldPartState.PlayerO:
                Debug.Log("Player 2 is winner!!!");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
            case FieldPartState.Tie:
                Debug.Log("Tie((");
                OnWin?.Invoke(state);
                SceneManager.LoadScene("FinishScene");
                break;
            case FieldPartState.NotFinished:
                Debug.Log("�� ������");
                break;
        }
        _stateGlobal = state;        
    }


}
