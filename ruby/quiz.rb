array = [6, 3]

half_number_array = array.map{|number| number / 2}
half_number_array.push 1.5
half_number_array.reverse!
half_number_array.pop

p half_number_array.sum