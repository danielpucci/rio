using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.TimeSheet
{
    interface ITimeSheetRepository
    {

        /// <summary>
        /// Retorna todas as alocações do usuário
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Lista de alocações do usuário</returns>
        IEnumerable<Modelo.Alocacao> GetAlocacao(int id);

        /// <summary>
        /// Retorna todos os dados de ponto do usuário
        /// </summary>
        /// <param name="id">Identificador do usuário</param>
        /// <returns>Lista de ponto do usuário</returns>
        IEnumerable<Modelo.Livro> GetLivro(int id);

        /// <summary>
        /// Insere um novo registro de alocação
        /// </summary>
        /// <param name="value">Dados a serem inseridos</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool PostAlocacao(string value);

        /// <summary>
        /// Insere um novo registro de livro
        /// </summary>
        /// <param name="value">Dados a serem inseridos</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool PostLivro(string value);

        /// <summary>
        /// Altera um novo registro de livro
        /// </summary>
        /// <param name="id">Identificador do livro</param>
        /// <param name="value">Dados a serem alterados</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool PutLivro(int id, string value);

        /// <summary>
        /// Altera um novo registro de livro
        /// </summary>
        /// <param name="id">Identificador da alocação</param>
        /// <param name="value">Dados a serem alterados</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool PutAlocacao(int id, string value);

        /// <summary>
        /// Apaga registro de livro
        /// </summary>
        /// <param name="id">Identificador do livro</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool DeleteLivro(int id);

        /// <summary>
        /// Apaga registro de alocação
        /// </summary>
        /// <param name="id">Identificador da alocação</param>
        /// <returns>retorna "true" para sucesso</returns>
        bool DeleteAlocacao(int id);
    }
}
