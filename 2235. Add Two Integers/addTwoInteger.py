'''
Time complexity: O(1) (constant time)
Space complexity: O(1) (constant memory)
'''
# Adding self makes it a non-static (instance) method, thus you need to create an instance of the class
class Solution:
    def sum(self, num1: int, num2: int) -> int: 
        return num1 + num2

sol = Solution()
print(sol.sum(1, 2))    


# Removal of self does NOT automatically make it static.
# It just becomes a regular function inside the class namespace
# To make it truly static, you should use @staticmethod.
class Solution:
    def Sum(num1: int, num2: int) -> int:
        return num1 + num2

print(Solution.Sum(1, 2))


# To make it a true static method (no self, callable on class directly), use @staticmethod
class Solution:
    @staticmethod
    def Sum(num1, num2):
        return num1 + num2
        
# With @staticmethod, you can call it both from the class and from an instance
sol = Solution()
print(Solution.Sum(1, 2))  
print(sol.Sum(1, 2))
        
