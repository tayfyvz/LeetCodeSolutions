from typing import Dict, List, Tuple

class TimeMap:

    def __init__(self):
        self.__time_map: Dict[str, List[Tuple[str, int]]] = {}
    def binary_search(self, tuples : List[tuple[str, int]], timestamp: int) -> int:
        left = 0
        right = len(tuples) - 1

        while left <= right:

            mid = (left + right) // 2

            if tuples[mid][1] == timestamp:
                return mid
            elif tuples[mid][1] < timestamp:
                left = mid + 1
            else:
                right = mid - 1

        return left

    def set(self, key: str, value: str, timestamp: int) -> None:
        if key is None or value is None or timestamp < 0:
            return None

        if key not in self.__time_map:
            self.__time_map[key] = [(value, timestamp)]
            return None

        tuples = self.__time_map[key]

        if timestamp > tuples[-1][1]:
            tuples.append((value, timestamp))
            return None

        # Binary Search for insert
        insert_index = self.binary_search(tuples, timestamp)
        if insert_index < len(tuples) and tuples[insert_index][1] == timestamp:
            tuples[insert_index] = (value, timestamp)
        else:
            tuples.insert(insert_index, (value, timestamp))

    def get(self, key: str, timestamp: int) -> str:
        if key is None or timestamp < 0:
            return ""

        if key not in self.__time_map:
            return ""

        tuples = self.__time_map[key]
        index = self.binary_search(tuples, timestamp)

        if index < len(tuples) and tuples[index][1] == timestamp:
            return tuples[index][0]
        elif index > 0:
            return tuples[index - 1][0]
        else:
            return ""


# Your TimeMap object will be instantiated and called as such:
# obj = TimeMap()
# obj.set(key,value,timestamp)
# param_2 = obj.get(key,timestamp)