using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Block check", menuName = "Check strategy/Block check")]
public class BlocksStrategy : CheckStrategy
{
    public override FieldPartState Check(IFieldPart[] blocks)
    {
        Debug.Log("Check block strategy");
        int countX = 0;
        int countO = 0;
        int countTie = 0;
        foreach(IFieldPart block in blocks)
        {
            if(block.CheckState() == FieldPartState.PlayerO)
            {
                countO++;
            }
            else if(block.CheckState() == FieldPartState.PlayerX)
            {
                countX++;
            }
            else if (block.CheckState() == FieldPartState.Tie)
            {
                countTie++;
            }            
        }
        int countNotTieMatchOrNotFinished = blocks.Length - countTie;

        Debug.Log($"X: {countX}, O: {countO}, Tie: {countTie}");
        if (countX > countNotTieMatchOrNotFinished / 2) return FieldPartState.PlayerX;
        else if (countO > countNotTieMatchOrNotFinished / 2) return FieldPartState.PlayerO;
        else if (countO + countX + countTie == blocks.Length) return FieldPartState.Tie;
        else return FieldPartState.NotFinished;
    }

}
