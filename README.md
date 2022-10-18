# Plato

Plato is a pure functional programming language that is strict subset of C# 8.0. 

# Implementation

The current Plato implementation is a [Source Generator](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) 
that enables Plato to work within Visual Studio by generating the necessary boiler-plate code, and that enforces the rules of the Plato language. 

Code written in Visual Studio using the Plato Source Generator is compatible with .NET Standard 2.0, making it applicable for usage on 
a large number of platforms. 

There are two other compilers in the works that use the same code base:

	1. An optimizing Plato to C# compiler
	2. A Plato to JavaScript compiler 

# Motivation 

Plato strives to tackle a few things:

1. Enforce immutability at the langauge level
2. Introduce an affine type system to track side-effects formally 
3. Generate assemblies that work across the widest number of platforms (e.g., Unity and .NET Framework)
4. Reduce boiler plate code 
5. Target web-browsers directly, without requiring the .NET runtime embedded  
6. Produce more efficient code while using functional programming paradigms 

# About the Plato to C# Optimizing Compiler

Even though Plato can be used as-is, within the Visual Studio environment by just adding some boiler plate, it is possible 
to generate heavily optimized C# by performing analysis of a Plato project. 

Many of these optimizations leverage the fact that functions are known to be side-effect free, and others are based on 
the knowledge that Plato programs make heavy use of functional paradigms, and are optimized for this. 

# Status 

I have developed an analyzer and several source generator prototypes. 
I am now using Plato to write a mathematics and geometry library for C# that is compatible with Unity 

# Final Words

I am always interested in feedback in any form. 
You can find me on twitter as [@cdiggins](https://twitter.com/cdiggins).
