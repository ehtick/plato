---
id: plato-449
title: TypeScript writer computes Number in 64-bit floats, but SEMANTICS.md says Number is 32-bit
type: bug
status: idea
priority: "?"
effort: "?"
risk: "?"
area: plato
sprint: 
created: 2026-09-26
closed:
links: [plato-271, docs/SEMANTICS.md]
---

## Problem

`docs/SEMANTICS.md` (section 1 and the non-features list) says `Number` is a 32-bit float in every current backend. The TypeScript writer maps `Number` to a plain JavaScript number, which is a 64-bit float, and never calls `Math.fround` (a search of `writers/` finds no use of it). So `1.0 / 3.0` computed by the generated TypeScript differs in its last bits from the same expression in the C# or GLSL output, and longer computations drift further apart.

Found while evaluating Plato as the source of shared GPU and CPU math for gpu-accel (`C:\Users\cdigg\git\gpu-accel\plans\plato-evaluation.md`). gpu-accel requires the CPU version of each GPU function to agree bit for bit with the GPU result, and it can't adopt generated TypeScript until this is fixed.

[plato-271](plato-271.md) asks what `Number` should mean. Until that decision changes the spec, the writer should follow it.

## Done means

- [ ] Every `Number` arithmetic operation and math intrinsic in the TypeScript output rounds its result to 32 bits (`Math.fround`, or `Float32Array` where that is simpler).
- [ ] A conformance test runs a set of `Number` functions (at least arithmetic, `Sqrt`, and a 4x4 matrix times vector) on 10,000 random inputs through the C# and TypeScript outputs and finds zero bit differences.
- [ ] `docs/SEMANTICS.md` and the TypeScript writer's README agree on what `Number` means in TypeScript.
