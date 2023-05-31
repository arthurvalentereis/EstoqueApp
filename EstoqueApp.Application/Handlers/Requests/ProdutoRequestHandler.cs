using EstoqueApp.Application.Handlers.Notifications;
using EstoqueApp.Application.Models.Commands.Produtos;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Application.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Handlers.Requests
{
    public class ProdutoRequestHandler :
        IRequestHandler<ProdutoCreateCommand, ProdutoQuery>,
        IRequestHandler<ProdutoUpdateCommand, ProdutoQuery>,
        IRequestHandler<ProdutoDeleteCommand, ProdutoQuery>
    {
        private readonly IMediator? _mediator;

        public ProdutoRequestHandler(IMediator? mediator)
        {
            _mediator = mediator;
        }

        public async Task<ProdutoQuery> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();
            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Create,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }

        public async Task<ProdutoQuery> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();
            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Create,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }

        public async Task<ProdutoQuery> Handle(ProdutoDeleteCommand request, CancellationToken cancellationToken)
        {
            var produtoQuery = new ProdutoQuery();
            await _mediator.Publish(
                new ProdutoNotification
                {
                    Action = ActionNotification.Create,
                    Produto = produtoQuery
                }
            );

            return produtoQuery;
        }
    }
}

