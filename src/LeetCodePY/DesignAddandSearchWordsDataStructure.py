from collections import deque
from typing import Dict
class TrieNode:
    def __init__(self):
        self.children: Dict[str, TrieNode] = {}
        self.isEnd: bool = False
class WordDictionary:

    def __init__(self):
        self.__root: TrieNode = TrieNode()
    def addWord(self, word: str) -> None:
        if not word:
            return

        node = self.__root
        for c in word:
            if c not in node.children:
                node.children[c] = TrieNode()
            node = node.children[c]
        node.isEnd = True

    def search(self, word: str) -> bool:

        def dfs(node: TrieNode, index: int):
            if index == len(word):
                return node.isEnd

            if word[index] == '.':
                for child in node.children.values():
                    if dfs(child, index + 1):
                        return True

            if word[index] in node.children:
                return dfs(node.children[word[index]], index + 1)

            return False

        return dfs(self.__root, 0)
# Your WordDictionary object will be instantiated and called as such:
# obj = WordDictionary()
# obj.addWord(word)
# param_2 = obj.search(word)