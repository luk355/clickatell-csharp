# Clickatell C# Library

[![Build status](https://ci.appveyor.com/api/projects/status/25dfc1r08o5krj1h/branch/master?svg=true)](https://ci.appveyor.com/project/luk355/clickatell-csharp/branch/master)
[![MyGet CI](https://img.shields.io/myget/luk355-ci/v/Clickatell.Services.svg)](http://myget.org/gallery/luk355-ci)
[![NuGet](https://img.shields.io/nuget/v/Clickatell.Services.svg)](https://www.nuget.org/packages/Clickatell.Services/)

Fork of clickatell-csharp library that integrates with Clickatell HTTP and REST APIs. Main purpose of this fork is to push this implementation into NuGet making it easier to use this library.

You can see other libraries and more documentation at the [Clickatell APIs and Libraries Project](http://clickatell.github.io/).

**Package** - [Clickatell.Services](http://nuget.org/packages/clickatell.services)


## About
This package allows one to build a Clickatell SMS library that can be linked to your C# application. Said library provides public functions which make calls to Clickatell's HTTP and REST APIs, allowing one to send SMSes, query their user credit balance, query an SMS status, query the cost of an SMS,check SMS route coverage and stop an SMS.

The package also contains a simple C# ASP.NET test application that when compiled, links with the Clickatell SMS library. This test application indicates how to test SMS functionality of the Clickatell SMS library.

All three projects contains extensive code commenting.

**Library** - Clickatell.Services

**Test App** - TestLibraryConsume

**Authors** - Dewald de Bod, Justin Kotze, Lukas Behal

**Date** - 2016-10-18

**Environment** - Windows
