public static class DataHolder
{
    private static FieldPartState _tempPlayer = FieldPartState.PlayerX;

    public static FieldPartState TempPlayer => _tempPlayer;
    public static FieldPartState winner;

    public static AbstractSceneBuilder SceneBuilder { get; set; }
    
    public static void ChangePlayer()
    {
        if (_tempPlayer == FieldPartState.PlayerX)
        {
            _tempPlayer = FieldPartState.PlayerO;
        }
        else if (_tempPlayer == FieldPartState.PlayerO)
        {
            _tempPlayer = FieldPartState.PlayerX;
        }
        else
        {
            throw new System.ArgumentException($"Player can't be {_tempPlayer}");
        }
    }
    
    public static void Win(FieldPartState partState)
    {
        _tempPlayer = FieldPartState.PlayerX;
        winner = partState;
    }  
}


