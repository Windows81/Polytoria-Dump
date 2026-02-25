namespace Polytoria.Lua;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x2000300")]
public class LuaCallbackParameter : PropertyAttribute
{

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA8")]
	public LuaCallbackParameter(string callback, Type type, string name, bool nullable = false) { }

}

