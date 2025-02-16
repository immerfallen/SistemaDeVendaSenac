﻿namespace SistemaDeVenda.Server.Features.Venda
{
    using SistemaDeVenda.Server.Infra;
    using MediatR;
    using Domain;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Tempus.Utils;
    

    public class Excluir
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
        }

        public class CommandHandler : AsyncRequestHandler<Command>
        {
            readonly SistemaDeVendaContext _context;
            readonly IMediator _mediator;

            public CommandHandler(SistemaDeVendaContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            protected override async Task HandleCore(Command request)
            {
                var venda = await _context
                    .Set<Venda>()
                    .FirstOrDefaultAsync(e => e.Id == request.Id);

                ChecarSe.Encontrou(venda);

                _context.Remove(venda);

                await _context.SaveChangesAsync();
            }
        }
    }
}