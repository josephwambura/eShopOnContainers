﻿global using CatalogApi;

global using Devspaces.Support;

global using Grpc.Core;
global using Grpc.Core.Interceptors;

global using GrpcBasket;

global using GrpcOrdering;

global using HealthChecks.UI.Client;

global using Microsoft.AspNetCore;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Config;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Filters.Basket.API.Infrastructure.Filters;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Infrastructure;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Models;
global using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Services;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;

global using Serilog;

global using Swashbuckle.AspNetCore.SwaggerGen;

global using System;
global using System.Collections.Generic;
global using System.IdentityModel.Tokens.Jwt;
global using System.Linq;
global using System.Net;
global using System.Net.Http;
global using System.Net.Http.Headers;
global using System.Text.Json;
global using System.Threading;
global using System.Threading.Tasks;
