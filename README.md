# PoliceAPI_Client
A C# Wrapper around the Police API (data.police.uk).

# Introduction

The Police Data API Wrapper is a convenient C# library that simplifies access to the Data Police UK API.
The Data Police UK API provides comprehensive data related to police forces, neighborhoods, and actual crimes. 
By leveraging this wrapper, developers can easily integrate police data into their C# applications. 
The official documentation for the Data Police UK API can be found here.

# Getting Started

## Installation

To begin using the Police Data API Wrapper, you can install the NuGet package using one of the following methods:

### Package Manager Console:
Install-Package PoliceAPI_Client

### .NET CLI:
dotnet add package PoliceAPI_Client

### Visual Studio:
Right-click on your project in the Solution Explorer.
Select "Manage NuGet Packages."
Search for "PoliceAPI_Client" and click "Install."

## Authentication
The Data Police UK API no longer requires authentication to access its data. 
You can freely make API calls without the need for an API key or any authentication mechanism. 
This wrapper provides a convenient way to interact with the API and retrieve information about police forces, neighborhoods, and actual crimes. 
By leveraging the wrapper, you can seamlessly integrate police data into your C# applications without any authentication overhead.

Basic Usage

The Police Data API Wrapper provides four main services: Crime Service, Force Service, Neighbourhood Service, and Stop And Search Service. 
Each service has its corresponding interface:

ICrimeService
IForceService
INeighbourhoodService
IStopAndSearchService

You can use these services with or without dependency injection, based on your preferred approach. 
Here's an example of how you can hook up the services into dependency injection using the Microsoft.Extensions.DependencyInjection library:

```cs
using Microsoft.Extensions.DependencyInjection;
using PoliceDataApiWrapper;
using PoliceDataApiWrapper.Services;

// Create a service collection
var services = new ServiceCollection();

// Add the PoliceDataApiClient to the service collection
services.AddSingleton<RegistrationContainer>();
```
