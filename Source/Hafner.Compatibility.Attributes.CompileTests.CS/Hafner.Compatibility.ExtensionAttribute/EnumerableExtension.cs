namespace Hafner.Compatibility.ExtensionAttribute.CompileTest.CS;

using System.Collections;

public static class EnumerableExtension {

    public static bool HasElements(this IEnumerable? enumerable) {
        if (enumerable is null) return false;
        return enumerable.GetEnumerator().MoveNext();
    }

}
