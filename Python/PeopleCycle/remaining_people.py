class PeopleCycle:
    def __init__(self, amount_people):
        self.people = []
        self.people_next_gen = []

        self.amount_of_people = amount_people
        self.count_generation = 0

    def fill(self):
        for i in range(0, self.amount_of_people):
            self.people.append(i)

    def print_current(self):
        print(f"Current Generation: {self.count_generation}\n")

        for i in range(0, len(self.people)):
            print(f"Person Number {self.people[i]} still here.")

    def filter(self):
        while self.amount_of_people > 2:
            for i in range(0, len(self.people)):
                if i % 3 != 0:
                    self.people_next_gen.append(self.people[i])
                else:
                    self.amount_of_people -= 1

            self.people = self.people_next_gen
            self.people_next_gen = []
            self.count_generation += 1

    def run(self):
        self.fill()
        self.filter()
        self.print_current()


cycle = PeopleCycle(100000)
cycle.run()
