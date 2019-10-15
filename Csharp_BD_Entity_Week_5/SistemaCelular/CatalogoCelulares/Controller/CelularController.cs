using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    public class CelularController
    {

        CelularesContextDB contextDB = new CelularesContextDB();

        //inserir
        //atualizacao
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca)) //nosso tipo contem varios metodos prontos para string e metodo que identifica espacos em branco e campo que vai validar
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Preco <= 0)
                return false;

            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        //listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas 
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativos apenas</returns>
        public IQueryable<Celular> GetCelulars()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true); //acesso ao BD com filtro where e as condicoes
        }

      /// <summary>
      /// Metodo que atualiza um registro valido do nosso sistema
      /// </summary>
      /// <param name="item">item que vamos atualizar</param>
      /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id); //buscando na tabela o celular e regra para realizar a busca
            if (celular == null)//falamos que nosso celular da tabela vai ser igual nosso celular que estamos passando, e verificamos se ele realmente encontrou um celular
            {
                return false; //caso nao encontramos retornando false
            }
            else
            {
                // nosso celular da tabela vai ser igual nosso celular que estamos passando
                celular.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
            }
            return true; //retornando a atualizacao
        }
        //remocao
        /// <summary>
        /// metodo utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso</returns>
        public bool RemoverCelular(int id)
        {
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);
            if (celular == null)
                return false;

            celular.Ativo = false; //desativamos o item
            contextDB.SaveChanges();//salva no BD

            return true; //retorna verdadeiro
        }
    }
}
