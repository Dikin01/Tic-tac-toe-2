using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Cells check", menuName = "Check strategy/Cells check")]
public class CellsStrategy : CheckStrategy
{
    private readonly List<(int, int, int)> _combinations = new List<(int, int, int)>()
    {
        (0,1,2),
        (3,4,5),
        (6,7,8),
        (0,3,6),
        (1,4,7),
        (2,5,8),
        (0,4,8),
        (2,4,6)
    };

    public override FieldPartState Check(IFieldPart[] blocks)
    {       
        if (blocks.All(b => b is Cell))
        {
            foreach (var (i, j, k) in _combinations)
            {
                if (blocks[i].CheckState() != FieldPartState.NotFinished &&
                    blocks[i].CheckState() == blocks[j].CheckState() &&
                    blocks[i].CheckState() == blocks[k].CheckState())
                {
                    return blocks[i].CheckState();
                }
            }

            if(blocks.All(x => x.CheckState() != FieldPartState.NotFinished))
                return FieldPartState.Tie;
        }
        else
            throw new System.Exception($"First element {(blocks[0] as MonoBehaviour).name} in blocks isn't Cell");

        return FieldPartState.NotFinished;
    }
}
