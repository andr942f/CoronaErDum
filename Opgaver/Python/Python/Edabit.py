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

    def profitable_gamble(prob, prize, pay):
        return prob * prize > pay

    def has_key(dictionary, key):
        return key in dictionary

    def has_bugs(buggy_code):
        # return "sad days" if buggy_code = True else "it's a good day"
        if buggy_code:
            return "sad days"
        else:
            return "it's a good day"

    def get_fillings(sandwich):
        return sandwich[1:-1]

    def pos_com(num):
        return 2**num

    def count_true(lst):
        return sum(lst)

    def football_points(wins, draws, losses):
        return (wins * 3) + (draws * 1) + (losses * 0)

    # Fix this broken code!
    def check_equals(lst1, lst2):
        return True if lst1 == lst2 else False

    def should_serve_drinks(age, on_break):
        return True if age > 17 and on_break == False else False

    def match(s1, s2):
        return s1.casefold() == s2.casefold()

    def find_index(lst, txt):
        return lst.index(txt)

    def modify_last(txt, n):
        return txt + txt[-1] * (n - 1)

    def can_nest(list1, list2):
        return max(list1) < max(list2) and min(list1) > min(list2)

    def has_same_bread(lst1, lst2):
        return lst1[0] == lst2[0] and lst1[-1] == lst2[-1]

    def parity(n):
        return "even" if n % 2 == 0 else "odd"

    def sort_nums_ascending(lst):
        return sorted(lst)

    def uhh(a, b, c):
        template = "Their names were: {}, {} and {}."
        return template.format(a, b, c)

    def char_count(txt1, txt2):
        return txt2.count(txt1)

    def yeah_nope(b):
        return "yeah" if b == True else "nope"

    def km_to_miles(km):
        return round(km * 0.621371, 5)

    def get_word(left, right):
        return left.capitalize() + right

    def same_case(txt):
        return txt.isupper() or txt.islower()

    def check_equality(a, b):
        return a is b

    def first_one(a, b=None, c=None, d=None):
        return a or b or c or d or 'not found'

    def reverse_case(txt):
        return txt.swapcase()

    def hash_plus_count(txt):
        return [txt.count('#'), txt.count('+')]

    def flip(y):
        return not y

    class BasicPlan:
        can_stream = True
        can_download = True
        num_of_devices = 1
        has_SD = True
        has_HD = False
        has_UHD = False
        price = '$8.99'

    class StandardPlan:
        can_stream = True
        can_download = True
        num_of_devices = 2
        has_SD = True
        has_HD = True
        has_UHD = False
        price = '$12.99'

    class PremiumPlan:
        can_stream = True
        can_download = True
        num_of_devices = 4
        has_SD = True
        has_HD = True
        has_UHD = True
        price = '$15.99'

# Write the classes for StandardPlan and PremiumPlan here!

    def wumbo(words):
        return words.replace("M", "W")

    def googlify(n):
        return "Go" * n + "gle" if n > 1 else "invalid"

    def number_syllables(word):
        return len(word.split('-'))

    def get_vote_count(votes):
        return votes.get("upvotes") - votes.get("downvotes")

    def reverse(lst):
        return lst[::-1]

    def negate(lst):
        return [-i for i in lst]

    def equilibrium(x):
        return "positive" if x > 0 else "negative" if x < 0 else True

    def word_lengths(lst):
        return [len(x) for x in lst]

    def additive_inverse(lst):
        return [-x for x in lst]

    def get_sequence(low, high):
        return list(range(low, high +1))

    def get_case(txt):
        return "upper" if txt.isupper() else "lower" if txt.islower() else "mixed"

    def get_multiplied_list(lst):
        return [x * 2 for x in lst]

    def sum_first_n_nums(lst, n):
        return sum(lst[0:n])

    def mean(nums):
        return round(sum(nums) / len(nums), 1) 

    def score_calculator(easy, med, hard):
        return "invalid" if any([x < 0 for x in [easy, med, hard]]) else sum([easy * 5, med * 10, hard * 20])

    def search(lst, item):
        return -1 if item not in lst else lst.index(item)

    def search(lst, item):
        return -1 if item not in lst else lst.index(item)

    def count_syllables(txt):
        return len(txt)//2

    def n_sided_shape(n):
        dicto = {
	    1:"circle",
	    2:"semi-circle",
	    3:"triangle",
	    4:"square",
	    5:"pentagon",
	    6:"hexagon",
	    7:"heptagon",
	    8:"octagon",
	    9:"nonagon",
	    10:"decagon" }
        
        return dicto[n]

    def reverse_capitalize(txt):
        return txt[::-1].upper()

    def say_hello_bye(name, num):
        return "Hello " + name.capitalize() if num == 1 else "Bye " + name.capitalize()

    def hello_world(num):
        return "Hello" if num % 5 else "World" if num % 3 else "Hello World"


    def md_format(word, style):
        styledisc = {
		"b": "**",
		"i": "_",
		"c": "`",
		"s": "~~"
	    }
        
        return styledisc[style] + word + styledisc[style]

    def greater_than_one(frac):
        return eval(frac) > 1
	