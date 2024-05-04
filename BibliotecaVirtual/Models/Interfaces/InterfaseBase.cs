namespace BibliotecaVirtu.Models.Interfaces
{
    public abstract class InterfaseBase
    {
        public string Id { get; set; }

        public InterfaseBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
