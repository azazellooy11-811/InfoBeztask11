using System;

namespace InfoBezZ1
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] characters = new char[] { '=', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                                                'Э', 'Ю', 'Я' };
            char[] keyword = "ИСКРА".ToCharArray();
            string result = "";
            char[] massage = "ФАОХБИИРЭПЛЧЦРЕОЮЛЦУИ=ЛЮАКАЧМОШСЮ=АЫЭЪБЁОСНВЁМАКВБЦСЪЯАМЮЯТПФАКЯЁЫИЛВУО=КВШЙГЮЭЙЛМРРМЖЦФРООСАСНЗДКУАШИРБЁНРАРООСЬДДЙПЮВ=ИФКГСЙ=ЭАПЪДРРООСЭАМОДЩЪШЙПЮРПИЭЪЭМОХЛЁАЫИЛВУХЫНЛЁИЮИХЙИФКХСЭХЪЫАЪЧЛЭЭЧАЭГЙИЫШРЮЬАКЯЙИЭКЗЁЦЕ".ToCharArray();

            int keyword_index = 0;

            foreach (char symbol in massage)
            {
                int p = (Array.IndexOf(characters, symbol) + 34 -
                    Array.IndexOf(characters, keyword[keyword_index])) % 34;

                result += characters[p];

                keyword_index++;

                if ((keyword_index) == keyword.Length)
                    keyword_index = 0;
            }

            Console.WriteLine(result);
        }
    }
}
