# Paytner Quiz at RubyKaigi 2022 Day 3

## Environments I have tried

macOS Monterey version 12.5

## Original Question

> What is output to standard output in the following Ruby code?
>
> - A: 2.5
> - B: 3
> - C: 4
> - D: 4.5

### Ruby Version

v3.1.2

### Code

``` ruby
array = [6, 3]

half_number_array = array.map{|number| number / 2}
half_number_array.push 1.5
half_number_array.reverse!
half_number_array.pop

p half_number_array.sum
```

### Answer at Ruby

A: 2.5

### Explanation at Ruby

See the following tweet.

<blockquote class="twitter-tweet"><p lang="ja" dir="ltr">今回の配列問題の答え、実行結果です🥰<a href="https://twitter.com/hashtag/rubykaigi?src=hash&amp;ref_src=twsrc%5Etfw">#rubykaigi</a><a href="https://twitter.com/hashtag/%E3%83%9A%E3%82%A4%E3%83%88%E3%83%8A%E3%83%BC%E3%82%AF%E3%82%A4%E3%82%BA?src=hash&amp;ref_src=twsrc%5Etfw">#ペイトナークイズ</a> <a href="https://t.co/0Klldghktq">https://t.co/0Klldghktq</a> <a href="https://t.co/ArtIFg6Pkw">pic.twitter.com/ArtIFg6Pkw</a></p>&mdash; ペイトナー株式会社（旧yup） (@paytner_) <a href="https://twitter.com/paytner_/status/1568482220633108480?ref_src=twsrc%5Etfw">September 10, 2022</a></blockquote>

<blockquote class="twitter-tweet"><p lang="ja" dir="ltr">整数/整数の挙動がミソ😂 <a href="https://t.co/sqNro9M5DM">https://t.co/sqNro9M5DM</a></p>&mdash; カズマール (@kazuman519) <a href="https://twitter.com/kazuman519/status/1568484351821885442?ref_src=twsrc%5Etfw">September 10, 2022</a></blockquote> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>

## Python Version

### Python Version

3.10.5

### Code

``` python
list = [6, 3]

half_number_list = [n / 2 for n in list]
half_number_list.append(1.5)
half_number_list.reverse()
half_number_list.pop(-1)

print(sum(half_number_list))
```

### Answer at Python

B: 3

(Correctly displayed as 3.0)

### Explanation at Python

In Python 3, the result of division between integers is a decimal.

## JavaScript Version

### Node.js Version

v16.16.0

### Code

``` JavaScript
const array = [6, 3];
const half_number_array = array.map(x => x / 2);
half_number_array.push(1.5);
half_number_array.reverse();
half_number_array.pop();

console.log(half_number_array.reduce((sum, element) => { return sum + element; }, 0));
```

### Answer at JavaScript

B:3

### Explanation at JavaScript

In JavaScript, `Number` type is used, but there is no distinction between integers and decimals.

## CSharp Version

### DotNet Version

v6.0.301

### Code

``` csharp
using System;
using System.Collections.Generic;
using System.Linq;

var list = new List<Double>{ 6, 3 };

List<Double> halfNumberList = list.Select(n => n / 2).ToList();
halfNumberList.Add(1.5);
halfNumberList.Reverse();
halfNumberList.RemoveAt(halfNumberList.Count - 1);

Console.Write(halfNumberList.Sum());
```

### Answer at CSharp

B: 3

### Explanation at CSharp

C# is statically typed.

If I try to add the number 1.5, which is a Double type number, to a list of type int, I get an error.

The solution would be to make the first list of type Double, but that would just compute a decimal number.

## Thanks

Thank you for the responsive questions!