namespace Gestin.Model.Model_Internal
{
    internal class DraggedData
    {
        int id;
        string? description;
        string? other;
        public DraggedData(int id, string? description)
        {
            this.id = id;
            this.description = description;
        }
        public DraggedData(int id, string? description, string? other)
        {
            this.id = id;
            this.description = description;
            this.other = other;
        }
        public int GetId { get => id; }
        public int SetId { set => id = value; }
        public string? GetDescription { get => description; }
        public string? SetDescription { set => description = value; }
        public string? GetOther { get => other; }
        public string? SetOther { set => other = value; }

        public override string? ToString()
        {
            return $"{GetDescription} {GetOther}";
        }
    }
}
