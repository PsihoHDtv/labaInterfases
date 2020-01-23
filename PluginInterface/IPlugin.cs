using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get; }
        string Autor { get; }
        void Transform(Bitmap app);
    }
}