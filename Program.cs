// See https://aka.ms/new-console-template for more information

namespace BTVN;
class Buoi2
{
    public static void Main()
    {
        //ABC
    }

    private static string Bai1(int[] input)
    {
        //Cho 1 mảng đầu vào kiểu int gồm n phần tử, kiểm tra xem phần tử nào ko trùng trong mảng đó
        //VD: Có mảng[1, 3, 6, 2, 3, 6, 1] thì 2 là phần tử ko bị trùng
        //Xử lý kết quả dựa theo đầu vào input rồi gán vào biến result
        return cach2(input);
    }

    private static string cach1(int[] input)
    {
        List<int> listInput = input.ToList();
        listInput.Sort(); // 10000
        int result = input[0];

        //Cách 1:
        // 1 1 2 3 3
        // 0 1 2 3 4
        for (int i = 1; i < listInput.Count; i++) // i = 3 //10000
        {
            if (result == listInput[i]) // 2 == 3
            {
                result = -1; // = -1
                continue;
            }

            if (result == -1) // result = 2 != 1
            {
                result = listInput[i]; // result = 2
            }
        }

        return "" + result;
    }

    private static string cach2(int[] input)
    {
        int result = -1;

        for (int i = 0; i < input.Length; i++) // length = 10000
        {
            result = input[i];
            for (int j = 0; j < input.Length; j++) //length = 10000 * 100000
            {
                if (i == j) continue;
                if (input[i] == input[j])
                {
                    result = -1;
                    break;
                }
            }
            if (result != -1) break;
        }

        return "" + result;
    }

    private static void Bai2(string[]name, int[] grade)
    {
        //Xử lý kết quả dựa theo đầu vào là mảng name và mảng grade rồi gán vào biến result
        // A B C D E F G
        // 5 4 5 7 4 6 7

        // 7 7 6 5 5 4 4
        // D G F A C B E
        Dictionary<string, int> dsDiem = new Dictionary<string, int>();
        for (int i = 0; i < grade.Length; i++)
        {
            dsDiem.Add(name[i], grade[i]);
        }

        int highest = 0;
        foreach (var item in dsDiem.OrderByDescending(x => x.Value))
        {
            if (highest == 0) {
                highest = item.Value;
                Console.WriteLine(item.Key + " " + item.Value);
                continue;
            }
            
            if (highest == item.Value)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            } else
            {
                break;
            }
        }
    }
}
