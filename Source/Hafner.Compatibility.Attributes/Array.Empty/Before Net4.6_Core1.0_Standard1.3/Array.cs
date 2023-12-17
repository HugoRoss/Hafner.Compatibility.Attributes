namespace Hafner.Compatibility.Attributes;

internal static partial class Array<T> {

    static Array() {
        Empty = new T[0];
    }

}
