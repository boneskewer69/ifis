class HolidayCycle:
    def __init__(self, amount_people):
        self.people = []
        self.people_next_gen = []

        self.amount_of_people = amount_people

        self.count_generation = 0

    def fill(self):
        for i in range(0, len(self.people)):
            self.people.append(i)

    def print_leftover(self):
        for i in range(0, len(self.people)):
            print(self.people[i])

    def filter(self):
        for i in range(0, len(self.people)):
            if i % 3 != 0:
                self.people_next_gen.append(self.people[i])
            else:
                self.amount_of_people -= 1

        self.people = self.people_next_gen
        self.people_next_gen = []

    def run(self):
        self.fill()
        self.filter()
        self.print_leftover()


cycle = HolidayCycle(10)
cycle.run()
