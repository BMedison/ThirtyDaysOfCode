'use strict';

function processData(input) {
    //Enter your code here
    let value = parseInt(input);
    let bits = [];

    while(value > 0) {
        if(value % 2 == 0){
            bits.push(0);
        }else{
            bits.push(1);
        }
        value = value / 2 | 0;
    }

    bits = bits.reverse();

    let cur_count = 0;
    let prev_count = 0;
    for(let ch of bits) {
        if(ch == 0){
            if(cur_count > prev_count)
                prev_count = cur_count;
            cur_count = 0;
        }else
            ++cur_count;
    }
    if(cur_count <= prev_count)
        cur_count = prev_count;
    console.log(cur_count);
}

var input = 65535;
processData(input);
input = 439;
processData(input);

