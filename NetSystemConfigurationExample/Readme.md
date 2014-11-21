# Short .Net `System.Configuration` Example

A small C# example console application that uses `system.configuration`.

It shows using multiple `settings` files.

Advantages over `ConfigurationManager`:

* code generator creates concrete code for each setting value
    * no need for embedded strings to define settings' names
    * settings are concrete, serialize values. No more converting from a string
* application and user level data
    * later can be modified and will be written to `%AppData%` under a versioned file/location
* default values are in code
* `app.config` and `%AppData%` files are optional and only need to be specified to override default values
* `app.config` is generated
