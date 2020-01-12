using System.Threading.Tasks;

namespace Ofl.Threading.Tasks
{
    public static class ValueTaskExtensions
    {
        public static ValueTask<T> FromResult<T>(T result) => new ValueTask<T>(result);

        public static T RunInContext<T>(this in ValueTask<T> task) => task.AsTask().RunInContext();
    }
}
