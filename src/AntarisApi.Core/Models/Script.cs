namespace AntarisApi.Core.Models
{
    public class Script
    {
        public int Id { get; set; }
        public string UniqueId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ICollection<ScriptInstance> ScriptInstances { get; set; } = null!;
    }
}
