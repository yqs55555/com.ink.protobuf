
using System.Reflection;

namespace Ink.Protobuf
{
    internal class ProtobufExportParam
    {
        public Assembly Assembly { get; private set; }

        internal ProtobufExportParam(Assembly assembly) 
        { 
            this.Assembly = assembly;
        }
    }
}
