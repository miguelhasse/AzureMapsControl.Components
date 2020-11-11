# AzureMapsControl.Components

Azure Maps Control Razor Components

![Nuget](https://img.shields.io/nuget/v/AzureMapsControl.Components) ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/AzureMapsControl.Components) ![Nuget](https://img.shields.io/nuget/dt/AzureMapsControl.Components)

## Install the Nuget Package

This library is available on Nuget as `AzureMapsControl.Components`.

## Add the css and scripts

You will need to add the atlas script and css files as well as the script generated by the library on your application.

```
@page "/"
@namespace AzureMapsControl.Restore.Pages
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@{
    Layout = null;
}

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>AzureMapsControl.Sample</title>
    <base href="~/" />
    <link rel="stylesheet" href="https://atlas.microsoft.com/sdk/javascript/mapcontrol/2/atlas.min.css" type="text/css" />
    <style>
        body {
            margin: 0;
        }

        #map {
            position: absolute;
            width: 100%;
            min-width: 290px;
            height: 100%;
        }
    </style>
</head>
<body>
    <app>
        <component type="typeof(App)" render-mode="ServerPrerendered" />
    </app>

    <script src="https://atlas.microsoft.com/sdk/javascript/mapcontrol/2/atlas.min.js"></script>
    <script src="_content/AzureMapsControl.Components/azureMapsControl.js"></script>
    <script src="_framework/blazor.server.js"></script>
</body>
</html>
```

If you plan to use the drawing toolbar, you also need to include the following css and scripts :

```
<link rel="stylesheet" href="https://atlas.microsoft.com/sdk/javascript/drawing/0.1/atlas-drawing.min.css" type="text/css" />
```

```
<script src="https://atlas.microsoft.com/sdk/javascript/drawing/0.1/atlas-drawing.min.js"></script>
```

## Register the Components

You will need to pass the authentication information of your `AzureMaps` instance to the library. `SubscriptionKey` and `Aad` authentication are supported. You will need to call the `AddAzureMapsControl` method on your services.

You can authenticate using a `subscription key` :

```
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddAzureMapsControl(configuration => configuration.SubscriptionKey = "Your Subscription Key");
    }
```

Or using `Azure Active Directory`:

```
public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor(options => options.DetailedErrors = true);

            services.AddAzureMapsControl(configuration => {
                configuration.AadAppId = "Your Aad App Id";
                configuration.AadTenant = "Your Aad Tenant";
                configuration.ClientId = "Your Client Id";
            });
        }
```

## How to use

- [Map](docs/map)
- [Controls](docs/controls)
- [Drawing Toolbar](docs/drawingtoolbar)
- [Html Markers](docs/htmlmarkers)
- [Layers](docs/layers)
- [Traffic](docs/traffic)
