#include "task3.h"

void task3() {
    std::string string;
    std::cout << "Введите строку: ";
    std::cin >> string;

    // проверить если нет букв 'o'
    if (string.find("o") == std::string::npos) {
        std::cout << "Ошибка: в слове нет букв \'o\'\n";
        exit(1);
    }

    // найти кол-во всех букв в слове
    size_t letters_count = string.size();

    size_t pos = 0;
    while ((pos = string.find("o", pos)) != std::string::npos) {
        string.insert(pos, " ");
        string.insert(pos + 2, " ");

        pos += 2;
    }

    std::cout << "Строка: \"" << string << "\"\n";
    std::cout << "Кол-во всех букв: " << letters_count << "\n";
}