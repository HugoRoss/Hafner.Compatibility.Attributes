namespace Hafner.Compatibility.Attributes;

internal static partial class Array<T> {

    static Array() {
        Empty = System.Array.Empty<T>();
    }

}
