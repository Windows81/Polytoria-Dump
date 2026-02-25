namespace Polytoria.Lua;

[AttributeUsage(AttributeTargets::Property (128), AllowMultiple = True)]
[Token(Token = "0x2000301")]
public class LuaEventParameter : PropertyAttribute
{

	[Address(RVA = "0x40DF10", Offset = "0x40D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA9")]
	public LuaEventParameter(Type type, string name, bool nullable = false) { }

}

