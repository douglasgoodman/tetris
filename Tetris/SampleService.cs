using System;

namespace Tetris
{
    public interface ISampleService
    {
        public string GetCurrentDate();
    }

    public class SampleService : ISampleService
    {
        public string GetCurrentDate() => DateTime.Now.ToLongDateString();
    }
}
