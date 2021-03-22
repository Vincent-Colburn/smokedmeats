namespace smokedmeats_server
{
    public class Profile
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Picture { get; set; }
    }

    public class ProfileCookViewModel : Profile
    {
        public int ProfileCookId { get; set; }
    }
}