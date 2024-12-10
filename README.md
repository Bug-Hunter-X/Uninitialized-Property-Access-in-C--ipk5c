# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it's been assigned a value.  Uninitialized properties will default to their type's default value (0 for integers, null for strings, etc.), often leading to unexpected behavior or runtime errors.

The `bug.cs` file contains the buggy code, while `bugSolution.cs` provides a corrected version.

## How to reproduce
1. Compile and run `bug.cs`. Observe the result.
2. Compare with the corrected version in `bugSolution.cs`.