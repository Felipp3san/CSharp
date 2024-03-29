﻿using GestaoClix.Models;
using GestaoClix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices.ObjectiveC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace GestaoClix.Controllers
{
    internal class GestorMovimento
    {
        Database database = Database.getInstance();
        Movimento? movimento = null;

        public void AdicionarMovimento(DateTime data, string descricao, decimal valor, string situacao, int clienteId, int tipoId)
        {

                movimento = new Movimento(data, descricao, valor, situacao, clienteId, tipoId);

                if (database.Movimento is not null && movimento is not null)
                {
                    database.Movimento.Add(movimento);
                    database.SaveChanges();
                }

                movimento = null;
        }

        public void AtualizarMovimento(string idMovimento, DateTime data, string descricao, string situacao, decimal valor, int clienteId, int tipoId)
        {

            movimento = null;

            if (database.Movimento is not null)
            {
                movimento = database.Movimento.FirstOrDefault(e => e.Id == Convert.ToInt16(idMovimento));

                if (movimento is not null)
                {
                    movimento.Data = data;
                    movimento.Descricao = descricao;
                    movimento.Situacao = situacao;
                    movimento.Valor = valor;
                    movimento.ClienteId = clienteId;
                    movimento.TipoId = tipoId;
                }
            }

            try
            {
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoverMovimento(string idMovimento)
        {
            movimento = null;

            if (database.Movimento is not null)
            {
                movimento = database.Movimento.Where(x => x.Id == Convert.ToInt16(idMovimento)).FirstOrDefault();

                if (movimento is not null)
                {
                    database.Movimento.Remove(movimento);
                    database.SaveChanges();
                    movimento = null;
                }
            }
        }

        public List<ListaMovimento>? ListarMovimentos()
        {
            List<ListaMovimento>? listaMovimentos = null;

            if (database.Movimento is not null)
            {
                listaMovimentos = database.Movimento.Select(movimento => 
                    new ListaMovimento {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data.ToString("yyyy-MM-dd"),
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }

            return listaMovimentos;
        }

        public List<ListaMovimento>? ListarMovimentosCliente(string idCliente)
        {
            List<ListaMovimento>? listaMovimentos = null;

            if (database.Movimento is not null)
            {
                listaMovimentos = database.Movimento.Where(x => x.ClienteId == Convert.ToInt16(idCliente))
                    .Select(movimento => new ListaMovimento {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data.ToString("yyyy-MM-dd"),
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }

            return listaMovimentos;
        }

        public List<ListaMovimento>? ListarMovimentosClienteMesAno(string idCliente, int mes, int ano, int flag)
        {

            /* 
               Flag 1: filtra por cliente e mes,
               Flag 2: filtra por cliente e ano,
               Flag 3: filtra por cliente, mes e ano.
            */

            List<ListaMovimento>? listaMovimentos = null;

            if (database.Movimento is not null && flag == 1)
            {
                listaMovimentos = database.Movimento.Where(x => x.ClienteId == Convert.ToInt16(idCliente) && x.Data.Month == mes)
                    .Select(movimento => new ListaMovimento {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data.ToString("yyyy-MM-dd"),
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }
            else if (database.Movimento is not null && flag == 2)
            {
                listaMovimentos = database.Movimento.Where(x => x.ClienteId == Convert.ToInt16(idCliente) && x.Data.Year == ano)
                    .Select(movimento => new ListaMovimento {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data.ToString("yyyy-MM-dd"),
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }
            else if (database.Movimento is not null && flag == 3)
            {
                listaMovimentos = database.Movimento.Where(x => x.ClienteId == Convert.ToInt16(idCliente) && x.Data.Month == mes && x.Data.Year == ano)
                    .Select(movimento => new ListaMovimento {
                        Id = movimento.Id,
                        Descricao = movimento.Descricao,
                        Situacao = movimento.Situacao,
                        Data = movimento.Data.ToString("yyyy-MM-dd"),
                        Cliente = movimento.Cliente.Nome,
                        ClienteId = movimento.ClienteId,
                        Valor = movimento.Valor,
                        Tipo = movimento.Tipo.Designacao,
                        TipoId = movimento.TipoId
                    }).ToList();
            }

            return listaMovimentos;
        }
    }
}
