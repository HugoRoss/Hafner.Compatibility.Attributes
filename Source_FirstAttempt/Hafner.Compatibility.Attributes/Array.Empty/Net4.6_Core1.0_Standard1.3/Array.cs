namespace Hafner.Compatibility.Attributes;

using System.Diagnostics.CodeAnalysis;

internal static partial class Array<T> {

    [SuppressMessage("Performance", "CA1810:Initialize all static fields when those fields are declared and removed the explicit static constructor.", Justification = "It is nicer in the static constructor as we can split it into different files.")]
    static Array() {
        Empty = System.Array.Empty<T>();
    }

}
