---
id: plato-453
title: Report functions outside the GPU subset as diagnostics instead of skipping them silently
type: feature
status: idea
priority: "?"
effort: "?"
risk: "?"
area: plato
sprint: 
created: 2026-09-26
closed:
links: [writers/Plato.GlslWriter/README.md]
---

## Problem

The GLSL writer emits 1,433 standard-library functions and skips 960, because they use lambdas, run-time-sized arrays, strings, or recursion (`writers/Plato.GlslWriter/README.md`). The skip happens inside the writer, so an author finds out only by reading the output, and the list has to be re-derived for every GPU backend (GLSL, CUDA, and a future WGSL writer in [plato-451](plato-451.md)).

A single check that decides whether a function can run on a GPU, and gives the reason when it can't, would give authors an error at the source line. The GPU writers could then share the check instead of each keeping its own rules. Raised while evaluating Plato for gpu-accel (`C:\Users\cdigg\git\gpu-accel\plans\plato-evaluation.md`).

## Done means

- [ ] A compiler pass marks each function as GPU-compatible or not and records the first reason (lambda, run-time-sized array, string, recursion, or a call to an incompatible function) with its source location.
- [ ] A CLI option lists the incompatible functions with their reasons, and an option turns the listed functions into errors for callers that require GPU compatibility.
- [ ] The GLSL writer uses the pass, and its emitted and skipped counts match what it produces today.
