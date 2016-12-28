'use strict';

var SeparateMatrix = function (bigMatrix) {
    let x = bigMatrix.length;
    let y = bigMatrix[0].length;
    var sm = new Array();
    for (let ix = 0; ix <= x - 3; ix++) {
        for (let iy = 0; iy <= y - 3; iy++) {
            let small_matrix = new Array(3);
            small_matrix[0] = new Array(3);
            small_matrix[1] = new Array(3);
            small_matrix[2] = new Array(3);
            small_matrix[0][0] = bigMatrix[ix + 0][iy + 0];
            small_matrix[0][1] = bigMatrix[ix + 0][iy + 1];
            small_matrix[0][2] = bigMatrix[ix + 0][iy + 2];
            small_matrix[1][0] = bigMatrix[ix + 1][iy + 0];
            small_matrix[1][1] = bigMatrix[ix + 1][iy + 1];
            small_matrix[1][2] = bigMatrix[ix + 1][iy + 2];
            small_matrix[2][0] = bigMatrix[ix + 2][iy + 0];
            small_matrix[2][1] = bigMatrix[ix + 2][iy + 1];
            small_matrix[2][2] = bigMatrix[ix + 2][iy + 2];

            sm.push(Calculate(small_matrix));

        }
    }
    return sm;
}

var Calculate = function (matrix) {
    if (matrix.length == 3 && matrix[0].length == 3)
        return (matrix[0][0] + matrix[0][1] + matrix[0][2] + matrix[1][1] + matrix[2][0] + matrix[2][1] + matrix[2][2]);
    else
        return -999;
}

//process.stdin.resume();
//process.stdin.setEncoding('ascii');

//var input_stdin = "";
//var input_stdin_array = "";
//var input_currentline = 0;

//process.stdin.on('data', function (data) {
//    input_stdin += data;
//});

//process.stdin.on('end', function () {
//    input_stdin_array = input_stdin.split("\n");
//    main();
//});

//function readLine() {
//    return input_stdin_array[input_currentline++];
//}

/////////////// ignore above this line ////////////////////

function main() {
    let str = new Array(6);
    //str[0] = "1 1 1 0 0 0\n";
    //str[1] = "0 1 0 0 0 0\n";
    //str[2] = "1 1 1 0 0 0\n";
    //str[3] = "0 0 2 4 4 0\n";
    //str[4] = "0 0 0 2 0 0\n";
    //str[5] = "0 0 1 2 4 0\n";
    str[0] = "0 -4 -6 0 -7 -6\n";
    str[1] = "-1 -2 -6 -8 -3 -1\n";
    str[2] = "-8 -4 -2 -8 -8 -6\n";
    str[3] = "-3 -1 -2 -5 -7 -4\n";
    str[4] = "-3 -5 -3 -6 -6 -6\n";
    str[5] = "-3 -6 0 -8 -6 -7\n";

    var arr = new Array();
    for (let arr_i = 0; arr_i < 6; arr_i++) {
        arr[arr_i] = str[arr_i].split(' ');
        arr[arr_i] = arr[arr_i].map(Number);
    }

    var value = SeparateMatrix(arr);
    let sum = -999;
    for (let i of value)
        if (i > sum)
            sum = i;

    console.log(sum);
}

main();
