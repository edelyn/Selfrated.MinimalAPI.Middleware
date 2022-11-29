﻿using Selfrated.MinimalAPI.Middleware.Attributes;

namespace SampleProject.Endpoints;

[EndpointAPI(Name = null)]
public class ClassAttributeSettingsNoPrefix
{
    [EndpointMethod]
    public string HelloWorld()
    {
        return "Hello World!";
    }

    [EndpointMethod(RouteType = RouteType.POST)]
    public string HelloWorldOverrideRouteType()
    {
        return "Hello World!";
    }

}
