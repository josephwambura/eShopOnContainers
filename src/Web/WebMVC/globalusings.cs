﻿global using Devspaces.Support;

global using HealthChecks.UI.Client;

global using Microsoft.AspNetCore;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.Cookies;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authentication.OpenIdConnect;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.DataProtection;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using Microsoft.eShopOnContainers.WebMVC;
global using Microsoft.eShopOnContainers.WebMVC.Services;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels.Annotations;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels.CartViewModels;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels.CatalogViewModels;
global using Microsoft.eShopOnContainers.WebMVC.ViewModels.Pagination;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Logging;

global using Serilog;

global using StackExchange.Redis;

global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.IdentityModel.Tokens.Jwt;
global using System.IO;
global using System.IO.Compression;
global using System.Linq;
global using System.Net.Http;
global using System.Net.Http.Headers;
global using System.Security.Claims;
global using System.Security.Principal;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Threading;
global using System.Threading.Tasks;

global using WebMVC.Infrastructure;
global using WebMVC.Services.ModelDTOs;