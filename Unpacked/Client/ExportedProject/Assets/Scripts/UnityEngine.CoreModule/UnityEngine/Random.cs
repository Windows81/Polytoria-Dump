namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
[Token(Token = "0x2000118")]
public static class Random
{

	[Token(Token = "0x17000171")]
	public static Vector3 insideUnitSphere
	{
		[Address(RVA = "0x196BD90", Offset = "0x196AF90", Length = "0x3E")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Die", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player+<DoDie>d__220", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction]
		[Token(Token = "0x60008A2")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x196BD90", Offset = "0x196AF90", Length = "0x3E")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Die", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<DoDie>d__220", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x60008A2")]
	public static Vector3 get_insideUnitSphere() { }

	[Address(RVA = "0x196BD50", Offset = "0x196AF50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008A3")]
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	[Address(RVA = "0x196BCC0", Offset = "0x196AEC0", Length = "0x3E")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction]
	[Token(Token = "0x60008A1")]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[Address(RVA = "0x196BD00", Offset = "0x196AF00", Length = "0x4A")]
	[CalledBy(Type = "Polytoria.Lua.LuaColor3", Member = "Random", ReturnType = typeof(Color))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction]
	[Token(Token = "0x600089F")]
	public static float Range(float minInclusive, float maxInclusive) { }

	[Address(RVA = "0x196BCC0", Offset = "0x196AEC0", Length = "0x3E")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A0")]
	public static int Range(int minInclusive, int maxExclusive) { }

}

