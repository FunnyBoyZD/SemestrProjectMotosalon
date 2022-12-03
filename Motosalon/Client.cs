using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon
{
    [Serializable]
    public class Client: IPrintable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                string PhoneNumberNonMasked = "";

                if (value.Length == 14)
                {
                    for (int i = 0; i < 14; i++)
                    {
                        if (i == 0 || i == 4 || i == 5 || i == 9)
                        {
                            continue;
                        }
                        PhoneNumberNonMasked += value[i];
                    }
                }
                else
                {
                    throw new PhoneException("Неправильний формат номеру телефона", value);
                }

                if (PhoneNumberNonMasked.Length == 10 && Int64.TryParse(PhoneNumberNonMasked, out long result) == true)
                {
                    phoneNumber = PhoneNumberNonMasked;
                }
                else
                {
                    throw new PhoneException("Неправильний формат номеру телефона", value);
                }
            }
        }
        private string comment;
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                if (value.Length <= 80)
                {
                    comment = value;
                }
                else
                {
                    throw new CommentException("Довжина рядку повинна бути менша 80 символів", value.Length);
                }
            }
        }
        public Mototransport BoughtMoto { get; set; }

        public Client(string Name, string Surname, string PhoneNumber, string Comment, Mototransport BoughtMoto)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Comment = Comment;
            this.BoughtMoto = BoughtMoto;
        }

        public string Print()
        {
            return $"Ім'я: {Name}\n\nПрізвище: {Surname}\n\nНомер телефону: {PhoneNumber}";
        }
    }
}
