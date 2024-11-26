using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submit_Exercise
{
    internal class EX_08
    {
        static void Main8()
        { 
                Console.Write("Nhap mot chuoi: ");
                string input = Console.ReadLine();

                // 1. In chuỗi đã nhập
                Console.WriteLine("\n1. Chuoi ban da nhap la:");
                Console.WriteLine(input);

                // 2. Tìm độ dài của chuỗi mà không dùng hàm thư viện
                int length = FindLength(input);
                Console.WriteLine($"\n2. Do dai cua chuoi la: {length}");

                // 3. Tách các ký tự riêng lẻ
                Console.WriteLine("\n3. Cac ky tu trong chuoi la:");
                foreach (char c in input)
                {
                    Console.WriteLine(c);
                }

                // 4. In chuỗi theo thứ tự ngược
                Console.WriteLine("\n4. Chuoi nguoc la:");
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();

                // 5. Đếm tổng số từ trong chuỗi
                int wordCount = CountWords(input);
                Console.WriteLine($"\n5. Tong so tu trong chuoi là: {wordCount}");

                // 6. So sánh 2 chuỗi không dùng thư viện
                Console.Write("\n6. Nhap chuoi thu hai de so sanh: ");
                string secondInput = Console.ReadLine();
                bool areEqual = CompareStrings(input, secondInput);
                Console.WriteLine(areEqual ? "Hai chuoi giong nhau." : "Hai chuoi khac nhau.");

                // 7. Đếm số chữ cái, chữ số và ký tự đặc biệt
                CountCharacters(input);

                // 8. Đếm số nguyên âm và phụ âm
                CountVowelsAndConsonants(input);

                // 9. Kiểm tra một chuỗi con
                Console.Write("\n9. Nhap chuoi con can kiem tra: ");
                string subStr = Console.ReadLine();
                bool contains = input.Contains(subStr);
                Console.WriteLine(contains ? $"Chuoi '{subStr}' co trong chuoi chinh." : $"Chuoi '{subStr}' khong co trong chuoi chinh.");

                // 10. Tìm vị trí đầu tiên của chuỗi con
                int position = input.IndexOf(subStr);
                Console.WriteLine(position >= 0 ? $"Chuoi con xuat hien tai vi tri: {position}" : "Chuoi con khong co trong chuoi chinh.");

                // 11. Kiểm tra một ký tự có phải là chữ cái hay không, và kiểm tra chữ hoa/thường
                Console.Write("\n11. Nhap mot ky tu: ");
                char character = Console.ReadKey().KeyChar;
                Console.WriteLine();
                CheckCharacterType(character);

                // 12. Đếm số lần xuất hiện của chuỗi con
                int countSub = CountSubstringOccurrences(input, subStr);
                Console.WriteLine($"12. Chuoi con '{subStr}' xuat hien {countSub} lan trong chuoi chinh.");

                // 13. Thêm chuỗi con trước lần xuất hiện đầu tiên
                Console.Write("\n13. Nhap chuoi con muon them: ");
                string insertStr = Console.ReadLine();
                string modifiedString = InsertSubstringBefore(input, insertStr, subStr);
                Console.WriteLine($"Chuoi sau khi them: {modifiedString}");
            }

            // Hàm tính độ dài chuỗi không dùng thư viện
            static int FindLength(string s)
            {
                int length = 0;
                foreach (char c in s)
                {
                    length++;
                }
                return length;
            }

            // Hàm đếm từ trong chuỗi
            static int CountWords(string s)
            {
                string[] words = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }

            // Hàm so sánh 2 chuỗi không dùng thư viện
            static bool CompareStrings(string str1, string str2)
            {
                if (str1.Length != str2.Length) return false;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            // Hàm đếm chữ cái, chữ số và ký tự đặc biệt
            static void CountCharacters(string s)
            {
                int alphabets = 0, digits = 0, specialChars = 0;

                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                        alphabets++;
                    else if (char.IsDigit(c))
                        digits++;
                    else
                        specialChars++;
                }

                Console.WriteLine($"\n7. So chu cai: {alphabets}");
                Console.WriteLine($"So chu so: {digits}");
                Console.WriteLine($"So ky tu dac biet: {specialChars}");
            }

            // Hàm đếm nguyên âm và phụ âm
            static void CountVowelsAndConsonants(string s)
            {
                int vowels = 0, consonants = 0;
                foreach (char c in s.ToLower())
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else if (char.IsLetter(c))
                        consonants++;
                }

                Console.WriteLine($"\n8. So nguyen am: {vowels}");
                Console.WriteLine($"So phu am: {consonants}");
            }

            // Hàm kiểm tra loại ký tự
            static void CheckCharacterType(char c)
            {
                if (char.IsLetter(c))
                {
                    Console.WriteLine("Ky tu la mot chu cai.");
                    if (char.IsUpper(c))
                        Console.WriteLine("Day la chu hoa.");
                    else
                        Console.WriteLine("Day la chu thuong.");
                }
                else
                {
                    Console.WriteLine("Ky tu khong phai là chu cai.");
                }
            }

            // Hàm đếm số lần xuất hiện của chuỗi con
            static int CountSubstringOccurrences(string mainStr, string subStr)
            {
                int count = 0, index = 0;
                while ((index = mainStr.IndexOf(subStr, index)) != -1)
                {
                    count++;
                    index += subStr.Length;
                }
                return count;
            }

            // Hàm thêm chuỗi con vào trước lần xuất hiện đầu tiên
            static string InsertSubstringBefore(string mainStr, string insertStr, string targetStr)
            {
                int position = mainStr.IndexOf(targetStr);
                if (position >= 0)
                {
                    return mainStr.Insert(position, insertStr);
                }
                else
                {
                    return mainStr; // Nếu không tìm thấy chuỗi con, trả về chuỗi gốc
                }
            }
        }
    }
