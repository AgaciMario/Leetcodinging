# Intuition
When I first approached this problem, my idea was to convert the array into an integer, add one to it, and then convert it back into an array. However, this is unnecessary and less efficient. A simpler and more direct way is to simulate the addition digit by digit, starting from the last position, just like we do manually on paper.

# Approach
We create an auxiliary array auxArr with the same length as digits, filled with zeros except for the last element, which is set to 1.
This array represents the number 1 that we are going to add.

Then, we iterate from the last index to the first index, summing the corresponding positions of digits and auxArr.

Example:
digits = [1, 2, 3]
auxArr = [0, 0, 1]
Result = [1, 2, 4]

### Possible cases during iteration
1. **No carry needed**
If digits[i] + auxArr[i] <= 9, simply update digits[i] with the sum.

2. **Carry needed**
If digits[i] + auxArr[i] > 9, set digits[i] to 0 and carry 1 to the next more significant position (auxArr[i - 1]).

3. **Overflow at the most significant digit**
If a carry occurs at index 0 (i - 1 < 0), it means we need to add a new digit at the front. Create a new array with size digits.Length + 1, set the first element to 1, and fill the rest with zeros.

4. **Carry to an existing previous position**
If i - 1 >= 0, set auxArr[i - 1] = 1 to propagate the carry to the next iteration.

# Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(n)$$
