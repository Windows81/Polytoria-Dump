namespace Polytoria.Lua;

[Token(Token = "0x2000305")]
public class LuaJSON
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC3")]
	public LuaJSON() { }

	[Address(RVA = "0x40E500", Offset = "0x40D700", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001BC2")]
	public static JSONNode[] GetChildrenAsArray(JSONNode json) { }

	[Address(RVA = "0x40E560", Offset = "0x40D760", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[Token(Token = "0x6001BC1")]
	public static JSONNode Parse(string aJSON) { }

}

