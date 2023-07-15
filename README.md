# Plato

Plato is an efficient and fun programming language inspired by JavaScript, C#, and Haskell. 
Plato is designed to be easy to teach and learn while being efficient and robust enough for 
commercial coding, particularly in the realm of 3D graphics. 

# Backstory 

I have been writing 3D graphics code in various languages for over 15 years, and find the same algorithms written over and over 
again to varying degrees of correctness and efficiency. 3D math algorithms rarely change, so ultimately the problem lies in the 
tools and languages we have available to use.

I set out to design a language that I could use to write a comprehensive 3D graphics library that could be translated automatically 
into different targets, such as JavaScript, C#, C++, and even shader languages like GLSL. 

I believe that a carefully designed modern programming language can be robust and easy to use for both newcomers and professionals. 
I also believe that languages and tools with quick feedback and graphics are the best way to introduce programming concepts to new 
programmers.    

# About Plato 

Plato is a statically typed compiled functional language that looks like a dynamic scripting language.
Type annotations are optional, except when defining new types or concepts. 

Plato behaves like an object oriented language in that you can use fluent (aka method chaining) syntax.
In other words any defined function can be invoked by writing the first argument followed by a "." 
then the rest of the arguments. `Clamp(x, min, max)` can be invoked as `x.Clamp(min, max)`.

If a function does not require additional arguments then the `()` can be omitted. This means that any
function with only one parameter (e.g. `Cos(x: Number)`) can be invoked as if it was a property: `x.Cos`.

## Functions and Modules

Functions are organized in groups called modules. A module has no state or variables. 

    Note: Plato functions are not methods. They have no implicit "this" parameter.   

Plato functions can be defined with or without type declarations. If type declarations are omitted then the type is inferred.

For some [examples of functions and modules see the standard library](https://github.com/cdiggins/plato/blob/main/PlatoStandardLibrary/modules.plato).

## Types and Fields

A type assigns a name to a set of fields (member variables). 
Types do not contain functions. A type may `implement` one or more concepts. 
When a type declares that it implements a concept, it will support all functions 
defined within the concept. 

For some [examples of types see the standard library](https://github.com/cdiggins/plato/blob/main/PlatoStandardLibrary/types.plato).

## Concepts 

A concept is a set of fields and functions that describe a particular type. They are similar to 
interfaces, traits, protocols, and mixins. A type that "implements" a concept must have the fields 
declared in the concept. The functions within a concept are automatically implemented for the types that declare that they 
implement the concept.  

Within a concept the `Self` keyword refers to the type of the implementing type. 

For some [examples of concepts see the standard library](https://github.com/cdiggins/plato/blob/main/PlatoStandardLibrary/concepts.plato).

# Feedback

I am always interested in feedback in any form. You can find me on twitter as [@cdiggins](https://twitter.com/cdiggins) or mail me at [cdiggins@gmail.com](mailto:cdiggins@gmail.com).
