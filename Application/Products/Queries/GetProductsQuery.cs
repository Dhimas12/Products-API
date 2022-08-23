﻿using Application.Products.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IQueryable<ProductDto>>
    {
    }
}
