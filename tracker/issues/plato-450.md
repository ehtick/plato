---
id: plato-450
title: Add an unsigned 32-bit integer type with wrapping arithmetic, multiply-high, and bit operations
type: feature
status: idea
priority: "?"
effort: "?"
risk: "?"
area: plato
sprint: 
created: 2026-09-26
closed:
links: [plato-271, plato-341]
---

## Problem

Plato's only integer type is `Integer`, which is signed. GPU code and counter-based random number generators need an unsigned 32-bit integer whose arithmetic wraps around at 2^32, plus the high 32 bits of a 32-by-32-bit multiply, logical shifts, and bitwise operators. Without it, Philox-4x32 (the random number generator used by gpu-accel and by most GPU libraries), radix sort keys, and histogram bins can't be written in Plato.

Found while evaluating Plato for gpu-accel (`C:\Users\cdigg\git\gpu-accel\plans\plato-evaluation.md`). There, the missing unsigned type is the most likely reason the Plato experiment would fail.

This overlaps [plato-271](plato-271.md), which asks whether Plato should have fixed-size numeric types at all, and [plato-341](plato-341.md), which proposes an 8-bit `Byte`. The three should share one decision about sized integer types.

## Done means

- [ ] The standard library declares an unsigned 32-bit type with wrapping add, subtract, and multiply, a multiply-high, logical shifts, and bitwise operators.
- [ ] The C#, TypeScript, and GLSL writers lower it (in TypeScript through `Math.imul` and `>>> 0`; in GLSL as `uint`).
- [ ] One Philox-4x32 round written in Plato matches the published Random123 known-answer vectors on each of those backends.
