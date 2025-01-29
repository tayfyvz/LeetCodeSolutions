#include <iostream>
#include <unordered_map>
using namespace std;

class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) 
    {
        unordered_map<char, int> freq;
        for (char c : magazine) {
            freq[c]++;
        }
        for (char c : ransomNote) {
            if (freq[c] > 0) {
                freq[c]--;
            }
            else {
                return false;
            }
        }
        return true;
    }
};