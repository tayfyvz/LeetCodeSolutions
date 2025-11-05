from typing import List

class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:

        if not matrix:
            return []

        visited = set()
        row = 0
        column = 0
        result = []

        visited.add((row, column))
        result.append(matrix[row][column])

        while True:
            moved = False

            while column + 1 < len(matrix[0]) and (row, column + 1) not in visited:
                column += 1
                visited.add((row, column))
                result.append(matrix[row][column])
                moved = True

            while row + 1 < len(matrix) and (row + 1, column) not in visited:
                row += 1
                visited.add((row, column))
                result.append(matrix[row][column])
                moved = True

            while column - 1 >= 0 and (row, column - 1) not in visited:
                column -= 1
                visited.add((row, column))
                result.append(matrix[row][column])
                moved = True

            while row - 1 >= 0 and (row - 1, column) not in visited:
                row -= 1
                visited.add((row, column))
                result.append(matrix[row][column])
                moved = True

            if not moved:
                break

        return result

