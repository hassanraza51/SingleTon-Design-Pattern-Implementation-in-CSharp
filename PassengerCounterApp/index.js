//document.getElementById("count-el").innerText = 6;
var counter = document.getElementById("count-el");
var button = document.getElementById("increment-btn");
let count = 0;
button.onclick = function () {
  count++;
  console.log(count);
  counter.innerHTML = count;
};
