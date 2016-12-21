'use strict';

function processData(input) {
    //Enter your code here
    var arr = [];

    arr = input.split("\n");
    var count = arr.shift();
    var pairs = new Map();
    for(let i = 0; i < count; i++) {
        let pair = arr.shift().split(' ');
        pairs.set(pair[0], pair[1]);
    }

    for(let i = 0; i < count; i++) {
        let key = arr.shift();
        let pair = pairs.get(key);
        if(pair == undefined)
            console.log("Not found");
        else
            console.log(key + "=" + pair);
    }
}

var input = "3\nsam 99912222\ntom 11122222\nharry 12299933\nsam\nedward\nharry";
processData(input);
