﻿global using Autofac;
global using Autofac.Extensions.DependencyInjection;

global using Azure.Core;
global using Azure.Identity;

global using Grpc.Core;

global using HealthChecks.UI.Client;

global using Microsoft.AspNetCore;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Server.Kestrel.Core;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ;
global using Microsoft.eShopOnContainers.BuildingBlocks.EventBusServiceBus;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF.Services;
global using Microsoft.eShopOnContainers.BuildingBlocks.IntegrationEventLogEF.Utilities;
global using Microsoft.eShopOnContainers.Services.Catalog.API;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Extensions;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Grpc;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure.ActionResults;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure.EntityConfigurations;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure.Exceptions;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Infrastructure.Filters;
global using Microsoft.eShopOnContainers.Services.Catalog.API.IntegrationEvents;
global using Microsoft.eShopOnContainers.Services.Catalog.API.IntegrationEvents.EventHandling;
global using Microsoft.eShopOnContainers.Services.Catalog.API.IntegrationEvents.Events;
global using Microsoft.eShopOnContainers.Services.Catalog.API.Model;
global using Microsoft.eShopOnContainers.Services.Catalog.API.ViewModel;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;

global using Polly;
global using Polly.Retry;

global using RabbitMQ.Client;

global using Serilog;
global using Serilog.Context;

global using System;
global using System.Collections.Generic;
global using System.Data.Common;
global using System.Data.SqlClient;
global using System.Globalization;
global using System.IO;
global using System.IO.Compression;
global using System.Linq;
global using System.Net;
global using System.Reflection;
global using System.Text.RegularExpressions;
global using System.Threading.Tasks;
