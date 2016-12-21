'use strict';

function processData(input) {
    //Enter your code here
    var arr = [];

    arr = input.split("\n");
    var count = parseInt(arr.shift());
    var pairs = new Map();

    var given_arr = arr.slice(0, count);
    var test_arr = arr.slice(count, count * 2);

    for(let item of given_arr){
        let pair = item.split(' ');
        pairs.set(pair[0], pair[1]);
    }        
        

    for(let key of test_arr) {
        let pair = pairs.get(key);
        if(pair == undefined)
            console.log("Not found");
        else
            console.log(key + "=" + pair);
    }
}

var input = "3\nsam 99912222\ntom 11122222\nharry 12299933\nsam\nedward\nharry";
processData(input);
