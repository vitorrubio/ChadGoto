# Chad Goto in C#


And why not?

![Chad goto](/chad-goto.jpg "Chad goto")


# Chad Goto in JS

Javascript does not have goto statement so we did a [gambiarra](https://www.urbandictionary.com/define.php?term=Gambiarra) to simulate a goto with a labeled loop

```
let intArray = [5, 10, 13, 20, 25, 39, 50]
let total = 0
let pos = 0

comeHere: while (true) {
  total += intArray[pos++]
  if (pos < intArray.length) {
    continue comeHere;
  }
	break;
}

console.log(total);
console.log(intArray.reduce((partialSum, a) => partialSum + a, 0));
```

