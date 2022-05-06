#include <iostream>

bool do_divide(const int divisible, const int divider) {
    return (divisible % divider == 0);
}

bool is_simple(const int number) {
    for (int i = 2; i < number; i++) {
        if (do_divide(number, i)) {
            return false;
        }
    }

    return true;
}

int main() {
    setlocale(LC_ALL, "rus");

    int number;
    std::cout << "Введите натуральное число, большее единицы: ";
    std::cin >> number;

    if (number < 1) {
        std::cout << "Ошибка: число должно быть больше единицы...";
        return 1;
    }

    // найти наибольший простой делитель
    int max_simple_div = 1;
    for (int x = 1; x <= number / 2; x++) {
        if (is_simple(x) && do_divide(number, x)) {
            max_simple_div = x;
        }
    }

    std::cout << "Наибольшой простой делитель числа (" << number << "): " << max_simple_div << "\n";

    return 0;
}
