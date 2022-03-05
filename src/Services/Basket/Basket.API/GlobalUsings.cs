global using Autofac;
global using Autofac.Extensions.DependencyInjection;

global using Azure.Core;
global using Azure.Identity;

global using Basket.API.Infrastructure.ActionResults;
global using Basket.API.Infrastructure.Exceptions;
global using Basket.API.Infrastructure.Filters;
global using Basket.API.Infrastructure.Middlewares;
global using Basket.API.IntegrationEvents.EventHandling;
global using Basket.API.IntegrationEvents.Events;
global using Basket.API.Model;

global using Grpc.Core;

global using GrpcBasket;

global using HealthChecks.UI.Client;

global using Microsoft.AspNetCore;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Http.Features;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Authorization;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Server.Kestrel.Core;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusServiceBus;
global using Microsoft.eShopOnContainers.Services.Basket.API;
global using Microsoft.eShopOnContainers.Services.Basket.API.Controllers;
global using Microsoft.eShopOnContainers.Services.Basket.API.Infrastructure.Repositories;
global using Microsoft.eShopOnContainers.Services.Basket.API.IntegrationEvents.EventHandling;
global using Microsoft.eShopOnContainers.Services.Basket.API.IntegrationEvents.Events;
global using Microsoft.eShopOnContainers.Services.Basket.API.Model;
global using Microsoft.eShopOnContainers.Services.Basket.API.Services;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;

global using RabbitMQ.Client;

global using Serilog;
global using Serilog.Context;

global using StackExchange.Redis;

global using Swashbuckle.AspNetCore.SwaggerGen;

global using System;
global using System.Collections.Generic;
global using System.ComponentModel.DataAnnotations;
global using System.IdentityModel.Tokens.Jwt;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Security.Claims;
global using System.Text.Json;
global using System.Threading.Tasks;
