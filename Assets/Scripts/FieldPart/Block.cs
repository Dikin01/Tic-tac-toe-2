using UnityEngine;

public class Block : MonoBehaviour, IFieldPart
{
    [SerializeField] private CheckStrategy _strategy;
    [SerializeField] private GameObject[] _objectWithFieldParts;
    private IFieldPart[] _fieldParts;
    private FieldPartState _state = FieldPartState.NotFinished;
    public CheckStrategy Strategy => _strategy;
    FieldPartState IFieldPart.State { get => _state; set => _state = value; }

    private void Start()
    {
        _fieldParts = new IFieldPart[_objectWithFieldParts.Length];
        for (int i = 0; i < _fieldParts.Length; i++)
            _fieldParts[i] = _objectWithFieldParts[i].GetComponent<IFieldPart>();
    }

    public FieldPartState CheckState()
    {
        return _strategy.Check(_fieldParts);
    }
    
    public void Lock()
    {
        foreach(IFieldPart fieldPart in _fieldParts)
        {
            fieldPart.Lock();
        }
    }

    public void Unlock()
    {
        foreach (IFieldPart fieldPart in _fieldParts)
        {
            if(fieldPart.State == FieldPartState.NotFinished)
                fieldPart.Unlock();
        }
    }
}
