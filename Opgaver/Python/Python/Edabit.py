class Edabit(object):
    """description of class"""

    def hello():
        return "hello edabit.com"

    def addition(a, b):
        return a + b

    def next_edge(side1, side2):
        return (side1 + side2) - 1

    def get_first_value(number_list):
        return number_list[0]

    def calculate_exponent(num, exp):
        return num**exp

    def how_many_seconds(hours):
        return hours ** 60

    def find_perimeter(height, width):
        return 2 * (height + width)

    def convert(minutes):
        return minutes * 60

    def And(a, b):
        return a and b

    def to_int(txt):
        return int(txt)

    def to_str(num):
        return str(num)

    def animals(chickens, cows, pigs):
        return (chickens * 2) + (cows * 4) + (pigs * 4)

    def get_sum_of_elements(lst):
        return sum(lst)

    def concat(lst1, lst2):
        return lst1 + lst2

    def addition2(num):
        return num + 1

    def difference_max_min(lst):
        return max(lst) - min(lst)

    def convertsec(hours, minutes):
        return ((hours * 60 + minutes) * 60)

    def is_same_num(num1, num2):
        return num1 == num2

    def findLargestNum(nums):
        return max(nums)

    def remainder(x, y):
        return x % y

    def divisible(num):
        return num % 100 == 0

    def less_than_100(a, b):
        return a + b < 100

    def less_than_or_equal_to_zero(num):
        return num <= 0

    def squared(b):
        return b * b

    def tri_area(base, height):
        return (base * height) / 2

    def comp(txt1, txt2):
        return len(txt1) == len(txt2)

    def remainder(x, y):
        return x % y

    def find_perimeter(height, width):
        return (height + width) * 2

    def string_int(txt):
        return int(txt)

    def find_smallest_num(lst):
        return min(lst)

    def difference(nums):
        return max(nums) - min(nums)

    def divisible_by_five(n):
        return str(5) in str(n)

    def difference_max_min(lst):
        return max(lst) - min(lst)

    def k_to_k(n, k):
        return k**k == n

    def divisible(num):
        return str(00) in str(num)

    def divides_evenly(a, b):
        return isinstance(int(a / b), int)

    def divides_evenly(a, b):
        return a % b == 0

    def is_empty(s):
        return s == ""

    def frames(minutes, fps):
        return minutes * fps * 60

    def hello_name(name):
        return f"Hello {name}!"

    def eq(evaluate):
        return eval(evaluate)

    #Fix this code:
    def get_container(product):
        matches = {
	    "Bread" : "bag",
	    "Milk" : "bottle",
	    "Beer" : "bottle",
	    "Eggs" : "carton",
	    "Cerials" : "box",
	    "Candy" : "plastic",
	    "Cheese" : None
	    }
        return matches[product]

    def ctoa(char):
        return ord(char)

    def get_last_item(lst):
        return lst[-1]

    def is_plural(word):
        return word.endswith("s")

    def is_even(n):
        return n % 2 == 0

    def isEvenOrOdd(num):
        return "even" if num % 2 == 0 else "odd"

    def has_spaces(txt):
        return " " in txt

    def min_max(nums):
        return [min(nums), max(nums)]

    # def programmers(*args):
    #   return max(args) - min(args)

    def programmers(one, two, three):
        list = [one, two, three]
        return max(list) - min(list)

    def stack_boxes(n):
        return n * n

    def check(lst, el):
        return el in lst

    def num_to_dashes(num):
        return "-" * num

    def first_last(lst):
        return [lst[0], lst[-1]]

    def equation(s):
        return eval(s)
