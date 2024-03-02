namespace LBMS
{
    internal class Author
    {
        private string name;
        private string email;
        public Author(string name, string email)
        {
            this.email = email;
            this.name = name;
        }
        public void SetName(string Name)
        {
            this.name = Name;
        }
        public void SetEmail(string Email)
        {
            this.email = Email;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetEmail()
        {

            return this.email;
        }
    }
}
