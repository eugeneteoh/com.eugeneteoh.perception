// ReSharper disable MemberCanBePrivate.Global

using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.Perception.GroundTruth
{
    [MovedFrom("UnityEditor.Perception.Internal")]
    static class RandomizationLibraryConfiguration
    {
        internal const string BaseDirectory = "Packages/com.eugeneteoh.perception/";
        internal static readonly string EditorBaseDirectory = $"{BaseDirectory}/Editor/RandomizerLibrary";
        internal static readonly string RuntimeTestResourcesDirectory = $"{BaseDirectory}/Tests/Runtime/Internal/Resource";
        internal static readonly string EditorUxmlDirectory = $"{EditorBaseDirectory}/Uxml";
        internal static readonly string EditorUssDirectory = $"{EditorBaseDirectory}/Uss";
    }
}
