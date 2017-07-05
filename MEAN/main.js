var x = [3,5,"Dojo", "rocks", "Michael", "Sensei"];
for(var item in x){
  console.log(x[item]);
}
x.push(100);
x = ["hello", "world", "JavaScript is Fun"];
console.log(x);
var sum = 0;
for(var i = 0; i <= 500; i++){
  sum += i;
}
console.log(sum);
function findMin(y){
  var min = y[0];
  for(var i = 1; i < y.length; i++){
    if(y[i] < min){
      min = y[i];
    }
  }
  return(min);
}
console.log(findMin([1, 5, 90, 25, -3, 0]));
function findAvg(a){
  var sum = 0;
  for(var i = 0; i < a.length; i++){
    sum += a[i];
  }
  sum /= a.length;
  return sum;
}
console.log(findAvg([1, 5, 90, 25, -3, 0]));
var newNinja = {
 name: 'Jessica',
 profession: 'coder',
 favorite_language: 'JavaScript', //like that's even a question!
 dojo: 'Dallas'
}
for(item in newNinja){
  console.log(item + " " + newNinja[item]);
}
