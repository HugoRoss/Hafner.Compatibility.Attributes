// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Diagnostics.CodeAnalysis;

using static AttributeTargets;

/// <summary>Specifies that the attributed code should be excluded from code coverage information.</summary>
/// <remarks>Placing this attribute on a class or a structure excludes all the members of that class or structure from the collection of code coverage information.</remarks>
[AttributeUsage(Assembly | Class | Struct | Constructor | Method | Property | Event, Inherited = false, AllowMultiple = false)]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute {

    /// <summary>Gets or sets the justification for excluding the member from code coverage.</summary>
    public string? Justification { get; set; }

}
