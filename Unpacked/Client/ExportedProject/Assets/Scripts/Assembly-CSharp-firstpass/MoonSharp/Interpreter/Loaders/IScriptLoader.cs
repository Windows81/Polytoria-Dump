namespace MoonSharp.Interpreter.Loaders;

[Token(Token = "0x20000C0")]
public interface IScriptLoader
{

	[Token(Token = "0x6000834")]
	public object LoadFile(string file, Table globalContext) { }

	[Obsolete("This serves almost no purpose. Kept here just to preserve backward compatibility.")]
	[Token(Token = "0x6000835")]
	public string ResolveFileName(string filename, Table globalContext) { }

	[Token(Token = "0x6000836")]
	public string ResolveModuleName(string modname, Table globalContext) { }

}

