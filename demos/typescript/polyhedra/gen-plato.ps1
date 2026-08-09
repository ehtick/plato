# Regenerate plato.g.ts (and its browser-ready plato.g.js) from the forward stdlib.
# Run from this folder. Requires the geometry-samples node_modules for esbuild.
$ErrorActionPreference = 'Stop'
$here = Split-Path -Parent $MyInvocation.MyCommand.Path
$repo = Resolve-Path (Join-Path $here '..\..\..')

dotnet run --project (Join-Path $repo 'src\Plato.CLI') -c Release -- `
    (Join-Path $repo 'stdlib\foundation') (Join-Path $repo 'stdlib\geometry') `
    --out=$here --typescript
if ($LASTEXITCODE -ne 0) { throw "Plato.CLI failed" }

& (Join-Path $repo 'demos\typescript\geometry-samples\node_modules\.bin\esbuild.cmd') `
    (Join-Path $here 'plato.g.ts') --outfile=(Join-Path $here 'plato.g.js') --format=esm
if ($LASTEXITCODE -ne 0) { throw "esbuild failed" }

Write-Host "regenerated plato.g.ts + plato.g.js"
