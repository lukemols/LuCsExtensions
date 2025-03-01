# LuCsExtensions

Welcome in LuCsExtensions! Use these functions to speed up the development of your programs with useful functionalities.

![license](https://badgen.net/static/License/MIT/yellow)
[![readme](https://badgen.net/static/README/📃/yellow)](https://github.com/lukemols/LuCsExtensions/blob/main/README.md)
![csharp](https://img.shields.io/badge/C%23-239120?style//for-the-badge&logo//c-sharp&logoColor//white)

---

## Getting started

This comprehensive collection of C# extensions seamlessly integrates with the existing classes, allowing you to concentrate on your code.

### Installation via CLI

Further information can be found on the [official Microsoft documentation](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-nuget-cli)

```sh
# Nuget

## Use latest 
NuGet\Install-Package LuCsExtensions

## Or choosing version
NuGet\Install-Package LuCsExtensions -Version 1.0.0

# Using dotnet (.NET CLI)

## Use latest
dotnet add package LuCsExtensions

## Or choosing version
dotnet add package LuCsExtensions --version 1.0.0
```

## Usage

Since these functions are C# extension methods, they become available directly on the types they extend. You only need to call them on instances of those types in your code, simplifying the syntax.

## Contents

### Array Extensions

- RandomValue(): Get a random value from an Array.

### Dictionary Extensions

- GetMultiple(): Returns an enumerable of type of the dictionary value which key matches one of the keys to select.

### Double Extensions

- IsNearlyEqual(): Checks if two doubles are nearly equal each others (with specified tolerance).
- IsNearlyZero(): Checks if a doubles is nearly equal to zero (with specified tolerance).

### Enum Extensions

- RandomEnumValue(): Returns a random value of the selected enum.

### IList Extensions

- IsValidIndex(): Check if passed index is valid for the list.
- Shuffle(): Executes a shuffle of the elements in the list.
- RandomValue(): Get a random value in selected list.|
- SortBy(): Sorts a list through a selected property.
- SortByDescending(): Descending sorts a list through a selected property.

### Random Extensions

- NextGaussian(): Returns a random number from a normal (or Gaussian) distribution.
- NextBool(): Returns a random boolean value.

### String Extensions

- FormatLocale(): Returns a string with lowered characters. Useful for locale id formatting.

### XElement Extensions

- Sort(): Sort attributes in XML element.
- RemoveEmptyElement(): Remove empty attributes in XML element.
