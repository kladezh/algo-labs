#include "task6.h"

bool is_vowel_letter(const char letter) {
    return (VOWEL_LETTERS.find(letter) != std::string::npos);
}

void print_sentense(const std::vector<std::string>& words) {
    for (const std::string& word : words) {
        std::cout << word << " ";
    }
}

void task6() {
    std::string string;
    std::cout << "������� �����������: ";
    std::getline(std::cin, string);

    std::stringstream sentense;
    sentense << string;

    std::vector<std::string> words;

    std::string temp_word;
    while (sentense >> temp_word) {
        words.push_back(temp_word);
    }

    // ��������� ��� �����
    size_t count_words = words.size();

    // ��������� ���-�� ����, ������������ � ������� �����
    size_t count_vowel_words = 0;
    for (const std::string& word : words) {
        if (is_vowel_letter(word.at(0)))
            count_vowel_words++;
    }

    // ������������� ����� � ���������� ������� �� ������ �����
    std::sort(words.begin(), words.end(), [](const std::string& a, const std::string& b) {
        return (a.at(0) < b.at(0));
        });

    // ����� ����� �������� �����
    std::string min_word = words.at(0);
    for (const std::string& word : words) {
        if (word.size() < min_word.size())
            min_word = word;
    }

    std::cout << "\n-------\n";
    std::cout << "���-�� ���� ����: " << count_words << "\n\n";
    std::cout << "���-�� ����, ������������ � ������� �����: " << count_vowel_words << "\n\n";
    std::cout << "����� �������� �����: " << min_word << "\n\n";
    std::cout << "�������������� �����:\n", print_sentense(words), std::cout << "\n";
}