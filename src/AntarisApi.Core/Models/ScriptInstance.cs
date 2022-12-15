namespace AntarisApi.Core.Models
{
    public class ScriptInstance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public int ScriptId { get; set; }

        public Script Script { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

    }
}
