

namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone number: {phone}");
            Console.WriteLine();
        }
    }
}
