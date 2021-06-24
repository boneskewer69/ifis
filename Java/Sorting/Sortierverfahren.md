# Sortierverfahren

## Bubble Sort

Wiederholt `Bubble(r)` aufrufen mit `r = [1, 4, 3, 7, 10, 2, 6, 5, 9, 8]`  
Array der Länge `n` (`n=10`)  
Indizes `0 ... n - 1`  
Bubble(r) geht das Array von links (0) bis Index `r - 1` durchgehen  
Jeweils zwei benachbarte Elemente betrachten und gegebenenfalls tauschen  

## Quicksort

`Quicksort (l, r)` // aufrufen mit `l = 0, r = n - 1`  
`if l < r`  
`pivotIndex = paritioniere(l, r)`  
`Quicksort(l, pivotIndex - 1)`  
`Quicksort(pivotIndex + 1, r)`  

`partitioniere(l, r)`  
`pivot = daten[r]`  
von links (l) aus nach Element (Index i) > pivot suchen  
von rechts (r) aus nach Element (Index j) < pivot suchen  
falls i < j: Elemente an i, j tauschen  
weitersuchen, bis j < i oder bei l oder r angekommen  
ggf. pivot mit Index i tauschen  
Index des Pivot-Elements zurückgeben  
