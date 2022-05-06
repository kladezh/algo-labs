#include "task3.h"

void task3() {
    std::string string;
    std::cout << "������� ������: ";
    std::cin >> string;

    // ��������� ���� ��� ���� 'o'
    if (string.find("o") == std::string::npos) {
        std::cout << "������: � ����� ��� ���� \'o\'\n";
        exit(1);
    }

    // ����� ���-�� ���� ���� � �����
    size_t letters_count = string.size();

    size_t pos = 0;
    while ((pos = string.find("o", pos)) != std::string::npos) {
        string.insert(pos, " ");
        string.insert(pos + 2, " ");

        pos += 2;
    }

    std::cout << "������: \"" << string << "\"\n";
    std::cout << "���-�� ���� ����: " << letters_count << "\n";
}