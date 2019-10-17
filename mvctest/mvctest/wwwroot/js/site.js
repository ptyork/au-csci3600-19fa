//// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//// for details on configuring this project to bundle and minify static web assets.

//// Write your JavaScript code.
////alert('hello world');
////alert(prompt('gimme'));

//var a = 123;
//a += 123;

////alert(a)

//var b = "abc"; b = 123;
//console.log('before alert');
////alert(('' + b).charAt(1));
//console.log('after alert');

//var ar = ['abc', '123', 123, 1.2];
//console.log(typeof (ar));
//ar[6] = "Paul wuz here";
//ar['fourteen'] = "Ban me!!";
//for (var cnt = 0; cnt < ar.length; cnt++) {
//    console.log(ar[cnt]);
//}
//console.log(ar[4]);
//console.log(ar['fourteen']);
//console.log('after log');

//var dict = [];
//console.log(typeof (dict));
//dict['abc'] = 666;
//console.log(dict.abc);
//console.log(typeof (dict));
//console.log('after log2');

//dict["12"] = 'this is weird';

//function sayHi(name) {
//    console.log('HI THERE, ' + name + '. ALMOST TIME TO GO.');
//}
//sayHi('Paul');
//var sayHi = function (name) {
//    console.log("NOW IT IS TIME TO GO, " + name);
//} 
//sayHi('John');


a = 'abc'
console.log(typeof a)
b = true
console.log(typeof b)
c = 5
console.log(typeof c)
d = 5.5
console.log(typeof d)
e = [1, 2, 3]
console.log(typeof e)
console.log(Array.isArray(e))
f = { }
console.log(typeof f)

// JSON
g = {
    "name": "Bob",
    "address": "AI Brain",
    "grades": [10, 20, 30],
    "gradeobjects": [
        { assn: 'Exam 1', grade: 55}
    ]
}
console.log(g);
console.log(g.name);
console.log(g["address"]);

console.log(g.toString());

var jstr = JSON.stringify(g)
console.log(jstr);

var h = JSON.parse(jstr);
console.log(h.gradeobjects[0].assn);
