using AntarisApi.Application.DTO;

namespace AntarisApi.Core.Interfaces
{
    public interface IInstanceService
    {
        public void RegisterInstance(ScriptInstanceStartRequest scriptInstanceStartRequest);
    }
}
