def tao_tuple_list(lst):
    return tuple(lst)
input_list = input("Nhập danh sách các số, cách nhau bằng dấu phẩy: ")
numbers = list(map(int,input_list.split(',')))
my_tuple =tao_tuple_list(numbers)
print("list: " ,numbers)
print("Tuple từ list:", my_tuple)