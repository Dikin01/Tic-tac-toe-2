using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Cell : MonoBehaviour, IFieldPart
{
    private FieldPartState _state = FieldPartState.NotFinished;
    private Text _text;
    private ScoreObserver _scoreObserver;
    FieldPartState IFieldPart.State { get => _state; set => _state = value; }
    public Button Button { get; private set; }

    private void Awake()
    {        
        Button = GetComponent<Button>();
        _text = GetComponentInChildren<Text>();
        Button.onClick.AddListener(Selected);
    }

    private void Start()
    {
        _scoreObserver = FindObjectOfType<ScoreObserver>();
    }


    public FieldPartState CheckState()
    {
        return _state;
    }

    public void Selected()
    {
        _state = DataHolder.TempPlayer;

        
        if (_text != null)
        {
            _text.text = _state switch
            {
                FieldPartState.PlayerX => "X",
                FieldPartState.PlayerO => "O",
                _ => ""
            };
        }

        Button.interactable = false;

        DataHolder.ChangePlayer();
        _scoreObserver?.UpdateScore();        
        
    }

    public void Disable()
    {
        throw new System.NotImplementedException();
    }

    public void EnableFields()
    {
        throw new System.NotImplementedException();
    }
}
