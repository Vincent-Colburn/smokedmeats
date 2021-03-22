namespace smokedmeats_server
{
    public class VaultCook
    {
        public int Id { get; set; }

        public string CreatorId { get; set; }

        public int VaultId { get; set; }

        public int CookId { get; set; }

        public Profile Creator { get; set; }
    }
}