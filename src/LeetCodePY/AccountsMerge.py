from typing import List, Dict

class Solution:
    def accountsMerge(self, accounts: List[List[str]]) -> List[List[str]]:

        mail_dictionary: Dict[str, List[int]] = {}

        # hash all mails with their indexes
        for i, row in enumerate(accounts):
            for data in range(1, len(row)):
                if row[data] not in mail_dictionary:
                    mail_dictionary[row[data]] = []
                mail_dictionary[row[data]].append(i)

        visited = set()
        merge_results = []

        for i in range(len(accounts)):
            if i in visited:
                continue

            queue = [i]
            group = set()

            while queue:
                current = queue.pop()
                visited.add(current)

                if current in group:
                    continue

                group.add(current)

                for mail in range(1, len(accounts[current])):
                    indexes = mail_dictionary[accounts[current][mail]]

                    for nextIndex in indexes:
                        if nextIndex not in group:
                            queue.append(nextIndex)

            indices = list(group)
            name = accounts[indices[0]][0]
            merged = [name]
            merged_mails = set()

            for idx in indices:
                row = accounts[idx]
                for mail in range(1, len(row)):
                    merged_mails.add(row[mail])

            for i, letter in enumerate(sorted(merged_mails)):
                merged.append(letter)

            merge_results.append(merged)

        return merge_results