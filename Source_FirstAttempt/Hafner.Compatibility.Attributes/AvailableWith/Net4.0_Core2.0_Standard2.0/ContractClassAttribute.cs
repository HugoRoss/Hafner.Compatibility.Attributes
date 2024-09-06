#nullable enable

namespace System.Diagnostics.Contracts;

using System;
using System.Diagnostics;

/// <summary>Specifies that a separate type contains the code contracts for this type.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[Conditional("CONTRACTS_FULL")]
[Conditional("DEBUG")]
public sealed class ContractClassAttribute : Attribute {

    /// <summary>
    /// Initializes a new instance of the <see cref="ContractClassAttribute"/> class.
    /// </summary>
    /// <param name="typeContainingContracts">The type that contains the code contracts for this type.</param>
    public ContractClassAttribute(Type typeContainingContracts) {
        TypeContainingContracts = typeContainingContracts;
    }

    /// <summary>
    /// Gets the type that contains the code contracts for this type.
    /// </summary>
    /// <remarks>The type that contains the code contracts for this type.</remarks>
    public Type TypeContainingContracts { get; }

}
