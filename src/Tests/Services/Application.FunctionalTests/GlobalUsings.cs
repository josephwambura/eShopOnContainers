global using FunctionalTests.Extensions;
global using FunctionalTests.Middleware;
global using FunctionalTests.Services.Basket;
global using FunctionalTests.Services.Catalog;

global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.TestHost;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF;
global using Microsoft.eShopOnContainers.Services.Basket.API.Model;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure;
global using Microsoft.eShopOnContainers.Services.Ordering.API;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;

global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Net.Http;
global using System.Reflection;
global using System.Security.Claims;
global using System.Text;
global using System.Text.Json;
global using System.Threading.Tasks;

global using WebMVC.Services.ModelDTOs;

global using Xunit;
