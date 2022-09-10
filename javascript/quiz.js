const array = [6, 3];
const half_number_array = array.map(x => x / 2);
half_number_array.push(1.5);
half_number_array.reverse();
half_number_array.pop();

console.log(half_number_array.reduce((sum, element) => { return sum + element; }, 0));