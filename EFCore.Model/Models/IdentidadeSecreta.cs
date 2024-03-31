namespace EFCore.Model.Models { 


    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
