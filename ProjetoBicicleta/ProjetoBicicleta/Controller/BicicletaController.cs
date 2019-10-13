using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBicicleta.Model;

namespace ProjetoBicicleta.Controller
{
    public class BicicletaController
    {
        BicicletaContextDB bicicletaContextDB = new BicicletaContextDB();

        public IQueryable<Bicicleta> ListarBicicletas()
        {
            return bicicletaContextDB.GetBicicleta.Where(x => x.Ativo == true);
        }

        public bool AddBicicleta(Bicicleta item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca)) //nosso tipo contem varios metodos prontos para string e metodo que identifica espacos em branco e campo que vai validar
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Valor <= 0)
                return false;

            bicicletaContextDB.GetBicicleta.Add(item);
            bicicletaContextDB.SaveChanges();
            return true;
        }

        public bool AtualizarBicicleta(Bicicleta item)
        {
            var bicicleta = bicicletaContextDB.GetBicicleta.FirstOrDefault(x => x.Id == item.Id); //buscando na tabela o celular e regra para realizar a busca
            if (bicicleta == null)//falamos que nosso celular da tabela vai ser igual nosso celular que estamos passando, e verificamos se ele realmente encontrou um celular
            {
                return false; //caso nao encontramos retornando false
            }
            else
            {
                // nosso celular da tabela vai ser igual nosso celular que estamos passando
                //bicicleta.DataAlteracao = DateTime.Now;
                bicicletaContextDB.SaveChanges();
            }
            return true; //retornando a atualizacao
        }
        //remocao
        /// <summary>
        /// metodo utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso</returns>
        public bool RemoverBicicleta(int id)
        {
            var celular = bicicletaContextDB.GetBicicleta.FirstOrDefault(x => x.Id == id);
            if (celular == null)
                return false;

            celular.Ativo = false; //desativamos o item
            bicicletaContextDB.SaveChanges();//salva no BD

            return true; //retorna verdadeiro
        }


    }

}
