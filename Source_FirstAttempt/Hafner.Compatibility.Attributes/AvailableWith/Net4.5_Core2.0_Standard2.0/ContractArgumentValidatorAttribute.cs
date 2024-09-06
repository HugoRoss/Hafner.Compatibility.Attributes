namespace System.Diagnostics.Contracts;

using System;
using System.Diagnostics;

/// <summary>
/// Enables the factoring of legacy if-then-throw code into separate methods for reuse, and provides full control over thrown exceptions and arguments.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
[Conditional("CONTRACTS_FULL")]
public sealed class ContractArgumentValidatorAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the System.Diagnostics.Contracts.ContractArgumentValidatorAttribute class.
    /// </summary>
    public ContractArgumentValidatorAttribute() {
    }

}
