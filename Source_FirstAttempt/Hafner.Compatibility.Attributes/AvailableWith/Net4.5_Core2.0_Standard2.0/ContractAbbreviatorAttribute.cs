namespace System.Diagnostics.Contracts;

using System;
using System.Diagnostics;

/// <summary>
/// Defines abbreviations that you can use in place of the full contract syntax.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
[Conditional("CONTRACTS_FULL")]
public sealed class ContractAbbreviatorAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the System.Diagnostics.Contracts.ContractAbbreviatorAttribute class.
    /// </summary>
    public ContractAbbreviatorAttribute() {
    }

}
