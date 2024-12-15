#include <iostream>
#include <unordered_map>
#include <string>

int main() {
    std::unordered_map<std::string, std::string> lookup;

    lookup["animal"] = "Not a human";
    lookup["fish"] = "Not a human that swims";
    lookup["human"] = "Us";

    std::cout << "The definition of fish is " << lookup["fish"] << std::endl;

    std::unordered_map<int, std::string> employees;

    employees[95] = "Tim Corey";
    employees[28] = "Sue Storm";

    std::cout << "The employee with ID number 28 is " << employees[28] << std::endl;

    std::unordered_map<std::string, int> dayOfWeek;

    dayOfWeek["Wednesday"] = 4;
    dayOfWeek["Thursday"] = 5;
    dayOfWeek["Friday"] = 6;

    std::cout << "Wednesday is day number " << dayOfWeek["Wednesday"] << std::endl;

    return 0;
}

