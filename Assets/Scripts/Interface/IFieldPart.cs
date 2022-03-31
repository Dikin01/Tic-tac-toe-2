public interface IFieldPart
{
    public FieldPartState State { get; set; }
    public FieldPartState CheckState();
    public void Lock();
    public void Unlock();
}
