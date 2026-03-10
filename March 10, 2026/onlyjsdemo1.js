function test(){
    console.log("Hello world");
}


function test2(num1, num2){
    return (num1 + num2);
}

test();
let sum = test2(12, 30);
console.log(sum);

// using arrow functions
const testme = () => console.log("Hello world2");
let sum2 = (n1, n2) => (n1 + n2);
testme();
console.log(sum2(12, 42));

// variable.map(element) => print(element)

var arr = [10,20,30,40,50];
arr.map((ele) => console.log(ele));

// example 2
const numbers = [1,2,3,4,5];
const squares = numbers.map(value => value * value);
console.log(squares);

const people = [{id:1, name:"sam",country:"india"},{id:2, name:"samiya", country:"australia"}]

const ids = people.map(p => p.id);
const names = people.map( n => n.name);
console.log(ids);
console.log(names);


// filter function
// array.filter(ele => (condition))

var filtered = numbers.filter(x => x > 3);
console.log(filtered);