function reverseANumber(number) {
    var reverseNumber = 0;
    var x = 0;
    while(number) {
        x = number % 10;
        reverseNumber = reverseNumber*10 + x;
        number = number/10|0;
    }
    return reverseNumber;
}

function beautifulDaysAtTheMovies(startDay, endDay, k) {
    var beautifulDaysCounter = 0;
    for (var i = startDay; i<=endDay; i++) {
        var reverseNumber = reverseANumber(i);
        if(Math.abs(reverseNumber-i)%k==0) {
            beautifulDaysCounter++;
        }
    }
    return beautifulDaysCounter;
}

var result = beautifulDaysAtTheMovies(20,23,6);
console.log(result);