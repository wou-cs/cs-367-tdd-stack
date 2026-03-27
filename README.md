# Week 1: Test-Driven Development with a Stack

This repository demonstrates **Test-Driven Development (TDD)** by building an array-backed stack data structure in C# using xUnit.

## Purpose

This is a live-coding companion for the Week 1 lecture in CS-367. It walks through implementing a fixed-capacity generic `Stack<T>` one test at a time, following the **red-green-refactor** cycle:

1. **Red** -- Write a failing test that defines the next piece of behavior.
2. **Green** -- Write the simplest code that makes the test pass.
3. **Refactor** -- Clean up the code while keeping all tests green.

## Following Along

The best way to study this project is to **read the commit history from the beginning**:

```bash
git log --oneline --reverse
```

Each commit represents a deliberate step in the TDD process. Walk through them in order to see how the implementation grows incrementally:

| Commit | What happens |
|--------|-------------|
| `37436ca` | Project scaffolding and initial `IStack<T>` interface |
| `caee1d7` | Adopt `Method_Condition_Expected` test naming convention |
| `e2ac9b8` | Test and implement `IsFull` |
| `9beab19` | Test and implement `Count` and `Capacity` |
| `954cc95` | Trivial `Push` -- just increment the count to pass the test |
| `2d331cd` | Full `Push` and `Pop` with array storage |
| `00f7c8e` | Boundary check -- `Pop` on an empty stack throws |

You can check out any commit to see the code at that point in time:

```bash
git checkout <commit-hash>
```

## Project Structure

```
StackSolution.sln
  Stack.Lib/          # Production code
    IStack.cs          # Interface with pre/post-conditions documented
    ArrayStack.cs      # Array-backed implementation
  Stack.Test/          # xUnit test project
    ArrayStackTests.cs # Tests that drove the implementation
```

## Building and Running Tests

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet test
```
