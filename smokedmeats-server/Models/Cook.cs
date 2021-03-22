namespace smokedmeats_server
{
    public class Cook
    {
        public int Id { get; set; }

        public int CookTemp { get; set; }

        public int CookTime { get; set; }

        public string Description { get; set; }

        public string MeatType { get; set; }

        public decimal MeatWeight { get; set; }

        public string CookPhoto { get; set; }


        public Profile Creator { get; set; }

        public class VaultCookViewModel : Cook
        {
            public int VaultCookId { get; set; }
        }


    }
}