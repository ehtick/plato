---
id: plato-451
title: Add a WGSL writer
type: feature
status: idea
priority: "?"
effort: "?"
risk: "?"
area: plato
sprint: 
created: 2026-09-26
closed:
links: [plato-235, writers/Plato.GlslWriter]
---

## Problem

WebGPU accepts only WGSL shaders. Plato has a GLSL ES 3.00 writer, but no WGSL writer, so its GPU subset can't reach WebGPU. gpu-accel (`C:\Users\cdigg\git\gpu-accel\plans\plato-evaluation.md`) would use one to generate its element-level math (vector and matrix functions, Philox rounds) from Plato.

WGSL, like GLSL, has no function overloading. The GLSL writer currently resolves same-name overloads by emission order, which [plato-235](plato-235.md) describes as a bug. A WGSL writer should instead derive each function's name from its full signature, so every overload survives and the names don't change between builds.

The evaluation suggests starting from a copy of `writers/Plato.GlslWriter` and treating it as a failed approach if the writer needs more than about 1,500 lines before it emits clean code.

## Done means

- [ ] A WGSL writer emits the same standard-library functions the GLSL writer emits today, apart from any it reports as unsupported.
- [ ] Every emitted module passes validation by Tint (through Dawn) or naga.
- [ ] Overloads get names derived from their parameter types, and a test shows two overloads of one name both reach the output.
- [ ] `Matrix4x4 * Vector4` run through the generated WGSL on a GPU agrees bit for bit with the C# output on 10,000 random inputs.
