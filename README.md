## Original Docs
* Microsoft docs for custom templates: https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
* Blog post: https://www.infoq.com/articles/dotnet-core-template-engine/

### `template.json`
Listed below are some details I've discovered about the `template.json` file that is part of project templates.

#### `postActions`

##### Reserved `postActions`
Some `postActions` are specifically registered with some of the Microsoft tools, like Visual Studio. Using the `actionId` that will allow you to hook into existing behaviors as you see fit.

* action Id `210D431B-A78B-4D2F-B762-4ED3E3EA9025`: perform a `dotnet restore` on the project

### `vs-2017.host.json`
Listed below are some details I've discovered about the `vs-2017.3.host.json` file that can be included in project templates.

#### `disableHttpsSymbol`
Used to display the "Configure for HTTPS" checkbox in the dialog. Should be set to the name of a parameter in the `template.json` such as `NoHttps`

#### `supportsDocker`
Used to display the "Enable Docker Support" checkbox in the dialog.

#### `ports`
Used to provide port numbers to parameters defined in the `template.json`. Setting the `useHttps` value on a `port` object will create a port number that can be properly used for HTTPS.

### Examples
* ASP.NET Core standard templates: https://github.com/aspnet/AspNetCore/tree/master/src/ProjectTemplates