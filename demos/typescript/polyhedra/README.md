# Polyhedra studio — the Plato stdlib's Conway operators in TypeScript

A browser demo of the forward stdlib's polyhedra vocabulary
([`stdlib/geometry/polyhedra.library.plato`](../../../stdlib/geometry/polyhedra.library.plato))
compiled to TypeScript and rendered in raw WebGL2. All geometry — the five
Platonic seeds, the six Conway operators (dual, ambo, truncate, expand, snub,
bevel), and through them all thirteen Archimedean and all thirteen Catalan
solids — is computed at run time by the generated `plato.g.ts`; the page's own
JavaScript only reads the results into GPU buffers.

## What it demonstrates

- **Plato → TypeScript codegen on the real stdlib** (`stdlib/foundation` +
  `stdlib/geometry`, not a curated demo subset). This is the demo that drove the
  TypeScript writer fixes of 2026-08: constructor call sites, target-typed tuple
  returns, truncating integer division, type-level (`_`-receiver) statics,
  per-type field-vs-method call sites, and a memoizing `Arr`.
- **Conway operator chains**: stack up to six operators over a seed and read the
  resulting notation (`taC`, `dsD`, ...). The catalog dropdown jumps to any named
  solid via its canonical program and sets the shrink/twist sliders to the
  constants that make it uniform.
- **Face analytics as colors**: faces colored by side count, by area (computed
  through the stdlib's Newell `VectorArea`), by normal, or plain — plus a live
  V/E/F/Euler panel with a face histogram.
- **Gratify** renders the control panel (vendored build shared with
  [`demos/glsl`](../../glsl)).

## Run

Serve the `demos/` folder (the page reaches into `../glsl/vendor/` for Gratify):

```bat
cd demos
python -m http.server 5390
```

then open <http://localhost:5390/typescript/polyhedra/>.

## Regenerate

After editing the stdlib or the TypeScript writer:

```powershell
./gen-plato.ps1
```

`plato.g.ts` is the generated TypeScript (checked in, ~35k lines);
`plato.g.js` is its esbuild transpile that the page actually imports (checked
in so the demo is static-servable). Type-checking the generated file still
reports structural-typing gaps (see the writer README's known limitations); the
demo consumes it via transpile-only, and the smoke gate is behavioral: all 31
named solids must produce their textbook V/E/F counts.
