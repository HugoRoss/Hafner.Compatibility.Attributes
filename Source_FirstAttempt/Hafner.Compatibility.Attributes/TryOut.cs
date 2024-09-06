#define CONTRACTS_FULL

namespace System.Runtime.CompilerServices;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

internal class TryOut {

    [ContractArgumentValidatorAttribute()]
    public static void Foo() {
    }


}

public class Foo2 {

}
