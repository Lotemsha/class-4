"use strict"

// Ex 1 Strings

let name = 'Mary ';
let activity = 'drink tea';
let bio = 'Our guest ' + name + activity + '.';

console.log(bio.length);

// Ex 2 char
const str = 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.'

let index = prompt (`Enter a number between 0 to ${str.length-1}`);

if (index >= str.length || isNaN(index))
{
  alert("Not a number in range")
}
else
  alert(str[index])
*/
// Ex 3 
// let str = prompt("Enter a string:");
// alert (str[str.length-2] + str[str.length-1])

  // Ex 4
const str = 'abcde'
let newStr = ""
for(let i = str.length-1; i >= 0; i--)
{
  newStr += str[i];
}
alert(newStr);
console.log(newStr);

// Ex 5
const str = "js"
 console.log(str.toUpperCase());

// Ex 6 includes()
const str = 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.';

let isInStr = prompt("Enter a word to see if the string contain it:");
console.log(str.includes(isInStr));
console.log(str.includes(isInStr, 20));

// Ex 7
let str = '1-2-3-4-5'
let element = '-'
while (str.includes(element))
  str = str.replace(element, '.')

  console.log(str);

// Ex 8
let str = '1-2-3-4-5'
console.log(str.replaceAll('-', '.'))

  // Ex 9 substring
  const str = 'sdfwe'
  console.log(str.substring(4,2)) //fw
 
  // Ex10
 const str = "I'm learning javascript!";
console.log(str.substring(4, 12) + " with substring")
 console.log(str.substr(4, 8) + " with substr")
 console.log(str.slice(4, 12) + " with slice")

 console.log(str.substring(13, str.length - 2) + " with substring")
 console.log(str.substr(13, 10) + " with substr")
 console.log(str.slice(13, -1) + " with slice")

 // Ex 11
 const str = 'http://www.notion.so/String-820cf1e906884d8fb9c02236fe1c6dcb/'
 console.log(str.indexOf('http://') === 0 ? true : false )

 // Ex 12
 const str = 'https://www.notion.html'
 const elemant = '.html'
 console.log(str.indexOf(elemant) === str.length-5 ? true : false)

// Ex 13
const str = 'ab cd cd cd ef';
console.log(str.lastIndexOf('cd')); // 9
console.log(str.lastIndexOf('cd', 8)); // 6

// Ex 14
const str = 'abcde';
console.log(str.startsWith('abc')); // true
console.log(str.startsWith('xxx')); // false
console.log(str.startsWith('bc', 1)); // true 

//Ex 15
const str = 'abcde';
console.log(str.endsWith('cde')); // true
console.log(str.endsWith('xxx')); // false
console.log(str.endsWith('bc', 3)); // true

// Ex16
let str = 'ab-cd-ef';
console.log(str.split('-')); //['ab', 'cd', 'ef']
console.log(str.split('-', 2)); // ['ab', 'cd']
console.log(str.split('')); //  ['a', 'b', '-', 'c', 'd', '-', 'e', 'f']
console.log(str.split('', 3)); //['a', 'b', '-']

// Ex 17
const person1 = { name: "יוסי", age: 30 };
const person2 = { name: "דנה", age: 25 };

if ((person1.name).localeCompare(person2.name) === -1)
  console.log(`${ person1.name}
לפני ${person2.name}`)
else
if ((person1.name).localeCompare(person2.name) === 1)
  console.log(`${ person2.name}
לפני ${person1.name}`)
else
  console.log(`names are are equal`)
