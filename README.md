# SmartCopy
<h3>A smart copy software which uses byte reading instead of simple copying.</h3>
<h4>Copyright | 2016 by Móricz Gergõ/saxophone All rights reserved.</h4>

# Download
There's a build.exe in the repository. DON'T BE LAZY!

# What we used
The code we just used:
```csharp
string pathx = Input.readpath; //Input class not exists. Use Console.ReadLine or textBoxPathx.Text instead of it.
string pathy = Input.writepath; //Input class not exists. Use Console.ReadLine or textBoxPathy.Text instead of it.
byte[] bytes = File.ReadAllBytes(pathx);
File.WriteAllBytes(pathy, bytes);
```
And that's it!