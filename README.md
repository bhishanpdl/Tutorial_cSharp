# Introduction
Tutorials for C# and .NET

# Using C# in Jupyter
- https://github.com/dotnet/interactive/blob/main/docs/NotebookswithJupyter.md

1. Download and intall [.Net 9 SDK](https://dotnet.microsoft.com/en-us/download)
1. check installation in bash terminal: `dotnet --version`
1. Install dotnet interactive: `dotnet tool install -g Microsoft.dotnet-interactive`
1. Install jupyter kernel: `dotnet interactive jupyter install`
1. Verify installation: `jupyter kernelspec list`
1. Update latest dotnet interactive: `dotnet tool update -g Microsoft.dotnet-interactive`
1. Open jupyter-notebook or jupyterlab, select the c# kernel and run the codes as usual.
1. The inputs are not taken in jupyter kernel console, you need to hard code or run the script locally without using jupyter.
