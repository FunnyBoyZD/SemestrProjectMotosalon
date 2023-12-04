using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Motosalon
{
    public delegate void OrderCreationHandler(Client client);
    [Serializable]
    public class Client
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [DefaultValue("NONAME")]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        private string phoneNumber;
        [Required]
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
        public int? BoughtMotoId { get; set; }
        public Mototransport BoughtMoto { get; set; }
        public event OrderCreationHandler OnCall;
        public Client()
        {
            Name = string.Empty;
            Surname = string.Empty;
            phoneNumber = string.Empty;
            Comment = string.Empty;
        }
        public Client(string Name, string Surname, string PhoneNumber, string Comment, Mototransport BoughtMoto)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Comment = Comment;
            this.BoughtMoto = BoughtMoto;
            OnCall?.Invoke(this);
        }
        public string Print()
        {
            return $"Ім'я: {Name}\n\nПрізвище: {Surname}\n\nНомер телефону: {PhoneNumber}";
        }
    }
}
