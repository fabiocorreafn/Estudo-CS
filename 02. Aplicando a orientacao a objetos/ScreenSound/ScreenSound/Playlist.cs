class Playlist
{
    public Playlist(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    private List<Musica> ListaDeMusicas { get; set; } = new List<Musica>();
    public bool Visibilidade;
    /* A ideia é que se a Playlist tiver Visibilidade = true ela pode ser visualizada por qualquer pessoas,
     * mas se Visibilidade = false, apenas o dono pode visualizar. True significa "Pública" e False significa "Privada"
     */

    public bool Colaboracao;
    /* A ideia é que se a Playlist tiver Colaboracao = true é uma playlist colaborativa onde qualquer pessoa pode
     * adicionar músicas, se Colaboracao = false, somente o dono pode adicionar múscas. Outro detalhe é que
     * independentemente do status de Colaboracao, a remoção de músicas só pode ser feita pelo dono. O dono também pode
     * alterar o status da Playlist entre true e false a qualquer momento, tanto na Colaboração quanto na Visibilidade.
     */
    
    public void AdicionarMusica(Musica musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void ExibirPlaylist()
    {
        string visibilidade, colaboracao;

        if (Visibilidade)
        {
            visibilidade = "Pública";
        }
        else
        {
            visibilidade = "Privada";
        }
        
        if (Colaboracao)
        {
            colaboracao = "Sim";
        }
        else
        {
            colaboracao = "Não";
        }

        if (Visibilidade)
        {
            Console.WriteLine($"\nMúsicas da Playlist: {Nome}\n");
            foreach (Musica musica in ListaDeMusicas)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
            Console.WriteLine($"\nVisibilidade da Playlist: {visibilidade.ToUpper()}");
            Console.WriteLine($"Playlist Colaborativa: {colaboracao.ToUpper()}");
        }
        else
        {
            Console.WriteLine($"Playlist {visibilidade.ToUpper()}: Não é possível visualizar o conteúdo!");
        }
        
    }
}