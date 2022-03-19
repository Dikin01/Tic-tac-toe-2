using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CheckStrategy : ScriptableObject
{
    public abstract FieldPartState Check(IFieldPart[] blocks);
}
