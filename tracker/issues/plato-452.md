---
id: plato-452
title: TypeScript writer: emit standalone exported functions a bundler can trim, without patching Number.prototype
type: feature
status: idea
priority: "?"
effort: "?"
risk: "?"
area: plato
sprint: 
created: 2026-09-26
closed:
links: [plato-441, writers/Plato.TypeScriptWriter]
---

## Problem

The TypeScript writer emits one module, about 44,000 lines for the standard library, that installs functions on `Number.prototype` and other built-in prototypes. A library that wants to use two or three Plato functions has to ship all of it, and modifying built-in prototypes can clash with other code in the same page. Bundlers such as esbuild and Rollup can't remove unused functions from it.

gpu-accel (`C:\Users\cdigg\git\gpu-accel\plans\plato-evaluation.md`) would publish the generated TypeScript to npm as part of its own bundle. It needs plain exported functions, where importing one function pulls in only what that function calls.

Free functions can't be overloaded in TypeScript either, so this mode needs the same signature-based names as the WGSL writer ([plato-451](plato-451.md)) and would also avoid the dropped overloads described in [plato-441](plato-441.md).

## Done means

- [ ] The TypeScript writer has an output mode that emits an ES module of named exported functions and modifies no built-in prototype.
- [ ] A test bundle that imports only `Matrix4x4 * Vector4`, built with esbuild and minified, is under 10 KB.
- [ ] The existing mode keeps working, so the geometry-samples demo is unaffected.
