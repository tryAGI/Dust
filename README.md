# Dust

[![Nuget package](https://img.shields.io/nuget/vpre/Dust)](https://www.nuget.org/packages/Dust/)
[![dotnet](https://github.com/tryAGI/Dust/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Dust/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Dust)](https://github.com/tryAGI/Dust/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Dust OpenAPI specification](https://dust.tt/swagger.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Dust;

using var client = new DustClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Dust/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Dust/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
