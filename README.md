### `vs-2017.host.json`
#### `disableHttpsSymbol`
Used to display the "Configure for HTTPS" checkbox in the dialog. Should be set to the name of a parameter in the `template.json` such as `NoHttps`
#### `supportsDocker`
Used to display the "Enable Docker Support" checkbox in the dialog.
#### `ports`
Used to provide port numbers to parameters defined in the `template.json`. Setting the `useHttps` value on a `port` object will create a port number that can be properly used for HTTPS.