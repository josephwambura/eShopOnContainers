﻿global using MediatR;

global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.Storage;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Exceptions;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure.EntityConfigurations;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure.Idempotency;

global using System;
global using System.Data;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;
