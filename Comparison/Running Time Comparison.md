# Running Time Comparison Results

## PrintNumbers.Print(1000) Function (Iteration vs Recursion)

|  Execution   | Iterations (ms) | Recursions (ms) |
|--------------|------------------|-----------------|
| 1            | 195.0387         | 258.5885         |
| 2            | 187.4933         | 189.5958         |

## SumOfNumbers.Calculate(1000) Function (Iteration vs Recursion)

| Execution    | Iterations (ms) | Recursions (ms) |
|--------------|------------------|-----------------|
| 1            | 3.4365           | 0.0761          |
| 2            | 2.9695           | 0.0757          |

## SumOfNumbers.Calculate(1000) Function (Tree vs Tail Recursion)

|  Execution   | Tree Recursion (ms) | Tail Recursion (ms) |
|--------------|---------------------|---------------------|
| 1            | 3.7941              | 0.0646              |
| 2            | 5.1724              | 0.6768              |

## Serarch Function on a set of 100,000 numbers (Linear Search vs Binary Search Iteration vs Binary Search Recursion)

|  Execution   | Linear (ms)         | Binary Search Iterative (ms) | Binary Search Recursive (ms) |Remarks |
|--------------|---------------------|------------------------------|------------------------------|-----------------------------|
| 1            | 1.9848              | 0.5169                       | 0.4617                       |Key selected towards the end |
| 2            | 7.0829              | 1.5388                       | 2.5231                       |Key selected in between      |