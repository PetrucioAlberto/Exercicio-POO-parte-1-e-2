using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_6
{
    class RedeSocial
    {
        private Dictionary<string, List<string>> amigos;
        private Dictionary<string, List<string>> posts;

        public RedeSocial()
        {
            amigos = new Dictionary<string, List<string>>();
            posts = new Dictionary<string, List<string>>();
        }

       
        public void AdicionarAmigo(string usuario, string amigo)
        {
            Console.WriteLine($"Adicionando amigo: {amigo} para o usuário: {usuario}");

            if (!amigos.ContainsKey(usuario))
            {
                amigos[usuario] = new List<string>();
            }

            amigos[usuario].Add(amigo);
        }

       
        public void PublicarMensagem(string usuario, string mensagem)
        {
            Console.WriteLine($"Publicando mensagem de {usuario}: {mensagem}");

            if (!posts.ContainsKey(usuario))
            {
                posts[usuario] = new List<string>();
            }

            posts[usuario].Add(mensagem);
        }

        
        public void ComentarPost(string usuario, string autorPost, string comentario)
        {
            Console.WriteLine($"Comentando post de {autorPost} por {usuario}: {comentario}");

            if (posts.ContainsKey(autorPost))
            {
                posts[autorPost].Add($"{usuario}: {comentario}");
            }
            else
            {
                Console.WriteLine("Post nao encontrado.");
            }
        }

       
        public void BuscarUsuario(string usuario)
        {
            Console.WriteLine($"Buscando usuario: {usuario}");

            if (amigos.ContainsKey(usuario))
            {
                Console.WriteLine($"Amigos de {usuario}:");
                foreach (var amigo in amigos[usuario])
                {
                    Console.WriteLine(amigo);
                }
            }
            else
            {
                Console.WriteLine("Usuario nao encontrado.");
            }
        }
    }
}
