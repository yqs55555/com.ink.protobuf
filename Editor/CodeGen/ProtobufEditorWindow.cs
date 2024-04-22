using System;
using System.Reflection;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Ink.Protobuf
{
    public class ProtobufEditorWindow : EditorWindow
    {
        [MenuItem("Tools/Ink/ProtobufExport")]
        public static void Export()
        {
            Assembly currentAssembly = typeof(SerializationUtility).Assembly;
            var allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in allAssemblies)
            {
                var references = assembly.GetReferencedAssemblies();
                foreach (var reference in references)
                {
                    if (currentAssembly.FullName == reference.FullName)
                    {
                        Debug.LogWarning(assembly.FullName);
                        break;
                    }
                }
            }
        }
    }
}
