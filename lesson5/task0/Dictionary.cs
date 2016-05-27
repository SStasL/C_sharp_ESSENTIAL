using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Dictionary
    {
        private string[] ru = new string[5];
        private string[] en = new string[5];
        private string[] ua = new string[5];

        public Dictionary()
        {
            ru[0] = "книга";        en[0] = "book";     ua[0] = "книга";
            ru[1] = "ручка";        en[1] = "pen";      ua[1] = "ручка";
            ru[2] = "солнце";       en[2] = "sun";      ua[2] = "сонце";
            ru[3] = "яблоко";       en[3] = "apple";    ua[3] = "яблуко";
            ru[4] = "стол";         en[4] = "table";    ua[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < ru.Length; i++)
                {
                    if (ru[i] == index)
                        return ru[i] + " - " + en[i] + " - " + ua[i];

                    if (en[i] == index)
                        return ru[i] + " - " + en[i] + " - " + ua[i];

                    if (ua[i] == index)
                        return ru[i] + " - " + en[i] + " - " + ua[i];
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < ru.Length)
                    return ru[index] + " - " + en[index] + " - " + ua[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
