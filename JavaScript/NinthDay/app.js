'use strict';

var factorial = function(value) {
    if(value < 1)
        return 1;
    return value * factorial(value - 1);
}

function processData(input) {
    //Enter your code here

    let value = parseInt(input);
    console.log(factorial(value));

}

var input = "3";
processData(input);
