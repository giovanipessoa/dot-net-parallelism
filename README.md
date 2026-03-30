# .NET Parallelism Benchmark 🚀

This project is a performance laboratory built with **C#** and **.NET 8** to demonstrate the practical differences between **Sequential** and **Parallel** processing using the **Task Parallel Library (TPL)**.

[![GitHub license](https://img.shields.io/github/license/giovanipessoa/dot-net-parallelism)](https://github.com/giovanipessoa/dot-net-parallelism/blob/main/LICENSE)
[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)

## 📖 Scenario

The application performs a stress test by reading a heavy PDF file (`CleanCode.pdf`, ~66MB) multiple times. This allows us to observe how the operating system and hardware (CPU/Disk) behave when handling simultaneous I/O requests.



## 🛠️ Features

- **Sequential Execution:** Uses a standard `for` loop to read the file one by one.
- **Parallel Execution:** Uses `Parallel.ForEach` to distribute the load across all available CPU cores.
- **Performance Metrics:** Precise timing using the `Stopwatch` class.
- **Real-time Feedback:** Visual console indicators for each completed task.

## 🚀 How to Run

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/giovanipessoa/dot-net-parallelism.git](https://github.com/giovanipessoa/dot-net-parallelism.git)
