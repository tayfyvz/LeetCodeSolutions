from collections import deque
from typing import  List

class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        if not board:
            return False
        if not word:
            return True

        for row in range(len(board)):
            for column in range(len(board[0])):
                if board[row][column] == word[0]:
                    if self.dfs(row, column, 0, word, board):
                        return True
        return False

    def dfs(self, row: int, column: int, index: int, word: str, board: List[List[str]]) -> bool:
        if row < 0 or len(board) <= row or column < 0 or len(board[0]) <= column or index >= len(word) or word[index] != \
                board[row][column]:
            return False

        if index == len(word) - 1:
            return True

        direction_list = [(1, 0), (-1, 0), (0, 1), (0, -1)]

        for x, y in direction_list:

            temp = board[row][column]
            board[row][column] = ""

            if self.dfs(row + x, column + y, index + 1, word, board):
                return True

            board[row][column] = temp

        return False