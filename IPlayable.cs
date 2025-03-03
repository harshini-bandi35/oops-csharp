/***Interface Implementation Challenge**

Define an interface `IPlayable` with a method `Play()`.
Implement this interface in `MusicPlayer` and `VideoPlayer`
classes with different implementations.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    interface IPlayable
    {
        void Play();
        
    }
    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music");
        }
    }
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video");
        }
    }
}
