class CatalogoJogos
{
    private List<Jogo> jogos = new List<Jogo>();
    public string Categoria { get; set; }
    public CatalogoJogos (string categoria)
    {
        Categoria = categoria;
    }
    public void AdicionarJogo(Jogo jogo)
    {
        jogos.Add(jogo);
    }

    public void RemoverJogo(Jogo jogo)
    {
        jogos.Remove(jogo);
    }
}