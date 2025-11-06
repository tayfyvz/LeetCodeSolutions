from typing import List

class Solution:
    def findAnagrams(self, s: str, p: str) -> List[int]:
        if not s or not p:
            return []

        freq = {}
        window = {}
        result = []
        left = 0
        right = 0

        for c in p:
            freq[c] = freq.get(c, 0) + 1

        while right < len(s):
            char = s[right]
            window[char] = window.get(char, 0) + 1

            if right - left >= len(p):
                l_char = s[left]
                window[l_char] -= 1
                if window[l_char] == 0:
                    del window[l_char]
                left += 1

            if right - left == len(p) - 1 and window == freq:
                result.append(left)

            right += 1

        return result