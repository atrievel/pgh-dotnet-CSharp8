# pgh-dotnet-CSharp8
Lightning talk for Pittsburgh's .NET User Group focusing on the new features of C# 8

## About me - Alec Trievel

I am a software developer at CEI focusing on .NET Core, Azure, Angular, and Salesforce development. C# is a part of "daily toolbelt," so it was important to me to learn some of the new features presented in the latest release.

## What's new in C# 8?

This is a brief list of new features released in C# 8 with .NET Core 3 and .NET Standard 2.1. There are a few basic [code snippet examples](https://github.com/atrievel/pgh-dotnet-CSharp8/tree/master/examples/) for you to reference, but I highly recommend viewing the [Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#) for more details. 

### Default interface members

See [DefaultInterfaceImplementation.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/DefaultInterfaceImplementation.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#default-interface-methods) for more exmaples and explanations.

### Pattern matching

See [PatternMatching.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/PatternMatching.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#more-patterns-in-more-places) for more exmaples and explanations.

### Using declarations

See [Using.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/Using.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations) for more exmaples and explanations.

### Static local functions

See [StaticLocalFunctions.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/StaticLocalFunctions.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#static-local-functions) for more exmaples and explanations.

### Nullable reference types

See [this Microsoft tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/nullable-reference-types) for a concrete example.

### Async streams

See [AsyncStreams.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/AsyncStreams.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#asynchronous-streams) for more exmaples and explanations.

### Indices and ranges

See [IndicesAndRange.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/IndicesAndRanges.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges) for more exmaples and explanations.

### Null-coalescing assignment 

See [IndicesAndRange.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/NullAssigmentOperator.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges) for more exmaples and explanations.

### Interpolated strings enhancement

The string interpolation operator ($) and verbatim operator (@) are now interchangeable. For example, both of lines below are valid C# 8 syntax: 

``` csharp
string interpolated = $@"This is an interpolated string.";
string interpolatedSwapped = @$"This is an interpolated string.";
```


### Null-Forgiving Operator

See [NullForgivingOperator.cs](https://github.com/atrievel/pgh-dotnet-CSharp8/blob/master/examples/NullForgivingOperator.cs) for examples.
See [the Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving) for more exmaples and explanations.

