list = [6, 3]

half_number_list = [n / 2 for n in list]
half_number_list.append(1.5)
half_number_list.reverse()
half_number_list.pop(-1)

print(sum(half_number_list))